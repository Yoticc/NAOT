using Korn.Core.Tasks;
using Korn.Core.Utils;
using static Korn.Core.Globals.Dn;
using static Korn.Core.Globals.Dn.DnModules;

namespace Korn.Analyzer.Tasks;
public class InitializeTask : InitTask
{
    public override void Execute()
    {
        AGlobals.UnmanagedCallersOnlyAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");
        AGlobals.UnmanagedCallersOnlyAttributeCtor = AGlobals.UnmanagedCallersOnlyAttribute.FindConstructors().First();

        AGlobals.TypeType = SystemPrivateCoreLib.FindType("System.Type").ToTypeSig();
        AGlobals.TypeArrayType = new SZArraySig(AGlobals.TypeType);

        AGlobals.ByteArray = new SZArraySig(Main.CorLibTypes.Byte);

        AGlobals.NativeFuncAttribute = DnModules.This.FindType("NativeFuncAttribute");
        AGlobals.NativeFuncAttribute_1 = DnModules.This.FindType("NativeFuncAttribute`1");
        AGlobals.EntryPointAttribute = DnModules.This.FindType("EntryPointAttribute");
        AGlobals.DllImportAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.DllImportAttribute");
        AGlobals.DefinesType = DnModules.This.FindType("korn");
        AGlobals.Kernel32InteropType = DnModules.This.FindType("kernel32");
        AGlobals.User32InteropType = DnModules.This.FindType("user32");

        AGlobals.NativeMethodAttributes = [AGlobals.NativeFuncAttribute, AGlobals.NativeFuncAttribute_1, AGlobals.EntryPointAttribute, AGlobals.DllImportAttribute];

        AGlobals.RuntimeHelpersType = SystemPrivateCoreLib.FindType("System.Runtime.CompilerServices.RuntimeHelpers");
        AGlobals.InitializeArrayMethod = AGlobals.RuntimeHelpersType.Methods.First(m => m.Name == "InitializeArray");
        AGlobals.EnumerableType = SystemLinq.FindType("System.Linq.Enumerable");
        AGlobals.EnumerableToArrayMethod = AGlobals.EnumerableType.Methods.First(m => m.Name == "ToArray");
    }
}