using dnlib.DotNet;
using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

public class AfterWriteIlcRspFileForCompilation : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {
            SetupVars();
            SetupNaot();
            LoadAnalyzers();
            LogAnalyzers();

            SetupNaotLibDir();
            CopyLibsToMirror();
            LoadLibs();
            ExecuteILTasks();
            SaveModules();
            SpoofMainLib();
            SpoofLibsPaths();
            AddInputsInRsp();
            ExecutePrepareNativeTasks();
            PushVars();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation: " + ex); }

        return true;
    }

    void PushVars()
    {
        File.WriteAllLines(Globals.RspFile, Globals.RspArguments.Serialize());
    }

    void ExecutePrepareNativeTasks()
    {
        var execute = typeof(PrepareNativeTask).GetMethods().First();

        foreach (var instance in Globals.PrepareNativeTaskInstances)
        {
            var task = instance.Task;
            try
            {
                execute.Invoke(task, []);
            }
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->ExecutePrepareNativeTasks->{task.GetType().Name}: " + ex); }
        }
    }

    void AddInputsInRsp()
    {
        Globals.RspArguments.Inputs.AddRange(Globals.SpoofedActualLibPaths);
    }

    void SetupVars()
    {
        Globals.Configuration = BuildEngine.GetEnvVar("Configuration") == "Debug" ? "Debug" : "Release";
        Globals.TargetBinDir = BuildEngine.GetEnvVar("TargetDir");
        Globals.AssemblyName = BuildEngine.GetEnvVar("AssemblyName");
        Globals.ProjectDir = BuildEngine.GetEnvVar("ProjectDir");

        Globals.TargetObjDir = Globals.TargetBinDir.Replace("\\bin", "\\obj"); // 🥶
        Globals.NaotDir = Path.Combine(Globals.ProjectDir, "naot");
        Globals.ObjNaotDir = Path.Combine(Globals.TargetObjDir, "naot");
        Globals.MirrorLibsDir = Path.Combine(Globals.ObjNaotDir, "mirror");
        Globals.OutLibsDir = Path.Combine(Globals.ObjNaotDir, "out");
        Globals.NaotConfigFile = Path.Combine(Globals.NaotDir, "config.json");
        Globals.NaotAnalyzersDir = Path.Combine(Globals.NaotDir, "analyzers");
        Globals.RspFile = Path.Combine(Globals.TargetObjDir, "native", $"{Globals.AssemblyName}.ilc.rsp");
        Globals.OutputNativeFile = Path.Combine(Globals.TargetBinDir, "native", $"{Globals.AssemblyName}.dll");

        Globals.RspArguments = RSPArguments.Parse(File.ReadAllLines(Globals.RspFile));
    }

    record TaskList(Type Type, List<TaskInstanceData> List);
    void LoadAnalyzers()
    {
        Globals.Analyzers = new();

        AppDomain.CurrentDomain.AssemblyResolve += (s, e) => {
            var name = e.Name.Split(", ")[0].Replace(".resources", "");
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Concat([typeof(ModuleDef).Assembly]).ToList();

            var assembly = loadedAssemblies.Find(a => a.FullName != null && a.FullName.Split(", ")[0] == name);
            if (assembly == null)
                Console.WriteLine("AppDomain.CurrentDomain.AssemblyResolve: Cannot find loaded assembly for " + e.Name);
            return assembly;
        };

        var tasks = new List<TaskList>()
        {
            new(typeof(ASMTask), Globals.ASMTaskInstances),
            new(typeof(ILTask), Globals.ILTaskInstances),
            new(typeof(ILMainTask), Globals.ILMainTaskInstances),
            new(typeof(ILActualTask), Globals.ILActualTaskInstances),
            new(typeof(InitTask), Globals.InitTaskInstances),
            new(typeof(PrepareNativeTask), Globals.PrepareNativeTaskInstances)
        };

        foreach (var analyzerFile in Directory.GetFiles(Globals.NaotAnalyzersDir))
        {
            var analyzerAssembly = Assembly.LoadFrom(analyzerFile);

            Globals.Analyzers.Add(analyzerAssembly);
            foreach (var type in analyzerAssembly.GetTypes())
            {
                var task = tasks.Find(t => type.BaseType != null && type.BaseType.FullName == t.Type.FullName);
                if (task != null)
                {
                    var ctors = type.GetConstructors();
                    if (ctors.Length == 0)
                        Console.WriteLine($"AfterWriteIlcRspFileForCompilation->LoadAnalyzers: Cannot get .ctor for task \"{type.Name}\"");

                    var ctor = ctors[0];
                    var body = ctor.GetMethodBody();

                    if (body == null)
                        Console.WriteLine($"AfterWriteIlcRspFileForCompilation->LoadAnalyzers: Due to some reason .ctor body for task \"{type.Name}\" is null");

                    var bodyInsts = body.GetILAsByteArray();

                    if (bodyInsts == null)
                        Console.WriteLine($"AfterWriteIlcRspFileForCompilation->LoadAnalyzers: Due to some reason .ctor body instructions for task \"{type.Name}\" is null");

                    var order = GetOrderFromILBytes(bodyInsts);
                    var instance = Activator.CreateInstance(type);
                    var taskInstance = new TaskInstanceData(instance, order);

                    Globals.AllTaskInstances.Add(taskInstance);
                    task.List.Add(taskInstance);

                    double GetOrderFromILBytes(byte[] il)
                    {
                        return BitConverter.ToDouble(il, il.Length - 14);
                    }
                }
            }
        }

        for (int t = 0; t < tasks.Count; t++)
            tasks[t] = new(tasks[t].Type, tasks[t].List.OrderBy(o => o.Order).ToList());
    }

    void SetupNaot()
    {
        if (!Directory.Exists(Globals.NaotDir))
        {
            Directory.CreateDirectory(Globals.NaotDir);

            File.Create(Globals.NaotConfigFile).Dispose();
            File.WriteAllText(Globals.NaotConfigFile, JsonConvert.SerializeObject(new Config()));

            Directory.CreateDirectory(Globals.NaotAnalyzersDir);
            File.CreateSymbolicLink(Path.Combine(Globals.NaotAnalyzersDir, "NAOT.Analyzer.dll"), Path.Combine(Globals.PackageNaotBuildDir, "NAOT.Analyzer.dll"));
        }
    }

    void LogAnalyzers()
    {
        Console.WriteLine($"  Uses {Globals.Analyzers.Count} analyzers"); // This prints from time to time, related to project, idk what wrong. 
    }

    void SpoofLibsPaths()
    {
        Globals.RspArguments.References.Clear();
        Globals.RspArguments.References.AddRange(Directory.GetFiles(Globals.OutLibsDir));
        Globals.RspArguments.References.AddRange(Globals.AdditionalCompilerLibPaths);
    }

    void SpoofMainLib()
    {
        var basePath = Path.Combine(Globals.TargetObjDir, Globals.AssemblyName + ".dll");
        var outPath = Directory
            .GetFiles(Globals.OutLibsDir)
            .ToList()
            .Find(f => Path.GetFileNameWithoutExtension(f) == Globals.AssemblyName);
        File.Delete(basePath);
        File.Move(outPath, basePath);
    }

    void SaveModules()
    {
        foreach ((var module, var name) in Globals.DnModulesNames)
            module.Write(Path.Combine(Globals.OutLibsDir, name + ".dll"));
    }

    void ExecuteILTasks()
    {
        var ilExecute = typeof(ILTask).GetMethods().First();
        var ilMainExecute = typeof(ILMainTask).GetMethods().First();
        var ilActualExecute = typeof(ILActualTask).GetMethods().First();
        var initExecute = typeof(InitTask).GetMethods().First();

        foreach (var instance in Globals.InitTaskInstances)
        {
            var task = instance.Task;
            try
            {
                initExecute.Invoke(task, null);
            }
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->Init->{task.GetType().Name}: " + ex); }
        }

        foreach (var instance in Globals.ILMainTaskInstances)
        {
            var task = instance.Task;
            try
            {
                ilMainExecute.Invoke(task, [Globals.DnMainModule]);
            } 
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->ILMain->{task.GetType().Name}: " + ex); }
        }

        foreach (var module in Globals.DnModules)
        {
            foreach (var instance in Globals.ILTaskInstances)
            {
                var task = instance.Task;
                try
                {
                    ilExecute.Invoke(task, [module]);
                }
                catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->IL->{task.GetType().Name}: " + ex); }
            }
        }

        foreach (var module in Globals.DnActualModules)
        {
            foreach (var instance in Globals.ILActualTaskInstances)
            {
                var task = instance.Task;
                try
                {
                    ilActualExecute.Invoke(task, [module]);
                }
                catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->ActualIL->{task.GetType().Name}: " + ex); }
            }
        }
    }

    void LoadLibs()
    {
        Globals.DnModules = new();
        Globals.DnActualModules = new();
        Globals.DnModulesNames = new();
        Globals.DnModulesPaths = new();

        var resolver = new PathAssemblyResolver(Globals.DnLibPaths);
        var ctx = new MetadataLoadContext(resolver, "mscorlib");
        Globals.DnContext = ModuleDef.CreateModuleContext();

        foreach (var lib in Globals.DnLibPaths)
        {
            var name = Path.GetFileNameWithoutExtension(lib);
            var assembly = ctx.LoadFromAssemblyPath(lib);

            var moduleCount = assembly.Modules.Count();
            if (moduleCount == 0)
            {
                Console.WriteLine($"Assembly {name} skipped because has no modules");
                continue;
            }
            else if (moduleCount > 1)
            {
                Console.WriteLine($"Assembly {name} skipped because has more than one module");
                continue;
            }

            var module = ModuleDefMD.Load(assembly.Modules.First(), Globals.DnContext);

            Globals.DnModules.Add(module);
            Globals.DnModulesNames.Add(module, name);
            Globals.DnModulesPaths.Add(module, lib);

            if (!lib.Contains("runtime.win-x64.microsoft.dotnet.ilcompiler"))
                Globals.DnActualModules.Add(module);

            if (lib == Globals.MainLibPath)
                Globals.DnMainModule = module;
            else
            {
                if (name == "NAOT")
                    Globals.DnNAOTModule = module;
                else if (name == "System.Runtime.InteropServices")
                    Globals.DnSystemRuntimeInteropServices = module;
                else if (name == "System.Private.CoreLib")
                    Globals.DnSystemPrivateCoreLib = module;
                else if (name == "mscorlib")
                    Globals.DnMscorelib = module;
            }
        }

        if (Globals.DnNAOTModule == null)
            Console.WriteLine($"Couldn't find module NAOT");
        if (Globals.DnSystemRuntimeInteropServices == null)
            Console.WriteLine($"Couldn't find module System.Runtime.InteropServices");
        if (Globals.DnSystemPrivateCoreLib == null)
            Console.WriteLine($"Couldn't find module System.Private.CoreLib");
        if (Globals.DnMscorelib == null)
            Console.WriteLine($"Couldn't find module mscorlib");
    }

    void SetupNaotLibDir()
    {
        foreach (var path in new string[] { Globals.MirrorLibsDir, Globals.OutLibsDir })
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
            Directory.CreateDirectory(path);
        }
    }

    void CopyLibsToMirror()
    {
        Globals.SpoofedLibPaths = new();
        Globals.SpoofedActualLibPaths = new();
        Globals.DnLibPaths = new();
        Globals.ActualLibPaths = new();
        Globals.AdditionalCompilerLibPaths = new();

        foreach (var lib in Globals.RspArguments.References)
        {
            if (lib.Contains("microsoft.netcore.app.runtime") && lib.Contains("WindowsBase.dll"))
            {
                Globals.AdditionalCompilerLibPaths.Add(lib);
                continue;
            }

            var name = Path.GetFileName(lib);
            string spoofedPath;
            if (Globals.SpoofedLibPaths.Find(l => Path.GetFileName(l) == name) != null)
                spoofedPath = Path.Combine(Globals.MirrorLibsDir, Path.GetFileNameWithoutExtension(lib) + $"-{(uint)Globals.Rnd.Next()}" + Path.GetExtension(lib));
            else spoofedPath = Path.Combine(Globals.MirrorLibsDir, Path.GetFileName(lib));
            File.Copy(lib, spoofedPath);
            Globals.SpoofedLibPaths.Add(spoofedPath);
            Globals.DnLibPaths.Add(spoofedPath);

            if (!lib.Contains("runtime.win-x64.microsoft.dotnet.ilcompiler"))
            {
                Globals.ActualLibPaths.Add(lib);
                Globals.SpoofedActualLibPaths.Add(spoofedPath);
            }
        }

        Globals.MainLibPath = Path.Combine(Globals.TargetObjDir, Globals.AssemblyName + ".dll");
        Globals.DnLibPaths.Add(Globals.MainLibPath);
    }
}