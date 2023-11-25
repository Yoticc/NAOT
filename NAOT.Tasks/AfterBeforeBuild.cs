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
            Globals.MirrorLibsDir = Path.Combine(Globals.TargetObjDir, "naot");
            Globals.NaotConfigFile = Path.Combine(Globals.NaotDir, "config.json");
            Globals.NaotAnalyzersDir = Path.Combine(Globals.NaotDir, "analyzers");
            Globals.RspFile = Path.Combine(Globals.TargetObjDir, "native", $"{Globals.AssemblyName}.ilc.rsp");

            SetupNaot();
            LoadAnalyzers();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterBeforeBuild: " + ex); }

        return true;
    }

    void LoadAnalyzers()
    {
        Globals.Analyzers = new();
        Globals.AllTaskInstances = new();

        foreach (var analyzerFile in Directory.GetFiles(Globals.NaotAnalyzersDir))
        {
            var analyzerAssembly = Assembly.LoadFrom(analyzerFile);

            Globals.Analyzers.Add(analyzerAssembly);

            foreach (var type in analyzerAssembly.GetTypes())
            {
                if (type == typeof(ASMTask) || type == typeof(ILTask) || type == typeof(ILMainTask))
                {
                    var ctors = type.GetConstructors();
                    if (ctors.Length == 0)
                    {
                        Console.WriteLine($"AfterBeforeBuild -> {type.Name}: missed constructor");
                        continue;
                    }

                    var ctor = ctors[0];
                    var instance = ctor.Invoke(null);

                    Globals.AllTaskInstances.Add(instance);

                    if (type == typeof(ASMTask))
                        Globals.ASMTaskInstances.Add(instance);
                    else if (type == typeof(ILTask))
                        Globals.ILTaskInstances.Add(instance);
                    else if (type == typeof(ILMainTask))
                        Globals.ILMainTaskInstances.Add(instance);
                    else if (type == typeof(InitTask))
                        Globals.InitTaskInstances.Add(instance);
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
            File.CreateSymbolicLink(Path.Combine(Globals.NaotAnalyzersDir, "NAOT.Analyzer.dll"), Path.Combine(Globals.PackageNaotDir, "build", "NAOT.Analyzer.dll"));
        }
    }
}