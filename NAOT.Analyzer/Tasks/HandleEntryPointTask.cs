using dnlib.DotNet;
using dnlib.PE;
using NAOT.Analyzer.Utils;
using NAOT.Analyzer.Utils.Sugar;
using NAOT.Core;
using NAOT.Core.Tasks;
using NAOT.Core.Utils;
using Newtonsoft.Json;
using System;
using System.Collections;
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

        var naotEPFunc = pe.GetExportFunctionAddress(naotEPName);
        var naotEPFuncFO = pe.Image->RvaToFileOffset(naotEPFunc);
        var naotEPFuncPtr = (byte*)pe.Image->ptr + naotEPFuncFO;
        pe.RemoveExportFunction(naotEPName);

        var internalDllMainFunc = pe.GetExportFunctionAddress(internalDllMainName);
        var internalDllMainFuncFO = pe.Image->RvaToFileOffset(pe.GetExportFunctionAddress(internalDllMainName));
        var internalDllMainFuncPtr = (byte*)pe.Image->ptr + internalDllMainFuncFO;
        pe.RemoveExportFunction(internalDllMainName);

        var originalEP = pe.EntryPoint;
        var originalEPFO = pe.Image->RvaToFileOffset(originalEP);
        var originalEPPtr = (byte*)pe.Image->ptr + originalEPFO;
        pe.EntryPoint = internalDllMainFunc;

        var internalDllMainFuncSize = pe.CalculateFunctionSize((nint)internalDllMainFuncPtr, [0x90, 0x90, 0x90, 0x90]);

        if (internalDllMainFuncSize == -1)
            Console.WriteLine("Unable calculate size of NAOT.Internal.DllMain function");

        var foundFirstOffset = false;
        var foundSecondOffset = false;

        for (int i = 0; i < internalDllMainFuncSize; i++)
            internalDllMainFuncPtr[i] = 0x90;

        byte[] newBytes = [ // Modified asm code. There is a problem. That unmodified code uses a GC call before calling the original entrypoint and the program crashes
            0x4C, 0x89, 0x44, 0x24, 0x18, 0x89, 0x54, 0x24, 0x10, 0x48, 0x89, 0x4C, 0x24, 0x08, 0x55, 0x57,
            0x48, 0x81, 0xEC, 0xE8, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x6C, 0x24, 0x20, 0x48, 0x8B, 0x85, 0xE0,
            0x00, 0x00, 0x00, 0x48, 0x05, 0xAD, 0xDE, 0x00, 0x00, 0x4C, 0x8B, 0x85, 0xF0, 0x00, 0x00, 0x00,
            0x8B, 0x95, 0xE8, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x8D, 0xE0, 0x00, 0x00, 0x00, 0xFF, 0xD0, 0x48,
            0x8B, 0x85, 0xE0, 0x00, 0x00, 0x00, 0x48, 0x05, 0xEF, 0xBE, 0x00, 0x00, 0xFF, 0xD0, 0xB0, 0x01,
            0x48, 0x8D, 0xA5, 0xC8, 0x00, 0x00, 0x00, 0x5F, 0x5D, 0xC3
            ];

        for (int i = 0; i < newBytes.Length; i++)
            internalDllMainFuncPtr[i] = newBytes[i];

        for (int i = 0; i < internalDllMainFuncSize; i++)
        {
            var ptr = internalDllMainFuncPtr + i;
            var intPtr = (uint*)ptr;
            switch (*intPtr)
            {
                case 0xDEAD:
                    foundFirstOffset = true;
                    *intPtr = originalEP;
                    break;

                case 0xBEEF:
                    foundSecondOffset = true;
                    *intPtr = naotEPFunc;
                    break;
            }
        }

        if (!foundFirstOffset)
            Console.WriteLine("Unable found first offset in NAOT.Internal.DllMain function");
        if (!foundSecondOffset)
            Console.WriteLine("Unable found second offset in NAOT.Internal.DllMain function");

        pe.Save(module);
    }
}