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

    public static partial class ICON
    {
        public static readonly UIntPtr SMALL = new UIntPtr(0);
        public static readonly UIntPtr BIG = new UIntPtr(1);
        public static readonly UIntPtr SMALL2 = new UIntPtr(2);
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
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport(AssemblyName)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

        [DllImport(AssemblyName, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessageTimeout(IntPtr hWnd, uint Msg, UIntPtr wParam, IntPtr lParam, uint fuFlags, uint uTimeout, [Optional] out UIntPtr lpdwResult);
    }

    public static partial class WM
    {
        public const uint GETICON = 0x007F;
    }

    public delegate bool WNDENUMPROC(IntPtr hWnd, IntPtr lParam);
}
