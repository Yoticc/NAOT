using dnlib.DotNet;
using dnlib.PE;
using NAOT.Analyzer.Utils;
using NAOT.Analyzer.Utils.Sugar;
using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using Newtonsoft.Json;
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
        var meths = 
            module
            .GetMethodsByAttribute(AGlobals.EntryPointAttribute)
            .Where(m =>
            {
                if (m.HasReturnType)
                {
                    Console.WriteLine($"EntryPoint {m.FullName} skipped because it's has return type");
                    return false;
                }

                if (!m.IsStatic)
                {
                    Console.WriteLine($"EntryPoint {m.FullName} skipped because it's not static");
                    return false;
                }

                if (m.Parameters.Count > 0)
                {
                    Console.WriteLine($"EntryPoint {m.FullName} skipped because it's has parameters");
                    return false;
                }

                return true;
            }).ToList();

        if (meths.Count == 0)
        {
            Console.WriteLine("Unable find EntryPoint method");
            return;
        }

        if (meths.Count > 1)
            Console.WriteLine($"Found more than one EntryPoint methods. Handled first, other skipped (methods: {string.Join(", ", meths.Select(m => m.FullName))})");

        var meth = meths[0];
        HandleEntryPoint(module, meth);
    }

    void HandleEntryPoint(ModuleDefMD module, MethodDef meth)
    {
        var attbr = meth.CustomAttributes;

        attbr.RemoveAt(attbr.ToList().FindIndex(a => a.AttributeType.IsSameByName(AGlobals.EntryPointAttribute)));
        attbr.Add(Helper.GetUnmanagedCallersOnlyAttribute(module, "NAOT.Analyzer.EntryPoint", typeof(CallConvStdcall)));
    }
}

public unsafe class HandleEntryPointTaskASM : ASMTask
{
    public override void Execute(string module)
    {
        var naotEPName = "NAOT.Analyzer.EntryPoint"u8;
        var internalDllMainName = "NAOT.Internal.DllMain"u8;

        using var pe = new PEEditor(module);

        Console.WriteLine(string.Join(' ', pe.Image->GetEATFuncIndex(naotEPName), pe.GetExportFunctionAddress(naotEPName), pe.Image->RvaToFileOffset(pe.GetExportFunctionAddress(naotEPName)), pe.GetExportFunctionAddress(internalDllMainName), pe.Image->RvaToFileOffset(pe.GetExportFunctionAddress(internalDllMainName))));

        var naotEPFunc = pe.Image->RvaToFileOffset(pe.GetExportFunctionAddress(naotEPName));
        pe.RemoveExportFunction(naotEPName);

        var internalDllMainFunc = pe.Image->RvaToFileOffset(pe.GetExportFunctionAddress(internalDllMainName));
        pe.RemoveExportFunction(internalDllMainName);


        var originalEP = pe.EntryPoint;
        var originalEPFO = pe.Image->RvaToFileOffset(originalEP);
        var originalEPPtr = (byte*)pe.Image->ptr + originalEPFO;
        //pe.EntryPoint = internalDllMainFunc;

        *originalEPPtr = 0xFE;
        *(originalEPPtr + 1) = 0xFD;
        *(originalEPPtr + 2) = 0xFA;

        pe.Save(module);
    }
}