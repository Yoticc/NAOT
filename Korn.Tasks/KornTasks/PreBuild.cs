using Korn.Core;

public class PreBuild : KornTask
{
    public override void Execute()
    {
        SetupPowershell();
        ClearObj();
        TryAddExceptionsInGitIgnoreFile();
    }

    void SetupPowershell()
    {
        const string KORN_FUNCTIONS_START_SIGN = "# START OF KORN GLOBAL FUNCTIONS";
        const string KORN_FUNCTIONS_END_SIGN = "# END OF KORN GLOBAL FUNCTIONS";
        const string LINE_SPLITTER = "\n";

        var profilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WindowsPowerShell", "Microsoft.PowerShell_profile.ps1");
        if (!File.Exists(profilePath))
            File.Create(profilePath).Dispose();

        var profileFileText = File.ReadAllText(profilePath);

        var cmdletsPath = Path.Combine(Globals.Paths.PackageToolsDir, "Cmdlets.psm1");
        var cmdletsFileText = File.ReadAllText(cmdletsPath).Replace("CURRENT_PACKAGE_VERSION", Globals.Vars.PackageVersion);
        
        if (profileFileText.Contains(KORN_FUNCTIONS_START_SIGN) && profileFileText.Contains(KORN_FUNCTIONS_END_SIGN))
        {
            var startSigIndex = profileFileText.IndexOf(KORN_FUNCTIONS_START_SIGN);
            var endSigIndex = profileFileText.IndexOf(KORN_FUNCTIONS_END_SIGN);
            var startContentIndex = startSigIndex + KORN_FUNCTIONS_START_SIGN.Length + LINE_SPLITTER.Length;
            var endContentIndex = endSigIndex - LINE_SPLITTER.Length;

            var content = profileFileText.Substring(startContentIndex, endContentIndex - startContentIndex);

            if (content != cmdletsFileText)
                File.WriteAllText(
                    profileFileText,
                    string.Join(LINE_SPLITTER,
                        GetStartTextOfProfile(profileFileText.Substring(0, startSigIndex)),
                        cmdletsFileText,
                        KORN_FUNCTIONS_END_SIGN,
                        profileFileText.Substring(endSigIndex + KORN_FUNCTIONS_START_SIGN.Length + LINE_SPLITTER.Length)
                    )
                );
        }
        else 
            File.WriteAllText(
               profilePath,
               string.Join(LINE_SPLITTER,
                   GetStartTextOfProfile(profileFileText),
                   cmdletsFileText,
                   KORN_FUNCTIONS_END_SIGN
               )
            );

        string GetStartTextOfProfile(string startProfileText) =>
            (string.IsNullOrWhiteSpace(startProfileText) || startProfileText.Replace("\n", "").Replace("\r", "").Length == 0)
            ? string.Join(LINE_SPLITTER, startProfileText, KORN_FUNCTIONS_START_SIGN)
            : KORN_FUNCTIONS_START_SIGN;
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