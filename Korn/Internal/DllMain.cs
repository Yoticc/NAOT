namespace Korn.Internal;
internal unsafe static class DllMain
{
    [UnmanagedCallersOnly(EntryPoint = "Korn.Internal.DllMain", CallConvs = [typeof(CallConvStdcall)])]
    static bool DllMain_(nint module, uint reason, nint reserved)
    {
        ((delegate* unmanaged<nint, uint, nint, bool>)(module + 0xDEAD))(module, reason, reserved);
        ((delegate* unmanaged<void>)(module + 0xBEEF))();

        return true;
    }
}