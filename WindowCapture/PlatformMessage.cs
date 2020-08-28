using System;
using System.Text;
using Win32Api;

public static class PlatformMessage
{
    public static string Get(int messageId)
    {
        var builder = new StringBuilder(byte.MaxValue);
        Kernel32.FormatMessage(FORMAT.MESSAGE_FROM_SYSTEM, IntPtr.Zero, messageId, 0, builder, builder.Capacity, IntPtr.Zero);
        return builder.ToString();
    }
}
