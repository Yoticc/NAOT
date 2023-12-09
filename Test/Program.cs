using NAOT;
using static NaotDefines;
using System.Numerics;

namespace Test;

public unsafe class Program
{    
    static void Meth(int t)
    {
        delegate* unmanaged<int, void> ptr = ldftn<int>(Meth);

        A(ldftn<int>(Meth), new BigInteger(), ldftn(Meth_));
    }

    static void Meth_() { }

    static void A(void* a, object b, void* c) { } 

    [EntryPoint]
    static void Main() { }

    [NativeFunc]
    static void TestNative() { }

    [NativeFunc("DllExportFuncA")]
    static void TestNative2() { }

    [NativeFunc<__stdcall>]
    static void TestNative3() { }    
}
