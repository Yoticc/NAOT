unsafe class CopyNativeOutTask() : ASMTask(-8)
{
    public override void Execute(string module)
    {
        var inputFile = CoreEnv.Paths.GetOutputNativeTargetFile();

        var config = CoreEnv.Config.CustomNativeOut;
        if (!config.Use)
            return;

        var outDir = Path.GetFullPath(Environment.ExpandEnvironmentVariables(Path.Combine(CoreEnv.Vars.ProjectDir, config.DirectoryPath)))!;
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        var outNameConfig = config.FileName;
        var outName = config.FileName.UseCustomName ? config.FileName.CustomName : Path.GetFileNameWithoutExtension(module);
        var outFilePath = Path.Combine(outDir, outName) + Path.GetExtension(inputFile);
        if (File.Exists(outFilePath))
            File.Delete(outFilePath);
        File.Copy(inputFile, outFilePath);

        if (config.ExportPdbFile)
        {
            var moduleDir = Path.GetDirectoryName(inputFile)!;
            var modulePdbFile = Directory.GetFiles(moduleDir, "*.pdb").FirstOrDefault();
            if (modulePdbFile is not null)
            {
                var outPdbPath = Path.Combine(outDir, outName) + ".pdb";

                if (File.Exists(outPdbPath))
                    File.Delete(outPdbPath);
                File.Copy(modulePdbFile, outPdbPath);
            }
        }

        KornLogger.WriteMessage("Finished Korn.Analyzer");
    }
}