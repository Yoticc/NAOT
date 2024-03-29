using System.Runtime.InteropServices;

public unsafe static class korn
{
    #region Literals
    const string ExceptionMessage = "This method shouldn't be called directly. There is something wrong with the Korn.Analyzer. Perhaps you haven’t divided it up or are using it without korn publication";
    #endregion

    #region DllImports
    [DllImport("kernel32", CharSet = CharSet.Auto)]
    static extern
        uint CreateThread(uint* threadAttributes, uint stackSize, ThreadStart startAddress, uint* parameter, uint creationFlags, out uint threadId);
    #endregion

    #region ldftn
    public static delegate* unmanaged<void> ldftn(Delegate method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T> ldftn<T>(Func<T> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, void> ldftn<T>(Action<T> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2> ldftn<T, T2>(Func<T, T2> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, void> ldftn<T, T2>(Action<T, T2> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3> ldftn<T, T2, T3>(Func<T, T2, T3> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, void> ldftn<T, T2, T3>(Action<T, T2, T3> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4> ldftn<T, T2, T3, T4>(Func<T, T2, T3, T4> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, void> ldftn<T, T2, T3, T4>(Action<T, T2, T3, T4> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5> ldftn<T, T2, T3, T4, T5>(Func<T, T2, T3, T4, T5> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, void> ldftn<T, T2, T3, T4, T5>(Action<T, T2, T3, T4, T5> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6> ldftn<T, T2, T3, T4, T5, T6>(Func<T, T2, T3, T4, T5, T6> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, void> ldftn<T, T2, T3, T4, T5, T6>(Action<T, T2, T3, T4, T5, T6> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7> ldftn<T, T2, T3, T4, T5, T6, T7>(Func<T, T2, T3, T4, T5, T6, T7> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, void> ldftn<T, T2, T3, T4, T5, T6, T7>(Action<T, T2, T3, T4, T5, T6, T7> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8> ldftn<T, T2, T3, T4, T5, T6, T7, T8>(Func<T, T2, T3, T4, T5, T6, T7, T8> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8>(Action<T, T2, T3, T4, T5, T6, T7, T8> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method) => throw new NotImplementedException(ExceptionMessage);
    public static delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void> ldftn<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method) => throw new NotImplementedException(ExceptionMessage);

    #endregion

    #region calli
    public static void calli(cpointer pointer) => ((delegate* unmanaged<void>)pointer)();
    public static TOut calli<TOut>(cpointer pointer) => ((delegate* unmanaged<TOut>)pointer)();
    public static void calli<T>(cpointer pointer, T arg1) => ((delegate* unmanaged<T, void>)pointer)(arg1);
    public static TOut calli<TOut, T>(cpointer pointer, T arg1) => ((delegate* unmanaged<T, TOut>)pointer)(arg1);
    public static void calli<T, T2>(cpointer pointer, T arg1, T2 arg2) => ((delegate* unmanaged<T, T2, void>)pointer)(arg1, arg2);
    public static TOut calli<TOut, T, T2>(cpointer pointer, T arg1, T2 arg2) => ((delegate* unmanaged<T, T2, TOut>)pointer)(arg1, arg2);
    public static void calli<T, T2, T3>(cpointer pointer, T arg1, T2 arg2, T3 arg3) => ((delegate* unmanaged<T, T2, T3, void>)pointer)(arg1, arg2, arg3);
    public static TOut calli<TOut, T, T2, T3>(cpointer pointer, T arg1, T2 arg2, T3 arg3) => ((delegate* unmanaged<T, T2, T3, TOut>)pointer)(arg1, arg2, arg3);
    public static void calli<T, T2, T3, T4>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4) => ((delegate* unmanaged<T, T2, T3, T4, void>)pointer)(arg1, arg2, arg3, arg4);
    public static TOut calli<TOut, T, T2, T3, T4>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4) => ((delegate* unmanaged<T, T2, T3, T4, TOut>)pointer)(arg1, arg2, arg3, arg4);
    public static void calli<T, T2, T3, T4, T5>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => ((delegate* unmanaged<T, T2, T3, T4, T5, void>)pointer)(arg1, arg2, arg3, arg4, arg5);
    public static TOut calli<TOut, T, T2, T3, T4, T5>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => ((delegate* unmanaged<T, T2, T3, T4, T5, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5);
    public static void calli<T, T2, T3, T4, T5, T6>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6);
    public static void calli<T, T2, T3, T4, T5, T6, T7>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    public static void calli<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
    public static TOut calli<TOut, T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(cpointer pointer, T arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => ((delegate* unmanaged<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOut>)pointer)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

    #endregion

    #region thread
    public static uint thread(ThreadStart entryPoint)
    {
        uint parameter = 0;
        uint threadID = 0;
        uint handle = CreateThread(null, 0, entryPoint, &parameter, 0, out threadID);
        return handle;
    }

    public static uint threadwhile(Action action) => thread(() =>
    {
        while (true)
            action();
    });

    public static uint threadwhile(Func<bool> shouldReturnFalseWhenEndWhile) => thread(() =>
    {
        do { }
        while (shouldReturnFalseWhenEndWhile());
    });
    #endregion

    #region hex
    public static byte[] hex(params object[] args) => throw new NotImplementedException(ExceptionMessage);
    #endregion
}