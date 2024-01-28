namespace Korn.Analyzer;
public static class Helper
{
    public static CustomAttribute GetUnmanagedCallersOnlyAttribute(ModuleDefMD module, string? entryPoint, Type[] types)
    {
        var attbr = new CustomAttribute(module.Import(AGlobals.UnmanagedCallersOnlyAttributeCtor));

        if (entryPoint != null)
            attbr.NamedArguments.Add(new(true, module.CorLibTypes.String, "EntryPoint", new(module.CorLibTypes.String, entryPoint)));
        attbr.NamedArguments.Add(new(true, AGlobals.TypeArrayType, "CallConvs", new(AGlobals.TypeArrayType, types.Select(t => new CAArgument(AGlobals.TypeType, module.ImportAsTypeSig(t))).ToList())));

        return attbr;
    }

    public static CustomAttribute GetUnmanagedCallersOnlyAttribute(ModuleDefMD module, string? entryPoint, Type type) => GetUnmanagedCallersOnlyAttribute(module, entryPoint, [type]);
}