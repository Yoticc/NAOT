using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Korn.Core.Tasks;

namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    public static TypeDef? FindType(this ModuleDefMD module, string name, bool unused) =>
        module
        .GetTypes()
        .ToList()
        .Find(type => type.FullName == name);

    public static TypeDef FindType(this ModuleDefMD module, string name)
    {
        var type = module.FindType(name, true);

        if (type is null)
            KornLogger.WriteLine($"SugarExtensions->FindType: Unable to find type {name}");

        return type!;
    }

    public static string GetNonGenericParamsFullName(this IType type) => type.FullName.Split('<')[0];
    public static string GetNonGenericFullName(this IType type) => type.FullName.Split('`')[0];

    static readonly SigComparer sigComparer = new();
    public static bool IsSame(this IType type1, IType type2) => sigComparer.Equals(type1, type2);

    public static bool IsSameByName(this IType type1, IType type2) => type1.GetNonGenericParamsFullName() == type2.GetNonGenericParamsFullName();

    public static bool ContainsAttribute(this IMethodDefOrRef method, params ITypeDefOrRef[] attributes)
    {
        var attributesList = attributes.ToList();
        return
            method
            .CustomAttributes
            .ToList()
            .Find(attribute => attributesList.Find(a => a.IsSameByName(attribute.AttributeType)) is not null) is not null;
    }

    public static List<MethodDef> GetMethods(this ModuleDefMD module) =>
        module
        .GetTypes()
        .SelectMany(type => type.Methods)
        .ToList();

    public static MethodDef? GetMethod(this ModuleDefMD module, string fullPath)
    {
        var methods = module.GetMethods();
        var splitted = fullPath.Split('.');
        if (splitted.Length == 2)
        {
            return methods.Find(m => $"{m.DeclaringType.Name}.{m.Name}" == fullPath);
        }
        else
        {
            var @namespace = string.Join('.', splitted.SkipLast(2));
            var name = string.Join('.', splitted.TakeLast(2));
            return methods.Find(method => method.DeclaringType.Namespace == @namespace && $"{method.DeclaringType.Name}.{method.Name}" == name);
        }
    }

    public static List<MethodDef> GetMethodsByAttribute(this ModuleDefMD module, params ITypeDefOrRef[] attributes)
    {
        var attributesList = attributes.ToList();
        return
            module
            .GetMethods()
            .Where(m => m.HasCustomAttributes &&
                m.CustomAttributes
                .ToList()
                .Find(a => attributesList.Find(al => al.IsSameByName(a.AttributeType)) is not null) is not null
            ).ToList();
    }

    public static bool ExIsArray(this TypeSig sig) => sig.GetType().Name.EndsWith("ArraySig");

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