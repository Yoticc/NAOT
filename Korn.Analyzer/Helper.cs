namespace Korn.Analyzer;
public static class Helper
{
    public static CustomAttribute GetUnmanagedCallersOnlyAttribute(ModuleDefMD module, string? entryPoint, Type[] types)
    {
        var attribute = new CustomAttribute(module.Import(AGlobals.UnmanagedCallersOnlyAttributeCtor));

        if (entryPoint is not null)
            attribute.NamedArguments.Add(new(true, module.CorLibTypes.String, "EntryPoint", new(module.CorLibTypes.String, entryPoint)));
        attribute.NamedArguments.Add(new(true, AGlobals.TypeArrayType, "CallConvs", new(AGlobals.TypeArrayType, types.Select(t => new CAArgument(AGlobals.TypeType, module.ImportAsTypeSig(t))).ToList())));

        return attribute;
    }

    public static CustomAttribute GetUnmanagedCallersOnlyAttribute(ModuleDefMD module, string? entryPoint, Type type) => GetUnmanagedCallersOnlyAttribute(module, entryPoint, [type]);
}