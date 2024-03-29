using Korn.Analyzer;
using Korn.Core;
using Korn.Core.Tasks;
using Korn.Core.Utils;
using System.Diagnostics;
using static Korn.Core.Globals.Dn;
using static Korn.Core.Globals.Dn.DnModules;

class InitializeTask() : InitTask(-10)
{
    public override void Execute()
    {
        KornLogger.WriteLine("Started Korn.Analyzer");
        AGlobals.UnmanagedCallersOnlyAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");
        AGlobals.UnmanagedCallersOnlyAttributeCtor = AGlobals.UnmanagedCallersOnlyAttribute.FindConstructors().First();

        AGlobals.TypeType = SystemPrivateCoreLib.FindType("System.Type").ToTypeSig();
        AGlobals.TypeArrayType = new SZArraySig(AGlobals.TypeType);

        AGlobals.ByteArray = new SZArraySig(Main.CorLibTypes.Byte);

        AGlobals.NativeFuncAttribute = This.FindType("NativeFuncAttribute");
        AGlobals.NativeFuncAttribute_1 = This.FindType("NativeFuncAttribute`1");
        AGlobals.EntryPointAttribute = This.FindType("EntryPointAttribute");
        AGlobals.DllImportAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.DllImportAttribute");
        AGlobals.DefinesType = This.FindType("korn");
        AGlobals.Kernel32InteropType = This.FindType("kernel32");
        AGlobals.User32InteropType = This.FindType("user32");

        AGlobals.NativeMethodAttributes = [AGlobals.NativeFuncAttribute, AGlobals.NativeFuncAttribute_1, AGlobals.EntryPointAttribute, AGlobals.DllImportAttribute];

        AGlobals.RuntimeHelpersType = SystemPrivateCoreLib.FindType("System.Runtime.CompilerServices.RuntimeHelpers");
        AGlobals.InitializeArrayMethod = AGlobals.RuntimeHelpersType.Methods.First(m => m.Name == "InitializeArray");
        AGlobals.EnumerableType = SystemLinq.FindType("System.Linq.Enumerable");
        AGlobals.EnumerableToArrayMethod = AGlobals.EnumerableType.Methods.First(m => m.Name == "ToArray");
    }
}