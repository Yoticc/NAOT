using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_;
public class SomeClass
{
    [NativeFunc("SomeClassDllExport")]
    static void TestNative2() { }

    [UnmanagedCallersOnly(EntryPoint = "SomeClassDllExportAN")]
    static void TestNative2_() { }
}