using NAOT;
using static NaotDefines;
using System.Numerics;
using System.Runtime.InteropServices;

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

    [DllImport("user32", SetLastError = true, CharSet = CharSet.Auto)]
    public static extern int MessageBox(nint hWnd, string text, string caption, uint type);

    [EntryPoint]
    static void Main()
    {        
        void* a = null;
        //kernel32.LeaveCriticalSection(a);
        //void* ptr1 = ldftn(kernel32.LeaveCriticalSectionWhenCallbackReturns);
        MessageBox(0, "hoba", "", 0);
    }

    [NativeFunc]
    static void TestNative() { }

    [NativeFunc("DllExportFuncA")]
    static void TestNative2() { }

    [NativeFunc<__stdcall>]
    static void TestNative3() { }  
}