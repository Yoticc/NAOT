using dnlib.DotNet;

namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    public static TypeDef? FindType(this ModuleDefMD module, string name, bool JUST_TRY) =>
        module
        .GetTypes()
        .ToList()
        .Find(t => t.FullName == name);

    public static TypeDef FindType(this ModuleDefMD module, string name)
    {
        var type = module.FindType(name, true);

        if (type is null)
            Console.WriteLine($"SugarExtensions->FindType: Unable to find type {name}");

        return type!;
    }

    public static bool IsEmpty(this TypeDef type) =>
        !type.HasFields &&
        !type.HasProperties &&
        !type.HasMethods &&
        !type.HasNestedTypes;

    public static void RemoveTypeFromModule(this TypeDef type)
    {
        if (type.IsNested)
            type.DeclaringType.NestedTypes.Remove(type);
        else type.Module.Types.Remove(type);
    }
}