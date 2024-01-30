using dnlib.DotNet.Emit;

namespace Korn.Analyzer.Utils.Sugar;
public static class DnExtensions
{
    public static bool IsCanBeNative(this MethodDef meth) => !meth.HasGenericParameters && meth.IsStatic;

    public static string GetNonGenericParamsFullName(this IType type) => type.FullName.Split('<')[0];
    public static string GetNonGenericFullName(this IType type) => type.FullName.Split('`')[0];

    static SigComparer sigComparer = new();
    public static bool IsSame(this IType type1, IType type2) => sigComparer.Equals(type1, type2);

    public static bool IsSameByName(this IType type1, IType type2) => type1.GetNonGenericParamsFullName() == type2.GetNonGenericParamsFullName();

    public static bool ContainsAttribute(this IMethodDefOrRef method, params ITypeDefOrRef[] attributes)
    {
        var attributesList = attributes.ToList();
        return
            method
            .CustomAttributes
            .ToList()
            .Find(a => attributesList.Find(al => al.IsSameByName(a.AttributeType)) != null) != null;
    }

    public static List<MethodDef> GetMethodsByAttribute(this ModuleDefMD module, params ITypeDefOrRef[] attributes)
    {
        var attributesList = attributes.ToList();
        return
            module
            .GetTypes()
            .SelectMany(t => t.Methods)
            .Where(m => m.HasCustomAttributes &&
                m.CustomAttributes
                .ToList()
                .Find(a => attributesList.Find(al => al.IsSameByName(a.AttributeType)) != null) != null
            ).ToList();
    }

    public static List<(MethodDef, CustomAttribute)> GetMethodsByAttributeAndFoundAttribute(this ModuleDefMD module, params ITypeDefOrRef[] attributes)
    {
        var attributesList = attributes.ToList();
        return
            module
            .GetTypes()
            .SelectMany(t => t.Methods)
            .Select(m =>
            {
                var foundAttribute =
                    m.CustomAttributes
                    .ToList()
                    .Find(a => attributesList.Find(al => al.IsSameByName(a.AttributeType)) != null);
                (MethodDef, CustomAttribute)? ret = m.HasCustomAttributes && foundAttribute != null ? (m, foundAttribute) : null;
                return ret;
            })
            .Where(m => m != null)
            .Select(m => ((MethodDef, CustomAttribute))m!)
            .ToList();
    }

    public static IMethodDefOrRef? GetOperandMethod(this Instruction inst) =>
        inst.Operand is IMethodDefOrRef
        ? inst.Operand as IMethodDefOrRef
        : inst.Operand is MethodSpec
            ? (inst.Operand as MethodSpec)!.Method
            : null
          ;

    public static int GetLdlocValue(this Instruction inst) => inst.OpCode.Code switch
    {
        Code.Ldloc_0 => 0,
        Code.Ldloc_1 => 1,
        Code.Ldloc_2 => 2,
        Code.Ldloc_3 => 3,
        Code.Ldloc_S => (int)inst.Operand,
        Code.Ldloc => (int)inst.Operand,
        _ => 0
    };

    public static int GetStlocValue(this Instruction inst) => inst.OpCode.Code switch
    {
        Code.Stloc_0 => 0,
        Code.Stloc_1 => 1,
        Code.Stloc_2 => 2,
        Code.Stloc_3 => 3,
        Code.Stloc_S => (int)inst.Operand,
        Code.Stloc => (int)inst.Operand,
        _ => 0
    };

    static Code[] stelemCodes = [Code.Stelem, Code.Stelem_I, Code.Stelem_I1, Code.Stelem_I2, Code.Stelem_I4, Code.Stelem_I8, Code.Stelem_R4, Code.Stelem_R8];
    public static bool IsStelem(this Code code) => stelemCodes.Contains(code);

    public static MemberRef AsImported(this MethodDef meth, ModuleDefMD module)
    {
        var refs = module.GetMemberRefs();
        foreach (var refas in refs)
        {
            if (!refas.IsMethodRef)
                continue;

            if (meth.Name != refas.Name)
                continue;

            if (!meth.DeclaringType.IsSame(refas.DeclaringType))
                continue;

            return refas;
        }

        return module.Import(meth);
    }

    public static bool ExIsArray(this TypeSig sig) => sig.GetType().Name.EndsWith("ArraySig");
}