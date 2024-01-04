using NAOT.Analyzer.Utils;
using NAOT.Core.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public unsafe class RemoveDNRDHExportASMTask : ASMTask
{
    public override void Execute(string module)
    {
        using var pe = new PEEditor(module);

        pe.RemoveExportFunction("DotNetRuntimeDebugHeader"u8);

        pe.Save(module);
    }
}