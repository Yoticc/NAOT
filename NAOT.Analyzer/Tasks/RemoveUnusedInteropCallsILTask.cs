using dnlib.DotNet.Emit;
using NAOT.Core;
using NAOT.Core.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public class RemoveUnusedInteropCallsILTask : PrepareNativeTask
{
    public override void Execute()
    {
        var referenceTypes = new TypeDef[] { 
            AGlobals.NAOTKernel32InteropType,
            AGlobals.NAOTUser32InteropType
        };
        var referenceTypesNames = referenceTypes.Select(t => t.Name);

        var referenceMehodsNames = referenceTypes.Select(t => t.Methods).SelectMany(m => m).Select(m => m.FullName.ToString()).ToList();

        var usedMethods = new List<string>();
        foreach (var module in (ModuleDefMD[])[..Globals.Dn.DnModules.Input, Globals.Dn.DnModules.Main])
        {
            if (module.Name == "NAOT.dll")
                continue;

            foreach (var type in module.GetTypes())
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody)
                        continue;

                    var body = method.Body;

                    if (!body.HasInstructions)
                        continue;
                    
                    var insts = body.Instructions;

                    foreach (var inst in insts)
                    {
                        var opcode = inst.OpCode;
                        var code = opcode.Code;
                        if (!new Code[] { Code.Call, Code.Calli, Code.Callvirt/*Maybe useless*/, Code.Ldftn }.Contains(code))
                            continue;

                        var operand = inst.Operand;
                        if (operand is not IMethodDefOrRef)
                            continue;

                        var callMethod = operand as IMethodDefOrRef;
                        var declaringType = callMethod.DeclaringType;

                        if (!referenceTypesNames.Contains(declaringType.Name))
                            continue;

                        var methodName = callMethod.FullName;

                        if (!referenceMehodsNames.Contains(methodName))
                            continue;

                        if (usedMethods.Contains(methodName))
                            continue;

                        usedMethods.Add(methodName);
                    }
                }
            }
        }

        foreach (var type in referenceTypes)
        {
            var methods = type.Methods;
            for (int m = 0; m < methods.Count;)
            {
                if (!usedMethods.Contains(methods[m].FullName))
                    methods.RemoveAt(m);
                else m++;
            }
        }
    }
}