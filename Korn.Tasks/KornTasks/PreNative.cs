using dnlib.DotNet;
using Korn.Core;
using Korn.Core.Tasks;
using Korn.Core.Utils;
using static Korn.Core.Globals;
using KornPaths = Korn.Core.Globals.Paths.Korn;
using ObjKornPaths = Korn.Core.Globals.Paths.ObjKorn;

public class PreNative : KornTask
{
    public override void Execute()
    {
        SetupGlobals();
        SetupKorn();

        SetupIlc();
        SetupObjKorn();
        SetupLibs();
        CopyLibraries();

        LoadConfig();
        InitTaskManager();

        LoadAnalyzers();
        LogAnalyzers();

        LoadLibraries();
        ExecuteILTasks();
        AddInputsInRsp();
        ExecutePrepareNativeTasks();
        SaveLibraries();
        PushRspArguments();
    }

    void SetupGlobals()
    {
        SetupVars();
        SetupPaths();

        void SetupVars()
        {
            Vars.Configuration = this["Configuration"] == "Debug" ? "Debug" : "Release";
            Vars.TargetBinDir = this["TargetDir"];
            Vars.AssemblyName = this["AssemblyName"];
            Vars.ProjectDir = this["ProjectDir"];
        }

        void SetupPaths()
        {
            Paths.TargetObjDir = Vars.TargetBinDir.Replace("\\bin", "\\obj"); // 🥶
            Paths.RspFile = Path.Combine(Paths.TargetObjDir, "native", $"{Vars.AssemblyName}.ilc.rsp");
            Paths.OutputNativeTargetFile = Path.Combine(Vars.TargetBinDir, "native", $"{Vars.AssemblyName}.dll");
            Paths.OutputTargetFile = Path.Combine(Paths.TargetObjDir, $"{Vars.AssemblyName}.dll");

            SetupKornPaths();
            SetupObjKornPaths();

            void SetupKornPaths()
            {
                KornPaths.Dir = Path.Combine(Vars.ProjectDir, "korn");
                KornPaths.ConfigFile = Path.Combine(KornPaths.Dir, "config.json");
                KornPaths.ConfigBuildCommandFile = Path.Combine(KornPaths.Dir, "korn-build command.txt");
                KornPaths.AnalyzersDir = Path.Combine(KornPaths.Dir, "analyzers");
            }

            void SetupObjKornPaths()
            {
                ObjKornPaths.Dir = Path.Combine(Paths.TargetObjDir, "korn");
                ObjKornPaths.InDir = Path.Combine(ObjKornPaths.Dir, "in");
                ObjKornPaths.OutDir = Path.Combine(ObjKornPaths.Dir, "out");
            }
        }
    }

    void SetupKorn()
    {
        const string DEFAULT_BUILD_COMMAND = "dotnet publish -r win-x64 -c Release";

        if (!Directory.Exists(KornPaths.Dir))
        {
            Directory.CreateDirectory(KornPaths.Dir);

            File.WriteAllText(KornPaths.ConfigFile, Json.Serial(new Config()));

            File.WriteAllText(KornPaths.ConfigBuildCommandFile, DEFAULT_BUILD_COMMAND);

            Directory.CreateDirectory(KornPaths.AnalyzersDir);
            File.CreateSymbolicLink(Path.Combine(KornPaths.AnalyzersDir, "Korn.Analyzer.dll"), Path.Combine(Paths.PackageBuildDir, "Korn.Analyzer.dll"));
        }
    }

    void SetupIlc()
    {
        Ilc.RspArguments = RSPArguments.Parse(File.ReadAllLines(Paths.RspFile));
    }

    void SetupObjKorn()
    {
        if (Directory.Exists(ObjKornPaths.Dir))
            Directory.Delete(ObjKornPaths.Dir, true);
        Directory.CreateDirectory(ObjKornPaths.Dir);
        Directory.CreateDirectory(ObjKornPaths.InDir);
        Directory.CreateDirectory(ObjKornPaths.OutDir);
    }

