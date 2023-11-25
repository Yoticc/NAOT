using dnlib.DotNet;
using NAOT.Core;
using NAOT.Core.Tasks;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class AfterWriteIlcRspFileForCompilation : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {
            SetupGlobals();
            SetupMirror();
            CopyLibsToMirror();
            SpoofLibsPaths();
            LoadLibs();
            ExecuteILTasks();

        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation: " + ex); }

        return true;
    }

    void ExecuteILTasks()
    {
        var ilExecute = typeof(ILTask).GetMethods().First();
        var ilMainExecute = typeof(ILMainTask).GetMethods().First();
        var initExecute = typeof(ILMainTask).GetMethods().First();

        foreach (var task in Globals.InitTaskInstances)
        {
            try
            {
                initExecute.Invoke(task, null);
            }
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->{task.GetType().Name}: " + ex); }
        }

        foreach (var task in Globals.ILMainTaskInstances)
        {
            try
            {
                ilMainExecute.Invoke(task, [Globals.DnMainModule]);
            } 
            catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->{task.GetType().Name}: " + ex); }
        }

        foreach (var module in Globals.DnModules)
            foreach (var task in Globals.ILTaskInstances)
            {
                try
                {
                    ilExecute.Invoke(task, [module]);
                }
                catch (Exception ex) { Console.WriteLine($"Exception in AfterWriteIlcRspFileForCompilation->{task.GetType().Name}: " + ex); }
            }
    }

    void LoadLibs()
    {
        Globals.DnModules = new();

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

            if (lib == Globals.MainLibPath)
                Globals.DnMainModule = module;
            else
            {
                if (name == "System.Runtime.InteropServices")
                    Globals.DnSystemRuntimeInteropServices = module;
                else if (name == "System.Private.CorLib")
                    Globals.DnSystemPrivateCorLib = module;
                else if (name == "mscorlib")
                    Globals.DnMscorelib = module;
            }
        }

        if (Globals.DnSystemRuntimeInteropServices == null)
            Console.WriteLine($"Couldn't find module System.Runtime.InteropServices");
        if (Globals.DnSystemPrivateCorLib == null)
            Console.WriteLine($"Couldn't find module System.Private.CorLib");
        if (Globals.DnMscorelib == null)
            Console.WriteLine($"Couldn't find module mscorlib");
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

        foreach (var lib in Directory.GetFiles(Globals.MirrorLibsDir))
            lines.Insert(startLine, lib);
    }

    void SetupMirror()
    {
        var mirror = Globals.MirrorLibsDir;

        if (Directory.Exists(mirror))
            Directory.Delete(mirror, true);
        Directory.CreateDirectory(mirror);
    }

    void CopyLibsToMirror()
    {
        Globals.SpoofedLibPaths = new();

        foreach (var lib in Globals.OriginalLibPaths)
        {
            string spoofedPath;
            if (Globals.SpoofedLibPaths.Find(l => Path.GetFileName(l) == Path.GetFileName(lib)) != null)
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