class InitializeTask() : InitTask(-10)
{
    public override void Execute()
    {
        Env.UnmanagedCallersOnlyAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute");
        Env.UnmanagedCallersOnlyAttributeCtor = Env.UnmanagedCallersOnlyAttribute.FindConstructors().First();

        Env.TypeType = SystemPrivateCoreLib.FindType("System.Type").ToTypeSig();
        Env.TypeArrayType = new SZArraySig(Env.TypeType);

        Env.ByteArray = new SZArraySig(Main.CorLibTypes.Byte);

        Env.NativeFuncAttribute = This.FindType("NativeFuncAttribute");
        Env.NativeFuncAttribute_1 = This.FindType("NativeFuncAttribute`1");
        Env.EntryPointAttribute = This.FindType("EntryPointAttribute");
        Env.DllImportAttribute = SystemPrivateCoreLib.FindType("System.Runtime.InteropServices.DllImportAttribute");
        Env.DefinesType = This.FindType("korn");
        Env.Kernel32InteropType = This.FindType("kernel32");
        Env.User32InteropType = This.FindType("user32");

        Env.NativeMethodAttributes = [Env.NativeFuncAttribute, Env.NativeFuncAttribute_1, Env.EntryPointAttribute, Env.DllImportAttribute];

        Env.RuntimeHelpersType = SystemPrivateCoreLib.FindType("System.Runtime.CompilerServices.RuntimeHelpers");
        Env.InitializeArrayMethod = Env.RuntimeHelpersType.Methods.First(m => m.Name == "InitializeArray");
        Env.EnumerableType = SystemLinq.FindType("System.Linq.Enumerable");
        Env.EnumerableToArrayMethod = Env.EnumerableType.Methods.First(m => m.Name == "ToArray");
    }
}