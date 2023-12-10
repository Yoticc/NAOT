using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Internal;
internal unsafe class DllMain
{
    [UnmanagedCallersOnly(EntryPoint = "NAOT.Internal.DllMain", CallConvs = [typeof(CallConvStdcall)])]
    static bool DllMain_(nint module, uint reason, nint reserved)
    {
        ((delegate* unmanaged<nint, uint, nint, bool>)(module + 0xDEAD))(module, reason, reserved);
        ((delegate* unmanaged<void>)(module + 0xBEEF))();

        return true;
    }
}