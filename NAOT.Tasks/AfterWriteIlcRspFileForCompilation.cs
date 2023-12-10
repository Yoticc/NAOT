using dnlib.DotNet;
using NAOT.Core;
using NAOT.Core.Tasks;
using System.Reflection;

public class AfterWriteIlcRspFileForCompilation : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {


            SetupGlobals();
            SetupNaotLibDir();
            CopyLibsToMirror();
            LoadLibs();
            ExecuteILTasks();
            SaveModules();
            SpoofMainLib();
            SpoofLibsPaths();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation: " + ex); }

        return true;
    }

    void SpoofLibsPaths()
    {
        var startLine = -1;
        var lines = File.ReadAllLines(Globals.RspFile).ToList();
        for (int i = 0; i < lines.Count;)
            if (lines[i].StartsWith("-r:"))
            {
                if (startLine == -1)
                    startLine = i;

                lines.RemoveAt(i);
            }
            else i++;
        
        foreach (var lib in Directory.GetFiles(Globals.OutLibsDir))
            lines.Insert(startLine, lib);

        File.WriteAllLines(Globals.RspFile, lines);
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

        foreach (var task in Globals.InitTaskInstances)
        {
            try
            {
                initExecute.Invoke(task, null);
            }
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->Init->{task.GetType().Name}: " + ex); }
        }

        foreach (var task in Globals.ILMainTaskInstances)
        {
            try
            {
                ilMainExecute.Invoke(task, [Globals.DnMainModule]);
            } 
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->ILMain->{task.GetType().Name}: " + ex); }
        }

        foreach (var module in Globals.DnModules)
        {
            foreach (var task in Globals.ILTaskInstances)
            {
                try
                {
                    ilExecute.Invoke(task, [module]);
                }
                catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->IL->{task.GetType().Name}: " + ex); }
            }

            var path = Globals.DnModulesPaths[module];
            if (!path.Contains("runtime.win-x64.microsoft.dotnet.ilcompiler"))
            {
                foreach (var task in Globals.ILActualTaskInstances)
                {
                    try
                    {
                        ilActualExecute.Invoke(task, [module]);
                    }
                    catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->ILActual->{task.GetType().Name}: " + ex); }
                }
            }
        }
    }

    void LoadLibs()
    {
        Globals.DnModules = new();
        Globals.DnModulesNames = new();
        Globals.DnModulesPaths = new();

        var resolver = new PathAssemblyResolver(Globals.AllLibPaths);
        var ctx = new MetadataLoadContext(resolver, "mscorlib");
        Globals.DnContext = ModuleDef.CreateModuleContext();

        foreach (var lib in Globals.AllLibPaths)
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

        foreach (var lib in Globals.OriginalLibPaths)
        {
            if (lib.Contains("microsoft.netcore.app.runtime.win-x64") && lib.Contains("WindowsBase.dll"))
                continue;

            var name = Path.GetFileName(lib);
            string spoofedPath;
            if (Globals.SpoofedLibPaths.Find(l => Path.GetFileName(l) == name) != null)
                spoofedPath = Path.Combine(Globals.MirrorLibsDir, Path.GetFileNameWithoutExtension(lib) + $"-{(uint)Globals.Rnd.Next()}" + Path.GetExtension(lib));
            else spoofedPath = Path.Combine(Globals.MirrorLibsDir, Path.GetFileName(lib));
            File.Copy(lib, spoofedPath);
            Globals.SpoofedLibPaths.Add(spoofedPath);
        }

        Globals.AllLibPaths = Globals.SpoofedLibPaths;
        Globals.MainLibPath = Path.Combine(Globals.TargetObjDir, Globals.AssemblyName + ".dll");
        Globals.AllLibPaths.Add(Globals.MainLibPath);
    }

    void SetupGlobals()
    {
        var args = File.ReadAllLines(Globals.RspFile);

        var libs = Globals.OriginalLibPaths = new();

        foreach (var arg in args)
            if (arg.StartsWith("-r:"))
                libs.Add(arg.Substring(3));
    }
}