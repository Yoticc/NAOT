using System.Runtime.InteropServices;

namespace Test_;
public class SomeClass
{
    [NativeFunc("SomeClassDllExport")]
    static void TestNative2() { }

    [UnmanagedCallersOnly(EntryPoint = "SomeClassDllExportAN")]
    static void TestNative2_() { }
}