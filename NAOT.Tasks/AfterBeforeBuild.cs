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
            ClearObj();
            TryAddExceptionsInGitIgnoreFile();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterBeforeBuild: " + ex); }

        return true;
    }

    void ClearObj()
    {
        var objPath = BuildEngine.GetEnvVar("TargetDir").Replace("\\bin", "\\obj");
        if (Directory.Exists(objPath))
            Directory.Delete(objPath, true);
    }

    void TryAddExceptionsInGitIgnoreFile()
    {
        string[] ignoreLines = [@"**/naot/analyzers"];

        var projectPath = BuildEngine.GetEnvVar("ProjectDir");
        var gitIgnorePath = Path.Combine(string.Join('\\', projectPath.Split('\\')[0..^2]), ".gitignore");
        if (!File.Exists(gitIgnorePath))
            if (!File.Exists(gitIgnorePath = Path.Combine(projectPath, ".gitignore")))
                return; // Unable find gitignore file in supposted solution folder or project folder.

        var lines = File.ReadAllLines(gitIgnorePath);
        foreach (var ignoreLine in ignoreLines)
            if (!lines.Contains(ignoreLine))
                File.AppendAllText(gitIgnorePath, '\n' + ignoreLine);
    }
}                                                           
