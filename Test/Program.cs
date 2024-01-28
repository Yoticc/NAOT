using System.Numerics;
using static korn;

namespace Test;

public unsafe class Program
{
    #region ldftn
    static void Meth(int t)
    {
        delegate* unmanaged<int, void> ptr = ldftn<int>(Meth);

        A(ldftn<int>(Meth), new BigInteger(), ldftn(Meth_));
    }

    static void Meth_() { }

    static void A(void* a, object b, void* c) { }
    #endregion

    #region EntryPoint
    [EntryPoint]
    static void Main()
    {
        new HexTest().hextest();
    }
    #endregion

    #region NativeFunc
    [NativeFunc]
    static void TestNative() { }

    [NativeFunc("DllExportFuncA")]
    static void TestNative2() { }

    [NativeFunc<__stdcall>]
    static void TestNative3() { }
    #endregion
}