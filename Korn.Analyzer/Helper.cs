namespace Korn.Analyzer;
public static class Helper
{
    public static CustomAttribute GetUnmanagedCallersOnlyAttribute(ModuleDefMD module, string? entryPoint, Type[] types)
    {
        var attribute = new CustomAttribute(module.Import(Env.UnmanagedCallersOnlyAttributeCtor));

        if (entryPoint is not null)
            attribute.NamedArguments.Add(new(true, module.CorLibTypes.String, "EntryPoint", new(module.CorLibTypes.String, entryPoint)));
        attribute.NamedArguments.Add(new(true, Env.TypeArrayType, "CallConvs", new(Env.TypeArrayType, types.Select(t => new CAArgument(Env.TypeType, module.ImportAsTypeSig(t))).ToList())));

        return attribute;
    }

    public static CustomAttribute GetUnmanagedCallersOnlyAttribute(ModuleDefMD module, string? entryPoint, Type type) => GetUnmanagedCallersOnlyAttribute(module, entryPoint, [type]);

    public static CustomAttribute GetStructLayoutAttribute(ModuleDefMD module, LayoutKind type)
    {
        var attribute = new CustomAttribute(module.Import(Env.StructLayoutAttributeCtor));

        attribute.ConstructorArguments.Add(new(Env.LayoutKindType, type));

        return attribute;
    }
}