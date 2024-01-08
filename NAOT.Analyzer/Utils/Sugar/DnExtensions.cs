using dnlib.DotNet.Emit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Utils.Sugar;
public static class DnExtensions
{
    public static bool IsCanBeNative(this MethodDef meth) => !meth.HasGenericParameters && meth.IsStatic;

    public static string GetNonGenericParamsFullName(this IType type) => type.FullName.Split('<')[0];
    public static string GetNonGenericFullName(this IType type) => type.FullName.Split('`')[0];

    static SigComparer sigComparer = new();
    public static bool IsSame(this IType type1, IType type2) => sigComparer.Equals(type1, type2);

    public static bool IsSameByName(this IType type1, IType type2) => GetNonGenericParamsFullName(type1) == GetNonGenericParamsFullName(type2);

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
            .Select(m => {
                var foundAttribute =
                    m.CustomAttributes
                    .ToList()
                    .Find(a => attributesList.Find(al => al.IsSameByName(a.AttributeType)) != null);
                (MethodDef, CustomAttribute)? ret = (m.HasCustomAttributes && foundAttribute != null) ? (m, foundAttribute) : null;
                return ret;
            })
            .Where(m => m != null)
            .Select(m => ((MethodDef, CustomAttribute))m!)
            .ToList();
    }

    public static IMethodDefOrRef? GetOperandMethod(this Instruction inst) => 
        inst.Operand is IMethodDefOrRef 
        ? (inst.Operand as IMethodDefOrRef) 
        : (inst.Operand is MethodSpec 
            ? ((inst.Operand as MethodSpec)!.Method)
            : null
          );
}