    List<(string oldPath, string newPath)> inLibrariesPath = new();
    void SetupLibs()
    {
        Libs.References = new();
        Libs.Main = Path.Combine(Paths.TargetObjDir, Vars.AssemblyName + ".dll");

        var addedLibNames = new List<string>();
        foreach (var lib in Ilc.RspArguments.References)
        {
            var libName = Path.GetFileName(lib);

            if (addedLibNames.Contains(libName))
                continue;

            addedLibNames.Add(libName);
            Libs.References.Add(lib);
        }

        SetupLibCopied();

        void SetupLibCopied()
        {
            Libs.CopiedIn.All = new();
            Libs.CopiedIn.Input = new();
            Libs.CopiedIn.References = new();
            Libs.CopiedOut.All = new();
            Libs.CopiedOut.Input = new();
            Libs.CopiedOut.References = new();
            Libs.CopiedOut.Main = Path.Combine(ObjKornPaths.OutDir, $"{Vars.AssemblyName}.dll");

            foreach (var lib in Libs.References)
            {
                var libName = Path.GetFileName(lib);

                if (libName.Contains("microsoft.netcore.app.runtime") && libName.Contains("WindowsBase.dll"))
                    continue;

                var newInPath = Path.Combine(ObjKornPaths.InDir, libName);
                var newOutPath = Path.Combine(ObjKornPaths.OutDir, libName);

                inLibrariesPath.Add((lib, newInPath));
                Libs.CopiedIn.All.Add(newInPath);
                Libs.CopiedOut.All.Add(newOutPath);
                if (lib.Contains("runtime.win-x64.microsoft.dotnet.ilcompiler") || lib.Contains("microsoft.netcore.app.runtime"))
                {
                    Libs.CopiedIn.References.Add(newInPath);
                    Libs.CopiedOut.References.Add(newOutPath);
                }
                else
                {
                    Libs.CopiedIn.Input.Add(newInPath);
                    Libs.CopiedOut.Input.Add(newOutPath);
                }
            }
        }
    }

    void CopyLibraries()
    {
        foreach ((var oldPath, var newPath) in inLibrariesPath)
            File.Copy(oldPath, newPath);
    }

    void LoadConfig()
    {
        try
        {
            Globals.Config = Json.FileDeserial<Config>(KornPaths.ConfigFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"AfterWriteIlcRspFileForCompilation->LoadConfig: Couldn't deserialize config. Will be used default: {ex}");
            Globals.Config = new();
        }
    }

    void InitTaskManager()
    {
        Globals.TaskManager = new(
            typeof(InitTask),
            typeof(ILTask),
            typeof(ILInputTask),
            typeof(ILMainTask),
            typeof(PreIlcTask),
            typeof(ASMTask)
        );
    }

    void LoadAnalyzers()
    {
        Analyzers = new();

        AppDomain.CurrentDomain.AssemblyResolve += (s, e) =>
        {
            var name = e.Name.Split(", ")[0].Replace(".resources", "");
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Concat([typeof(ModuleDef).Assembly]).ToList();

            var assembly = loadedAssemblies.Find(a => a.FullName is not null && a.FullName.Split(", ")[0] == name);
            if (assembly is null)
                Console.WriteLine("AppDomain.CurrentDomain.AssemblyResolve: Cannot find loaded assembly for " + e.Name);
            return assembly;
        };

        foreach (var file in Directory.GetFiles(KornPaths.AnalyzersDir))
        {
            var assembly = Assembly.LoadFrom(file);
            Analyzers.Add(assembly);
            Globals.TaskManager.AddExtractedTasks(assembly);
        }
    }

    void LogAnalyzers()
    {
        Console.WriteLine($"  Uses {Analyzers.Count} analyzers"); // This prints from time to time, related to project, idk what wrong. 
    }

