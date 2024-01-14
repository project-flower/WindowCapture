using NativeMethods;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowCapture
{
    public static class MainEngine
    {
        #region Public Classes

        public enum Mode
        {
            CopyFromScreen,
            Handle,
            PrintWindow
        }

        #endregion

        #region Private Classes

        private class HdcManager : IDisposable
        {
            private readonly Graphics graphics;
            private readonly Stack<IntPtr> handles;

            public HdcManager(Graphics graphics)
            {
                this.graphics = graphics;
                handles = new Stack<IntPtr>();
            }

            public IntPtr GetHdc()
            {
                IntPtr result = graphics.GetHdc();
                handles.Push(result);
                return result;
            }

            public void Dispose()
            {
                while (handles.Count > 0)
                {
                    graphics.ReleaseHdc(handles.Pop());
                }
            }
        }

        #endregion

        #region Private Fields

        private static readonly Size frameBorderSize;
        private static readonly int osVersion;

        #endregion

        #region Public Methods

        static MainEngine()
        {
            frameBorderSize = SystemInformation.FrameBorderSize;
            osVersion = Environment.OSVersion.Version.Major;
        }

        public static Image Capture(Mode mode, IntPtr handle, string fileName, bool requirePreview)
        {
            if (!User32.GetWindowRect(handle, out RECT rect))
            {
                throw new Exception(PlatformMessage.Get(Marshal.GetLastWin32Error()));
            }

            Rectangle rectangle;

            if ((mode == Mode.CopyFromScreen) && (osVersion > 5))
            {
                int left = (rect.Left + frameBorderSize.Width - 1);
                rectangle = new Rectangle(left, rect.Top, (rect.Right - left - frameBorderSize.Width + 1), (rect.Bottom - rect.Top - frameBorderSize.Height + 1));
            }
            else
            {
                rectangle = new Rectangle(rect.Left, rect.Top, (rect.Right - rect.Left), (rect.Bottom - rect.Top));
            }

            var result = new Bitmap(rectangle.Width, rectangle.Height);

            try
            {
                switch (mode)
                {
                    case Mode.CopyFromScreen:
                        CaptureWithCopyFromScreen(rectangle, result);
                        break;
                    case Mode.Handle:
                        CaptureWithHandle(handle, result);
                        break;
                    case Mode.PrintWindow:
                        CaptureWithPrintWindow(handle, result);
                        break;
                    default:
                        return null;
                }

                result.Save(fileName, ImageFormat.Png);
            }
            catch
            {
                result.Dispose();
                throw;
            }

            if (!requirePreview)
            {
                result.Dispose();
                result = null;
            }

            return result;
        }

        #endregion

        #region Private Methods

        private static void CaptureWithCopyFromScreen(Rectangle rectangle, Bitmap bitmap)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                try
                {
                    graphics.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, bitmap.Size);
                }
                catch
                {
                    throw;
                }
            }
        }

        private static void CaptureWithHandle(IntPtr handle, Bitmap bitmap)
        {
            using (Graphics graphicsSource = Graphics.FromHwnd(handle))
            using (Graphics graphicsDest = Graphics.FromImage(bitmap))
            using (var managerSource = new HdcManager(graphicsSource))
            using (var managerDest = new HdcManager(graphicsDest))
            {
                try
                {
                    if (!Gdi32.BitBlt(managerDest.GetHdc(), 0, 0, bitmap.Width, bitmap.Height, managerSource.GetHdc(), 0, 0, WinGdi.SRCCOPY))
                    {
                        throw new Exception(PlatformMessage.Get(Marshal.GetLastWin32Error()));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        private static Image CaptureWithPrintWindow(IntPtr handle, Bitmap bitmap)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (var manager = new HdcManager(graphics))
            {
                try
                {
                    if (!User32.PrintWindow(handle, manager.GetHdc(), 0))
                    {
                        throw new Exception("画像が取得できませんでした。");
                    }
                }
                catch
                {
                    throw;
                }
            }

            return bitmap;
        }

        #endregion
    }
}
