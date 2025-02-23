﻿namespace Korn.Analyzer;
public static class Env
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
    public static TypeSig ByteArray;
    public static TypeDef ValueTypeType;
    public static TypeDef DefinesType;
    public static TypeDef Kernel32InteropType;
    public static TypeDef User32InteropType;
    public static TypeDef UnmanagedCallersOnlyAttribute;
    public static TypeDef StructLayoutAttribute;
    public static TypeSig LayoutKindType;
    public static MethodDef UnmanagedCallersOnlyAttributeCtor;
    public static MethodDef StructLayoutAttributeCtor;
    public static TypeDef EntryPointAttribute;
    public static TypeDef NativeFuncAttribute;
    public static TypeDef NativeFuncAttribute_1;
    public static TypeDef DllImportAttribute;
    public static TypeDef RuntimeHelpersType;
    public static MethodDef InitializeArrayMethod;
    public static TypeDef EnumerableType;
    public static MethodDef EnumerableToArrayMethod;
                  
    public static TypeDef[] NativeMethodAttributes;
}