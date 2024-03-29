using dnlib.DotNet.Emit;
using Korn.Analyzer;
using Korn.Core;
using Korn.Core.Tasks;
using Korn.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FunctionalizeCalliTask() : InitTask(-9)
{
    public override void Execute()
    {
        /*
        foreach (var method in AGlobals.DefinesType.Methods)
        {
            if (method.Name != "calli") 
                continue;

            var instructions = method.Body.Instructions;
            instructions.Clear();
                        
            var parameters = method.Parameters.OrderBy(p => p.Index).ToList();
            var methodSig = new MethodSig(CallingConvention.Unmanaged, (uint)method.GenericParameters.Count);
            methodSig.RetType = method.ReturnType;

            for (var a = 1; a < parameters.Count; a++)
            {
                methodSig.Params.Add(parameters[a].Type);
                instructions.Add(method.CreateLdarg(parameters[a]));
            }            

            instructions.Add(
                OpCodes.Ldarg_0.ToInstruction(),
                Instruction.Create(OpCodes.Calli, methodSig),
                OpCodes.Ret.ToInstruction()
            );
        }
        */
    }
}