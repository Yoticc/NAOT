﻿global using NAOT;
global using static NaotDefines;
using System.Runtime.InteropServices;

public unsafe static class NaotDefines
{
    #region Literals
    const string ExceptionMessage = "This method shouldn't be called directly. There is something wrong with the NAOT.Analyzer. Perhaps you haven’t divided it up or are using it without naot publication";
    #endregion

    #region DllImports
    [DllImport("kernel32", CharSet = CharSet.Auto)] static extern 
        uint CreateThread(uint* threadAttributes, uint stackSize, ThreadStart startAddress, uint* parameter, uint creationFlags, out uint threadId);
    #endregion

    #region ldftn
    public static delegate* unmanaged<void> ldftn(Delegate meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, void> ldftn<T>(Action<T> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T> ldftn<T>(Func<T> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, void> ldftn<T, T2>(Action<T, T2> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2> ldftn<T, T2>(Func<T, T2> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, void> ldftn<T, T2, T3>(Action<T, T2, T3> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3> ldftn<T, T2, T3>(Func<T, T2, T3> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, void> ldftn<T, T2, T3, T4>(Action<T, T2, T3, T4> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4> ldftn<T, T2, T3, T4>(Func<T, T2, T3, T4> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, void> ldftn<T, T2, T3, T4, T5>(Action<T, T2, T3, T4, T5> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5> ldftn<T, T2, T3, T4, T5>(Func<T, T2, T3, T4, T5> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, void> ldftn<T, T2, T3, T4, T5, T6>(Action<T, T2, T3, T4, T5, T6> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6> ldftn<T, T2, T3, T4, T5, T6>(Func<T, T2, T3, T4, T5, T6> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, void> ldftn<T, T2, T3, T4, T5, T6, T7>(Action<T, T2, T3, T4, T5, T6, T7> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7> ldftn<T, T2, T3, T4, T5, T6, T7>(Func<T, T2, T3, T4, T5, T6, T7> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8>(Action<T, T2, T3, T4, T5, T6, T7, T8> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8> ldftn<T, T2, T3, T4, T5, T6, T7, T8>(Func<T, T2, T3, T4, T5, T6, T7, T8> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> meth) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> meth) => throw new NotImplementedException(ExceptionMessage);
    #endregion

    #region thread
    public static uint thread(ThreadStart entryPoint)
    {
        uint parameter = 0;
        uint threadID = 0;
        uint handle = CreateThread(null, 0, entryPoint, &parameter, 0, out threadID);
        return handle;
    }

    public static uint threadwhile(Action action) => thread(() =>{
        while (true)
            action();
    });

    public static uint threadwhile(Func<bool> shouldReturnFalseWhenEndWhile) => thread(() => {
        do { }
        while (shouldReturnFalseWhenEndWhile());
    });
    #endregion

    #region hex
    public static byte[] hex(params object[] args) => throw new NotImplementedException(ExceptionMessage);
    public static List<byte> hexl(params object[] args) => throw new NotImplementedException(ExceptionMessage);
    #endregion
}