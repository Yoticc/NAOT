using dnlib.DotNet;
using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static NAOT.Core.Globals;
using NaotPaths = NAOT.Core.Globals.Paths.Naot;
using ObjNaotPaths = NAOT.Core.Globals.Paths.ObjNaot;
using System.Runtime.CompilerServices;
using System;
using System.Xml.Linq;
using dnlib.DotNet.Pdb;

public class AfterWriteIlcRspFileForCompilation : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {
            SetupGlobals();
            SetupNaot();
            SetupIlc();
            SetupObjNaot();
            SetupLibs();
            CopyLibraries();

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
        catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation: " + ex); }

        return true;
    }

    void SetupGlobals()
    {
        SetupVars();
        SetupPaths();

        void SetupVars()
        {
            Vars.Configuration = BuildEngine.GetEnvVar("Configuration") == "Debug" ? "Debug" : "Release";
            Vars.TargetBinDir = BuildEngine.GetEnvVar("TargetDir");
            Vars.AssemblyName = BuildEngine.GetEnvVar("AssemblyName");
            Vars.ProjectDir = BuildEngine.GetEnvVar("ProjectDir");
        }

        void SetupPaths()
        {
            Paths.TargetObjDir = Vars.TargetBinDir.Replace("\\bin", "\\obj"); // 🥶
            Paths.RspFile = Path.Combine(Paths.TargetObjDir, "native", $"{Vars.AssemblyName}.ilc.rsp");
            Paths.OutputNativeTargetFile = Path.Combine(Vars.TargetBinDir, "native", $"{Vars.AssemblyName}.dll");
            Paths.OutputTargetFile = Path.Combine(Paths.TargetObjDir, $"{Vars.AssemblyName}.dll");

            SetupNaotPaths();
            SetupObjNaotPaths();

            void SetupNaotPaths()
            {
                NaotPaths.Dir = Path.Combine(Vars.ProjectDir, "naot");
                NaotPaths.ConfigFile = Path.Combine(NaotPaths.Dir, "config.json");
                NaotPaths.AnalyzersDir = Path.Combine(NaotPaths.Dir, "analyzers");
            }
            
            void SetupObjNaotPaths()
            {
                ObjNaotPaths.Dir = Path.Combine(Paths.TargetObjDir, "naot");
                ObjNaotPaths.InDir = Path.Combine(ObjNaotPaths.Dir, "in");
                ObjNaotPaths.OutDir = Path.Combine(ObjNaotPaths.Dir, "out");
            }
        }
    }

    void SetupNaot()
    {
        if (!Directory.Exists(NaotPaths.Dir))
        {
            Directory.CreateDirectory(NaotPaths.Dir);

            File.Create(NaotPaths.ConfigFile).Dispose();
            File.WriteAllText(NaotPaths.ConfigFile, JsonConvert.SerializeObject(new Config()));

            Directory.CreateDirectory(NaotPaths.AnalyzersDir);
            File.CreateSymbolicLink(Path.Combine(NaotPaths.AnalyzersDir, "NAOT.Analyzer.dll"), Path.Combine(Paths.PackageNaotBuildDir, "NAOT.Analyzer.dll"));
        }
    }

    void SetupIlc()
    {
        Ilc.RspArguments = RSPArguments.Parse(File.ReadAllLines(Paths.RspFile));
    }

    void SetupObjNaot()
    {
        if (Directory.Exists(ObjNaotPaths.Dir))
            Directory.Delete(ObjNaotPaths.Dir, true);
        Directory.CreateDirectory(ObjNaotPaths.Dir);
        Directory.CreateDirectory(ObjNaotPaths.InDir);
        Directory.CreateDirectory(ObjNaotPaths.OutDir);
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
            Libs.CopiedOut.Main = Path.Combine(ObjNaotPaths.OutDir, $"{Vars.AssemblyName}.dll");

            foreach (var lib in Libs.References)
            {
                var libName = Path.GetFileName(lib);
                
                if (libName.Contains("microsoft.netcore.app.runtime") && libName.Contains("WindowsBase.dll"))
                    continue;
                
                var newInPath = Path.Combine(ObjNaotPaths.InDir, libName);
                var newOutPath = Path.Combine(ObjNaotPaths.OutDir, libName);

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

    void InitTaskManager()
    {
        Globals.TaskManager = new(
            typeof(InitTask),
            typeof(ILTask),
            typeof(ILActualTask),
            typeof(ILMainTask),
            typeof(PrepareNativeTask),
            typeof(ASMTask)
        );
    }

    void LoadAnalyzers()
    {
        Analyzers = new();

        AppDomain.CurrentDomain.AssemblyResolve += (s, e) => {
            var name = e.Name.Split(", ")[0].Replace(".resources", "");
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Concat([typeof(ModuleDef).Assembly]).ToList();

            var assembly = loadedAssemblies.Find(a => a.FullName != null && a.FullName.Split(", ")[0] == name);
            if (assembly == null)
                Console.WriteLine("AppDomain.CurrentDomain.AssemblyResolve: Cannot find loaded assembly for " + e.Name);
            return assembly;
        };

        foreach (var file in Directory.GetFiles(NaotPaths.AnalyzersDir))
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
            if (module == null)
                continue;
            Dn.Modules.All.Add(module);
            Dn.Modules.Input.Add(module);
            Dn.DnModules.All.Add(module.Module);
            Dn.DnModules.Input.Add(module.Module);
        }

        foreach (var lib in Libs.CopiedIn.References)
        {
            var module = LoadModule(lib);
            if (module == null)
                continue;
            Dn.Modules.All.Add(module);
            Dn.Modules.References.Add(module);
            Dn.DnModules.All.Add(module.Module);
            Dn.DnModules.References.Add(module.Module);
        }

        Dn.Modules.Main = mainModule;

        Dn.Modules.NAOT = Find("NAOT");
        Dn.Modules.SystemRuntimeInteropServices = Find("System.Runtime.InteropServices");
        Dn.Modules.SystemPrivateCoreLib = Find("System.Private.CoreLib");
        Dn.Modules.SystemLinq = Find("System.Linq");
        Dn.Modules.Mscorelib = Find("mscorlib");

        DnModule Find(string name)
        {
            var found = Dn.Modules.All.Find(m => m.Name == name);
            if (found == null)
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
        Globals.TaskManager.InvokeFor<ILActualTask>([.. Dn.DnModules.Input.Select(m => (object?[]?)[m]), [Dn.DnModules.Main]]);
    }

    void SaveLibraries()
    {
        foreach (var module in Dn.Modules.All)
            module.Module.Write(Path.Combine(ObjNaotPaths.OutDir, Path.GetFileName(module.Path)));
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
        Globals.TaskManager.Invoke<PrepareNativeTask>([]);
    }

    void PushRspArguments()
    {
        File.WriteAllLines(Paths.RspFile, Ilc.RspArguments.Serialize());
    }
}