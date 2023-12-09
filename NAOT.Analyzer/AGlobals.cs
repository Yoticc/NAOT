global using dnlib.DotNet;
global using static NAOT.Core.Utils.SugarExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer;
public static class AGlobals
{
    public static Dictionary<string, CallConvType> SigToCallConvDic = new()
    {
        {"__cdecl", CallConvType.cdelc},
        {"__fastcall", CallConvType.fastcall},
        {"__stdcall", CallConvType.stdcall},
        {"__thiscall", CallConvType.thiscall}
    };

    public static Dictionary<CallConvType, Type> CallConvToNativeCallConvDic = new()
    {
        {CallConvType.cdelc, typeof(CallConvCdecl)},
        {CallConvType.fastcall, typeof(CallConvFastcall)},
        {CallConvType.stdcall, typeof(CallConvStdcall)},
        {CallConvType.thiscall, typeof(CallConvThiscall)}
    };

    public static TypeSig TypeType;
    public static TypeSig TypeArrayType;
    public static TypeDef UnmanagedCallersOnlyAttribute;
    public static MethodDef UnmanagedCallersOnlyAttributeCtor;
    public static TypeDef EntryPointAttribute;
    public static TypeDef NativeFuncAttribute;
    public static TypeDef NativeFuncAttribute_1;
}