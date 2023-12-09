using dnlib.DotNet;
using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using Newtonsoft.Json;  
using System.Reflection;

public class AfterBeforeBuild : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {
            Globals.Configuration = BuildEngine.GetEnvVar("Configuration") == "Debug" ? "Debug" : "Release";
            Globals.RuntimeIdentifier = BuildEngine.GetEnvVar("RuntimeIdentifier");
            Globals.TargetBinDir = BuildEngine.GetEnvVar("TargetDir");
            Globals.AssemblyName = BuildEngine.GetEnvVar("AssemblyName");
            Globals.ProjectDir = BuildEngine.GetEnvVar("ProjectDir");

            Globals.TargetObjDir = Globals.TargetBinDir.Replace("\\bin\\", "\\obj\\"); // 🥶
            Globals.NaotDir = Path.Combine(Globals.ProjectDir, "naot");
            Globals.ObjNaotDir = Path.Combine(Globals.TargetObjDir, "naot");
            Globals.MirrorLibsDir = Path.Combine(Globals.ObjNaotDir, "mirror");
            Globals.OutLibsDir = Path.Combine(Globals.ObjNaotDir, "out");
            Globals.NaotConfigFile = Path.Combine(Globals.NaotDir, "config.json");
            Globals.NaotAnalyzersDir = Path.Combine(Globals.NaotDir, "analyzers");
            Globals.RspFile = Path.Combine(Globals.TargetObjDir, "native", $"{Globals.AssemblyName}.ilc.rsp");
            Globals.OutputNativeFile = Path.Combine(Globals.TargetBinDir, "native", $"{Globals.AssemblyName}.dll");

            SetupNaot();
            LoadAnalyzers();
            ClearObj();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterBeforeBuild: " + ex); }

        return true;
    }

    void ClearObj()
    {
        Directory.Delete(Globals.TargetObjDir, true);
    }

    record TaskList(Type Type, List<object> List);
    void LoadAnalyzers()
    {
        Globals.Analyzers = new();

        AppDomain.CurrentDomain.AssemblyResolve += (s, e) => {
            var name = e.Name.Split(", ")[0].Replace(".resources", "") ;
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
            new(typeof(InitTask), Globals.InitTaskInstances)
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
                    var instance = Activator.CreateInstance(type);

                    Globals.AllTaskInstances.Add(instance);
                    task.List.Add(instance);
                }
            }
        }
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
}