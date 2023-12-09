using dnlib.DotNet.Emit;
using NAOT.Core.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public class HandleLdftn : ILActualTask
{
    public override void Execute(ModuleDefMD module)
    {
        RedirectMethodCalls(module);
        StoreCompileGeneratedClasses();
        RemoveCompileGeneratedMembers();


    }

    List<FieldDef> compilerGeneratedFields = new();
    void RedirectMethodCalls(ModuleDefMD module)
    {
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

                        if (!callMeth.FullName.Contains("NaotDefines::ldftn"))
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
                        var ldftnMeth = (IMethod)ldftnInst.Operand;

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

    List<TypeDef> compilerGeneratedClasses = new();
    void StoreCompileGeneratedClasses()
    {
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
}