using System;
using System.Runtime.InteropServices;

namespace Win32Api
{
    public static partial class User32
    {
        [DllImport(AssemblyName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport(AssemblyName)]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);
    }
}
