using System.Runtime.InteropServices;

namespace Korn.Core.Utils;
public class Interop
{
    [DllImport("user32", CharSet = CharSet.Unicode)] public static extern 
        int MessageBox(nint hWnd, string text, string caption, uint type);
}