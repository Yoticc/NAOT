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
    public override void Execute(ModuleDefMD module)
    {
        Handler[] handlers = [
            EmptyArrayHandler,
            LocalArrayHandler
        ];

        var sam = new StaticArraysManager(module);

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

            var insts = body.Instructions;
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
                        if (handler(module, sam, insts, i))
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

    delegate bool Handler(ModuleDefMD module, StaticArraysManager sam, IList<Instruction> insts, int index);

    Handler EmptyArrayHandler = (module, sam, insts, i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;
        /*
         *  [i-1]  call  System.Array::Empty<?>()
         *  [i]    call  uint8[] NaotDefines::hex(object[]) 
        */
        if (prevInstCode == Code.Call)
        {
            var callMethod = prevInst.GetOperandMethod()!;
            if (callMethod.FullName.Contains("System.Array::Empty"))
            {
                insts[i - 1] = new(OpCodes.Ldc_I4_0);
                insts[i] = new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte));
                /*
                 *  [i-1]  ldc.i4.0
                 *  [i]    newarr   uint8
                */
                return true;
            }
        }
        /*
         *  [i-2]  ldc.i4.0
         *  [i-1]  newarr    ?
         *  [i]    call      uint8[] NaotDefines::hex(object[]) 
        */
        else if (prevInstCode == Code.Newarr)
        {
            if (insts[i - 2].OpCode.Code == Code.Ldc_I4_0)
            {
                insts[i] = new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte));
                insts.RemoveAt(i - 1);
                /*
                 *  [i-2]  ldc.i4.0
                 *  [i]    newarr    uint8
                */
                return true;
            }    
        }
        return false;
    };

    Handler LocalArrayHandler = (module, sam, insts, i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;

        /*
         * [p-1]  ldc.i4?
         * [p]    newarr
         * ...
         * [o]    stloc
         * ...
         * [i-1]  ldloc?
         * [i]    uint8[] NaotDefines::hex(object[])
        */
        if (prevInst.IsLdloc())
        {
            int value = prevInst.GetLdlocValue();

            for (int o = i - 1; o > 0; o--)
            {
                if (insts[o].IsStloc())
                {
                    if (insts[o].GetStlocValue() == value)
                    {
                        for (int p = o - 1; p > 0; p--)
                        {
                            if (insts[p].OpCode.Code == Code.Newarr)
                            {
                                if (insts[p - 1].GetLdcI4Value() == 0)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }

        return false;
    };

    List<byte> CompileToByteArray()
    {
        var result = new List<byte>();

        return result;
    }
}