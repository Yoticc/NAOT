using NAOT;
using static NaotDefines;
using System.Numerics;
using System.Runtime.InteropServices;

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

    void hextest()
    {
        var _ = new object();
        
        _ = hex(); // byte[0]
        _ = hex(0); // 00 00 00 00
        _ = hex(1d); // 00 00 00 00 00 00 F0 3F
        _ = hex(""); // byte[0]
        _ = hex("00"); // 00
        _ = hex("00FFED0D"); // 00 FF ED 0D
        _ = hex("00 FF ED 0D"); // 00 FF ED 0D
        _ = hex("0 FF ED D"); // 00 FF ED 0D
        _ = hex("0 FF 0xED 0xD"); // 00 FF ED 0D
        _ = hex("0 FF 0xED D"); // 00 FF ED 0D
        _ = hex("0 FF 0xED D", (byte)0x30, "FF FE"); // 00 FF ED 0D  30  FF FE
        _ = hex("0 FF 0xED D", (byte[])[0x30, 0, 0, 0xFF], "FF FE"); // 00 FF ED 0D  30 0 0 FF  FF FE

    }
}