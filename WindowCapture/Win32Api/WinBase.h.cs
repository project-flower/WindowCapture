using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Win32Api
{
    public enum FORMAT : uint
    {
        MESSAGE_IGNORE_INSERTS = 0x00000200,
        MESSAGE_FROM_STRING = 0x00000400,
        MESSAGE_FROM_HMODULE = 0x00000800,
        MESSAGE_FROM_SYSTEM = 0x00001000,
        MESSAGE_ARGUMENT_ARRAY = 0x00002000,
        MESSAGE_MAX_WIDTH_MASK = 0x000000FF
    }

    public static partial class Kernel32
    {
        [DllImport(AssemblyName)]
        public static extern uint FormatMessage(FORMAT dwFlags, IntPtr lpSource, int dwMessageId, uint dwLanguageId, StringBuilder lpBuffer, int nSize, IntPtr Arguments);
    }
}
