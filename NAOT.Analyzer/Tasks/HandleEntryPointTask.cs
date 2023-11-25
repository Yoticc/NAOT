using dnlib.DotNet;
using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public class HandleEntryPointTaskIL : ILMainTask
{
    public override void Execute(ModuleDefMD module)
    {
        foreach (var type in module.Types.SelectMany(t => t.GetTypes()))
        {
            foreach (var method in type.Methods)
            {
                var attrb = method.CustomAttributes.ToList();
                if (attrb.Find(a => a.AttributeType.FullName == "NAOT.Attributes.EntryPointAttribute") == null)
                    continue;

                if (method.HasReturnType)
                {
                    Console.WriteLine($"EntryPoint {method.FullName} skipped because it's has return type");
                    continue;
                }

                if (!method.IsStatic)
                {
                    Console.WriteLine($"EntryPoint {method.FullName} skipped because it's not static");
                    continue;
                }

                if (method.Parameters.Count > 0)
                {
                    Console.WriteLine($"EntryPoint {method.FullName} skipped because it's has parameters");
                    continue;
                }

                HandleEntryPoint(module, method);
                return;
            }
        }

        Console.WriteLine("Unable find EntryPoint method");
    }

    void HandleEntryPoint(ModuleDefMD module, MethodDef meth)
    {
        var attbr = meth.CustomAttributes;

        attbr.RemoveAt(attbr.ToList().FindIndex(a => a.TypeFullName == "NAOT.Attributes.EntryPointAttribute"));
        attbr.Add(Helper.GetUnmanagedCallersOnlyAttribute(module, "NAOT.Analyzer.EntryPoint", typeof(CallConvStdcall)));
    }
}

public class HandleEntryPointTaskASM : ASMTask
{
    public override void Execute(string module)
    {

    }
}