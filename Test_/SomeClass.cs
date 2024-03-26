using System.Runtime.InteropServices;

namespace Test_;
public class SomeClass
{
    [NativeFunc("SomeClassDllExport")]
    static void TestNative2() { }

    [NativeFunc("NonStaticSomeClassDllExport")]
    static void TestNonStaticNative() { }

    [UnmanagedCallersOnly(EntryPoint = "SomeClassDllExportAN")]
    static void TestNative2_() { }
}