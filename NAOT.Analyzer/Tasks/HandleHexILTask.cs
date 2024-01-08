using dnlib.DotNet.Emit;
using NAOT.Analyzer.Utils.Dn;
using NAOT.Analyzer.Utils.Sugar;
using NAOT.Core.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public class HandleHexILTask : ILActualTask
{
    static ModuleDefMD a;
    public override void Execute(ModuleDefMD module)
    {
        a = module;

        Handler[] handlers = [
            EmptyArrayHandler
        ];

        var naotDefinesMethods = AGlobals.NAOTDefinesType.Methods.ToList();

        var hexMethod = naotDefinesMethods.Find(m => m.Name == "hex")!;
        var hexMethodFullName = hexMethod.FullName;

        foreach (var type in module.GetTypes())
            foreach (var method in type.Methods)
                HandleMethod(method);

        void HandleMethod(MethodDef method)
        {
            if (!method.HasBody)
                return;

            var body = method.Body;
            if (!body.HasInstructions)
                return;

            var insts = body.Instructions.ToList();
            for (int i = 0; i < insts.Count; i++)
            {
                var inst = insts[i];
                var opcode = inst.OpCode;
                var code = opcode.Code;

                if (code != Code.Call)
                    continue;

                var operand = inst.Operand;
                var callMethod = operand as IMethodDefOrRef;
                if (callMethod == null)
                    continue;

                var callMethodFullName = callMethod.FullName;

                if (hexMethodFullName != callMethodFullName)
                    continue;

                foreach (var handler in handlers)
                {
                    try
                    {
                        if (handler(insts, i))
                            break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception in HandleHexILTask->handler: {ex}");
                    }
                }
            }
        }
    }

    delegate bool Handler(List<Instruction> insts, int index);

    Handler EmptyArrayHandler = (insts, i) =>
    {
        var prevInst = insts[i - 1];
        if (prevInst.OpCode.Code == Code.Call)
        {
            var callMethod = prevInst.GetOperandMethod()!;
            if (callMethod.FullName.Contains("System.Array::Empty"))
            {
                insts.RemoveRange(i - 1, 2);

                var sam = new StaticArraysManager(a);
                sam.CreateByteArray(new byte[20]);

                return true;
            }
        }
        return false;
    };
}