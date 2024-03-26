using dnlib.DotNet.Emit;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    public static List<(MethodDef, CustomAttribute)> GetMethodsByAttributeAndFoundAttribute(this ModuleDefMD module, params ITypeDefOrRef[] attributes)
    {
        var attributesList = attributes.ToList();
        return
            module
            .GetMethods()
            .Select(m =>
            {
                var foundAttribute =
                    m.CustomAttributes
                    .ToList()
                    .Find(a => attributesList.Find(al => al.IsSameByName(a.AttributeType)) is not null);
                (MethodDef, CustomAttribute)? ret = m.HasCustomAttributes && foundAttribute is not null ? (m, foundAttribute) : null;
                return ret;
            })
            .Where(m => m is not null)
            .Select(m => ((MethodDef, CustomAttribute))m!)
            .ToList();
    }

    public static MemberRef AsImported(this MethodDef method, ModuleDefMD module)
    {
        var refs = module.GetMemberRefs();
        foreach (var refas in refs)
        {
            if (!refas.IsMethodRef)
                continue;

            if (method.Name != refas.Name)
                continue;

            if (!method.DeclaringType.IsSame(refas.DeclaringType))
                continue;

            return refas;
        }

        return module.Import(method);
    }

    public static bool CanBeNative(this MethodDef method) => method.IsStatic;

    public static bool CanBeModifiedToStatic(this MethodDef method)
    {
        if (method.IsStatic)
            return true;

        if (!method.HasBody)
            return true;

        foreach (var instruction in method.Body.Instructions)
            if (instruction.OpCode.Code == Code.Ldarg_0 || (instruction.IsLdarga() && instruction.GetLdargaValue(method) == 0))
                return false;

        return true;
    }

    public static void SetStaticFlag(this MethodDef method)
    {
        if (method.IsStatic)
            return;

        var fields = method.Parameters.GetType().GetRuntimeFields().ToList();
        var field = fields.Find(f => f.Name == "parameters")!;
        var value = field.GetValue(method.Parameters);
        var valueCasted = (field.GetValue(method.Parameters) as List<Parameter>)!;
        valueCasted.RemoveAt(0);

        for (var p = 0; p < valueCasted.Count; p++)
        {
            var param = valueCasted[p];
            valueCasted.RemoveAt(p);
            valueCasted.Add(new Parameter(p, param.Type));
        }

        method.IsStatic = true;
        method.Signature.HasThis = false;
    }

    public static void ModifyToStatic(this MethodDef method)
    {
        if (method.IsStatic)
            return;

        if (!method.CanBeModifiedToStatic())
            return;

        var instructions = method.Body.Instructions;
        SetStaticFlag(method);

        for (var i = 0; i < instructions.Count; i++)
        {
            var instruction = instructions[i];

            if (instruction.IsLdarga())
            {
                instruction.Operand = method.Parameters[(instruction.Operand as Parameter)!.Index - 1];
            }
            else if (instruction.IsLdarg())
            {
                switch (instruction.OpCode.Code)
                {
                    case Code.Ldarg_1:
                        instruction.OpCode = OpCodes.Ldarg_0;
                        break;
                    case Code.Ldarg_2:
                        instruction.OpCode = OpCodes.Ldarg_1;
                        break;
                    case Code.Ldarg_3:
                        instruction.OpCode = OpCodes.Ldarg_2;
                        break;
                    case Code.Ldarg:
                    case Code.Ldarg_S:
                        var index = (instruction.Operand as Parameter)!.Index;
                        if (index == 4)
                        {
                            instruction.OpCode = OpCodes.Ldarg_3;
                            instruction.Operand = null;
                        }
                        else
                        {
                            instruction.Operand = method.Parameters[(instruction.Operand as Parameter)!.Index - 1];
                        }
                        break;
                }
            }
        }
    }
}