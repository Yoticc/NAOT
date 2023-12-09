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
        AGlobals.UnmanagedCallersOnlyAttribute = Globals.DnSystemPrivateCoreLib.FindType("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");
        if (AGlobals.UnmanagedCallersOnlyAttribute == null)
            Console.WriteLine($"Unable find type System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute in System.Private.CoreLib");

        AGlobals.UnmanagedCallersOnlyAttributeCtor = AGlobals.UnmanagedCallersOnlyAttribute.FindConstructors().First();
        if (AGlobals.UnmanagedCallersOnlyAttributeCtor == null)
            Console.WriteLine($"Unable get constructor from System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");

        AGlobals.TypeType = Globals.DnSystemPrivateCoreLib.FindType("System.Type").ToTypeSig();
        AGlobals.TypeArrayType = new SZArraySig(AGlobals.TypeType);

        AGlobals.NativeFuncAttribute = Globals.DnNAOTModule.FindType("NativeFuncAttribute");
        AGlobals.NativeFuncAttribute_1 = Globals.DnNAOTModule.FindType("NativeFuncAttribute`1");
        AGlobals.EntryPointAttribute = Globals.DnNAOTModule.FindType("NAOT.EntryPointAttribute");
    }
}