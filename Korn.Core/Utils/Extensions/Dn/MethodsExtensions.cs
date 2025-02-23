﻿namespace Korn.Core.Utils;
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

    public static bool CanBeNative(this MethodDef meth) => meth.IsStatic;

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

        var thisIndex = valueCasted.FindIndex(v => v.IsHiddenThisParameter);
        valueCasted.RemoveAt(thisIndex);

        var parameters = valueCasted.OrderBy(v => v.Index).ToList();
        valueCasted.Clear();

        for (var p = 0; p < parameters.Count; p++)
        {
            var param = parameters[p];

            valueCasted.Add(new Parameter(param.Index - 1, param.Type));
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
                            instructions.RemoveAt(i);
                            instructions.Insert(i, OpCodes.Ldarg_3.ToInstruction());
                        }
                        else
                        {
                            instruction.Operand = method.Parameters[index - 1];
                        }
                        break;
                }
            }
        }
    }
}