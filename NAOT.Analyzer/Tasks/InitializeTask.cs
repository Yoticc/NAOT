using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public class InitializeTask : InitTask
{
    public override void Execute()
    {
        AGlobals.UnmanagedCallersOnlyAttribute = Globals.DnSystemPrivateCorLib.FindType("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");
        AGlobals.UnmanagedCallersOnlyAttributeCtor = AGlobals.UnmanagedCallersOnlyAttribute.FindConstructors().First();

        AGlobals.TypeType = Globals.DnMscorelib.FindType("System.Type").ToTypeSig();
        AGlobals.TypeArrayType = new SZArraySig(AGlobals.TypeType);
    }
}