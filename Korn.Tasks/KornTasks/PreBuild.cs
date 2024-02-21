public class PreBuild : KornTask
{
    public override void Execute()
    {
        ClearObj();
        TryAddExceptionsInGitIgnoreFile();
    }

    void ClearObj()
    {
        var objPath = this["TargetDir"].Replace("\\bin", "\\obj");
        if (Directory.Exists(objPath))
            Directory.Delete(objPath, true);
    }

    void TryAddExceptionsInGitIgnoreFile()
    {
        string[] ignoreLines = [@"**/korn/analyzers"];

        var gitIgnorePath = Path.Combine(string.Join('\\', this["ProjectDir"].Split('\\')[0..^2]), ".gitignore");
        if (!File.Exists(gitIgnorePath))
            if (!File.Exists(gitIgnorePath = Path.Combine(this["ProjectDir"], ".gitignore")))
                return; // Unable find gitignore file in supposted solution folder or project folder.

        var lines = File.ReadAllLines(gitIgnorePath);
        foreach (var ignoreLine in ignoreLines)
            if (!lines.Contains(ignoreLine))
                File.AppendAllText(gitIgnorePath, '\n' + ignoreLine);
    }
}