﻿using dnlib.DotNet.Emit;
using Korn.Analyzer.Utils.Sugar;
using Korn.Core.Tasks;
using Korn.Core.Utils;
using System.Runtime.CompilerServices;

namespace Korn.Analyzer.Tasks;
public class HandleLdftnILTask : ILActualTask
{
    public override void Execute(ModuleDefMD module)
    {
        RedirectMethodCalls(module);
        StoreCompileGeneratedClasses();
        RemoveCompileGeneratedMembers();
        AddAtributesToAnnativeMethods(module);
    }

    List<FieldDef> compilerGeneratedFields;
    List<IMethodDefOrRef> usedUnnativedMethods;
    void RedirectMethodCalls(ModuleDefMD module)
    {
        compilerGeneratedFields = new();
        usedUnnativedMethods = new();
        Code[][] codeSequence = [
            [Code.Ldsfld],
            [Code.Dup],
            [Code.Brtrue, Code.Brtrue_S],
            [Code.Pop],
            [Code.Ldnull],
            [Code.Ldftn],
            [Code.Newobj],
            [Code.Dup],
            [Code.Stsfld]
        ];

        foreach (var type in module.GetTypes())
        {
            foreach (var meth in type.Methods)
            {
                if (!meth.HasBody)
                    continue;

                var body = meth.Body;
                var instr = body.Instructions;

                for (int i = 0; i < instr.Count; i++)
                {
                    var inst = instr[i];
                    var opcode = inst.OpCode;
                    var code = opcode.Code;

                    if (code == Code.Call)
                    {
                        var callInst = inst;
                        var callMeth = (IMethod)inst.Operand;

                        if (!callMeth.FullName.Contains("korn::ldftn"))
                            continue;

                        if (i < 9)
                            continue;

                        var broken = false;
                        var start = i - 9;
                        for (int o = start; o < i; o++)
                        {
                            if (!codeSequence[o - start].Contains(instr[o].OpCode.Code))
                            {
                                broken = true;
                                break;
                            }
                        }

                        if (broken)
                            continue;

                        var ldsfldInst = instr[start];
                        var ldsfldField = (FieldDef)ldsfldInst.Operand;
                        if (!compilerGeneratedFields.Contains(ldsfldField))
                            compilerGeneratedFields.Add(ldsfldField);

                        var ldftnInst = instr[start + 5];
                        var ldftnMeth = (IMethodDefOrRef)ldftnInst.Operand;

                        if (!ldftnMeth.ContainsAttribute(AGlobals.NativeMethodAttributes))
                            if (usedUnnativedMethods.Find(m => m.FullName == ldftnMeth.FullName) == null)
                                usedUnnativedMethods.Add(ldftnMeth);

                        instr.RemoveAt(start);
                        instr.RemoveAt(start);
                        instr.RemoveAt(start);
                        instr.RemoveAt(start);
                        instr.RemoveAt(start);
                        instr.RemoveAt(start + 1);
                        instr.RemoveAt(start + 1);
                        instr.RemoveAt(start + 1);
                        instr.RemoveAt(start + 1);

                        i -= 9;
                    }
                }
            }
        }
    }

    List<TypeDef> compilerGeneratedClasses;
    void StoreCompileGeneratedClasses()
    {
        compilerGeneratedClasses = new();
        foreach (var field in compilerGeneratedFields)
            if (!compilerGeneratedClasses.Contains(field.DeclaringType))
                compilerGeneratedClasses.Add(field.DeclaringType);
    }

    void RemoveCompileGeneratedMembers()
    {
        foreach (var field in compilerGeneratedFields)
            field.DeclaringType.Fields.Remove(field);

        foreach (var type in compilerGeneratedClasses)
            if (type.IsEmpty())
                type.RemoveTypeFromModule();
    }

    void AddAtributesToAnnativeMethods(ModuleDefMD module)
    {
        foreach (var method in usedUnnativedMethods)
        {
            var attributes = method.CustomAttributes;
            var nativeAttribute = Helper.GetUnmanagedCallersOnlyAttribute(module, null, typeof(CallConvStdcall));
            attributes.Add(nativeAttribute);
        }
    }
}