    void LoadLibraries()
    {
        var resolver = new PathAssemblyResolver(Libs.CopiedIn.All);
        var ctx = new MetadataLoadContext(resolver, "mscorlib");
        Dn.Context = ModuleDef.CreateModuleContext();
        Dn.Modules.All = new();
        Dn.Modules.Input = new();
        Dn.Modules.References = new();
        Dn.DnModules.All = new();
        Dn.DnModules.Input = new();
        Dn.DnModules.References = new();

        var mainModule = LoadModule(Paths.OutputTargetFile);
        Dn.Modules.All.Add(mainModule);

        foreach (var lib in Libs.CopiedIn.Input)
        {
            var module = LoadModule(lib);
            if (module is null)
                continue;
            Dn.Modules.All.Add(module);
            Dn.Modules.Input.Add(module);
            Dn.DnModules.All.Add(module.Module);
            Dn.DnModules.Input.Add(module.Module);
        }

        foreach (var lib in Libs.CopiedIn.References)
        {
            var module = LoadModule(lib);
            if (module is null)
                continue;
            Dn.Modules.All.Add(module);
            Dn.Modules.References.Add(module);
            Dn.DnModules.All.Add(module.Module);
            Dn.DnModules.References.Add(module.Module);
        }

        Dn.Modules.Main = mainModule;

        Dn.Modules.This = Find("Korn");
        Dn.Modules.SystemRuntimeInteropServices = Find("System.Runtime.InteropServices");
        Dn.Modules.SystemPrivateCoreLib = Find("System.Private.CoreLib");
        Dn.Modules.SystemLinq = Find("System.Linq");
        Dn.Modules.Mscorelib = Find("mscorlib");

        DnModule Find(string name)
        {
            var found = Dn.Modules.All.Find(m => m.Name == name);
            if (found is null)
                Console.WriteLine($"AfterWriteIlcRspFileForCompilation->LoadLibs: Couldn't find module {name}");
            return found;
        }

        DnModule? LoadModule(string path)
        {
            var name = Path.GetFileNameWithoutExtension(path);
            var assembly = ctx.LoadFromAssemblyPath(path);
            var modules = assembly.Modules;

            var moduleCount = modules.Count();
            if (moduleCount == 0)
                Console.WriteLine($"Assembly {name} skipped because has no modules");
            else if (moduleCount > 1)
                Console.WriteLine($"Assembly {name} skipped because has more than one module");
            else
            {
                var reflectionModule = modules.First();
                var dnModule = ModuleDefMD.Load(reflectionModule, Dn.Context);
                var module = new DnModule(path, name, assembly, reflectionModule, dnModule);
                return module;
            }

            return null;
        }
    }

    void ExecuteILTasks()
    {
        Globals.TaskManager.Invoke<InitTask>([]);
        Globals.TaskManager.Invoke<ILMainTask>([Dn.DnModules.Main]);
        Globals.TaskManager.InvokeFor<ILTask>(Dn.DnModules.All.Select(m => (object?[]?)[m]).ToList());
        Globals.TaskManager.InvokeFor<ILInputTask>([.. Dn.DnModules.Input.Select(m => (object?[]?)[m]), [Dn.DnModules.Main]]);
    }

    void SaveLibraries()
    {
        foreach (var module in Dn.Modules.All)
            module.Module.Write(Path.Combine(ObjKornPaths.OutDir, Path.GetFileName(module.Path)));
    }

    void AddInputsInRsp()
    {
        var nonDllInputs = Ilc.RspArguments.Inputs.Where(i => !i.EndsWith(".dll")).ToList();
        Ilc.RspArguments.Inputs.Clear();
        Ilc.RspArguments.Inputs.AddRange(nonDllInputs);
        Ilc.RspArguments.Inputs.Add(Libs.CopiedOut.Main);
        Ilc.RspArguments.Inputs.AddRange(Libs.CopiedOut.Input);

        Ilc.RspArguments.References.Clear();
        Ilc.RspArguments.References.AddRange(Libs.CopiedOut.References);
    }

    void ExecutePrepareNativeTasks()
    {
        Globals.TaskManager.Invoke<PreIlcTask>([]);
    }

    void PushRspArguments()
    {
        File.WriteAllLines(Paths.RspFile, Ilc.RspArguments.Serialize());
    }
}