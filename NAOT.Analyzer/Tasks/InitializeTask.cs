using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static NAOT.Core.Globals.Dn;
using static NAOT.Core.Globals.Dn.DnModules;

namespace NAOT.Analyzer.Tasks;
public class InitializeTask : InitTask
{
    public override void Execute()
    {
        AGlobals.UnmanagedCallersOnlyAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");
        if (AGlobals.UnmanagedCallersOnlyAttribute == null)
            Console.WriteLine($"Unable find type System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute in System.Private.CoreLib");

        AGlobals.UnmanagedCallersOnlyAttributeCtor = AGlobals.UnmanagedCallersOnlyAttribute.FindConstructors().First();
        if (AGlobals.UnmanagedCallersOnlyAttributeCtor == null)
            Console.WriteLine($"Unable get constructor from System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");

        AGlobals.TypeType = SystemPrivateCoreLib.FindType("System.Type").ToTypeSig();
        AGlobals.TypeArrayType = new SZArraySig(AGlobals.TypeType);

        AGlobals.ValueTypeType = SystemPrivateCoreLib.FindType("ValueType");
        AGlobals.ByteArray = new SZArraySig(Main.CorLibTypes.Byte);

        AGlobals.NativeFuncAttribute = DnModules.NAOT.FindType("NativeFuncAttribute");
        AGlobals.NativeFuncAttribute_1 = DnModules.NAOT.FindType("NativeFuncAttribute`1");
        AGlobals.EntryPointAttribute = DnModules.NAOT.FindType("NAOT.EntryPointAttribute");
        AGlobals.DllImportAttribute = SystemRuntimeInteropServices.FindType("System.Runtime.InteropServices.DllImportAttribute");
        AGlobals.NAOTDefinesType = DnModules.NAOT.FindType("NaotDefines");
        AGlobals.NAOTKernel32InteropType = DnModules.NAOT.FindType("kernel32");
        AGlobals.NAOTUser32InteropType = DnModules.NAOT.FindType("user32");

        AGlobals.NativeMethodAttributes = [AGlobals.NativeFuncAttribute, AGlobals.NativeFuncAttribute_1, AGlobals.EntryPointAttribute, AGlobals.DllImportAttribute];
    }
}