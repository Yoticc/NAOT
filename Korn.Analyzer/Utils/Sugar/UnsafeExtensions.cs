using System.Runtime.InteropServices;

namespace Korn.Analyzer.Utils.Sugar;
public unsafe static class UnsafeExtensions
{
    public static byte[] UnboxInArray(this object boxed, int size)
    {
        var handle = GCHandle.Alloc(boxed, GCHandleType.Pinned);
        var ptr = (byte*)handle.AddrOfPinnedObject();
        var result = new byte[size];
        for (int i = 0; i < size; i++)
            result[i] = ptr[i];

        handle.Free();
        return result;
    }
}