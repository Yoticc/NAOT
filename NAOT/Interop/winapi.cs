using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct cpointer
{
    public cpointer(nint address) => Address = address;

    public nint Address;

    public static implicit operator cpointer(nint address) => new(address);
    public static implicit operator cpointer(void* ptr) => new((nint)ptr);
    public static implicit operator cpointer(void** ptr) => new((nint)ptr);
    public static implicit operator cpointer(void*** ptr) => new((nint)ptr);

    public static implicit operator nint(cpointer pointer) => pointer.Address;
    public static implicit operator void*(cpointer pointer) => (void*)pointer;
    public static implicit operator void**(cpointer pointer) => (void**)pointer;
    public static implicit operator void***(cpointer Sudden_Reference_To_Bocchi_The_Rock) => (void***)Sudden_Reference_To_Bocchi_The_Rock;
}