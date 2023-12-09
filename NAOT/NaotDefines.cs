global using NAOT;
global using static NaotDefines;

public unsafe static class NaotDefines
{
    const string ExceptionMessage = "This method shouldn't be called directly. There is something wrong with the NAOT.Analyzer. Perhaps you haven’t divided it up or are using it without naot publication";
    public static delegate* unmanaged<void> ldftn(Action meth) => throw new NotImplementedException(ExceptionMessage);
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
}