using Korn.Core;
using Korn.Core.Tasks;

namespace Korn.Analyzer.Tasks;
public unsafe class CopyNativeOutASMTask() : ASMTask(-8)
{
    public override void Execute(string module)
    {
        var config = Globals.Config.CustomNativeOut;
        if (!config.Use)
            return;

        var outPath = Path.GetFullPath(Environment.ExpandEnvironmentVariables(Path.Combine(Globals.Vars.ProjectDir, config.Path)))!;
        var outDir = Path.GetDirectoryName(outPath)!;
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        if (File.Exists(outPath))
            File.Delete(outPath);
        File.Copy(module, outPath);

        if (config.ExportPdbFile)
        {
            var moduleDir = Path.GetDirectoryName(module)!;
            var modulePdbFile = Directory.GetFiles(moduleDir, "*.pdb").FirstOrDefault();
            if (modulePdbFile is not null)
            {
                var outPdbPath = Path.Combine(outDir, Path.GetFileNameWithoutExtension(config.AutoRenamePdbFileToDllName ? outPath : module) + ".pdb");

                if (File.Exists(outPdbPath))
                    File.Delete(outPdbPath);
                File.Copy(modulePdbFile, outPdbPath);
            }
        }
    }
}