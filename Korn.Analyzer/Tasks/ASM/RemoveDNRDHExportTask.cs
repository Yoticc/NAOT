using Korn.Analyzer.Utils;
using Korn.Core.Tasks;

namespace Korn.Analyzer.Tasks.ASM;
public class RemoveDNRDHExportTask() : ASMTask(-10)
{
    public override void Execute(string module)
    {
        using var pe = new PEEditor(module);

        pe.RemoveExportFunction("DotNetRuntimeDebugHeader"u8);

        pe.Save(module);
    }
}