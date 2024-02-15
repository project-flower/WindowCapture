using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NativeMethods
{
    /// <summary>
    /// Class field offsets for GetClassLong()
    /// </summary>
    public static partial class GCL
    {
        public const int MENUNAME = -8;
        public const int HBRBACKGROUND = -10;
        public const int HCURSOR = -12;
        public const int HICON = -14;
        public const int HMODULE = -16;
        public const int CBWNDEXTRA = -18;
        public const int CBCLSEXTRA = -20;
        public const int WNDPROC = -24;
        public const int STYLE = -26;
        public const int ATOM = -32;
        public const int HICONSM = -34;
    }

    public static partial class User32
    {
        [DllImport(AssemblyName)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, IntPtr lParam);

        [DllImport(AssemblyName, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetClassLongPtr(IntPtr hWnd, int nIndex);

        [DllImport(AssemblyName, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport(AssemblyName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport(AssemblyName, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport(AssemblyName)]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);
    }

    public delegate bool WNDENUMPROC(IntPtr hWnd, IntPtr lParam);
}
