using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Win32Api;

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

        #region Private Fields

        private static readonly Size frameBorderSize;

        #endregion

        #region Public Methods

        static MainEngine()
        {
            frameBorderSize = SystemInformation.FrameBorderSize;
        }

        public static Image Capture(Mode mode, IntPtr handle, string fileName, bool requirePreview)
        {
            Image result = null;

            switch (mode)
            {
                case Mode.CopyFromScreen:
                    result = captureByCopyFromScreen(handle, fileName, requirePreview);
                    break;
                case Mode.Handle:
                    result = captureByHandle(handle, fileName, requirePreview);
                    break;
                case Mode.PrintWindow:
                    result = captureByPrintWindow(handle, fileName, requirePreview);
                    break;
            }

            return result;
        }

        #endregion

        #region Private Methods

        private static Image captureByCopyFromScreen(IntPtr handle, string fileName, bool requirePreview)
        {
            RECT rect;

            if (!User32.GetWindowRect(handle, out rect))
            {
                throw new IOException("ウィンドウ サイズが取得できません。");
            }

            Bitmap bitmap;

            try
            {
                bitmap = new Bitmap((rect.Right - rect.Left - ((frameBorderSize.Width - 1) * 2)), (rect.Bottom - rect.Top - (frameBorderSize.Height - 1)));
            }
            catch
            {
                throw;
            }

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                try
                {
                    graphics.CopyFromScreen((rect.Left + frameBorderSize.Width - 1), rect.Top, 0, 0, bitmap.Size);
                }
                catch
                {
                    throw;
                }
            }

            try
            {
                bitmap.Save(fileName, ImageFormat.Png);
            }
            catch
            {
                throw;
            }

            if (!requirePreview)
            {
                try
                {
                    bitmap.Dispose();
                }
                catch
                {
                }

                bitmap = null;
            }

            return bitmap;
        }

        private static Image captureByHandle(IntPtr handle, string fileName, bool requirePreview)
        {
            RECT rect;

            if (!User32.GetWindowRect(handle, out rect))
            {
                throw new IOException("ウィンドウ サイズが取得できません。");
            }

            Bitmap bitmap;

            try
            {
                bitmap = new Bitmap((rect.Right - rect.Left), (rect.Bottom - rect.Top));
            }
            catch
            {
                throw;
            }

            using (Graphics graphicsSource = Graphics.FromHwnd(handle))
            using (Graphics graphicsDest = Graphics.FromImage(bitmap))
            {
                try
                {
                    IntPtr source = graphicsSource.GetHdc();
                    IntPtr dest = graphicsDest.GetHdc();

                    try
                    {
                        if (!Gdi32.BitBlt(dest, 0, 0, bitmap.Width, bitmap.Height, source, 0, 0, WinGdi.SRCCOPY))
                        {
                            throw new IOException();
                        }
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        graphicsSource.ReleaseHdc(source);
                        graphicsDest.ReleaseHdc(dest);
                    }
                }
                catch
                {
                    throw;
                }
            }

            try
            {
                bitmap.Save(fileName, ImageFormat.Png);
            }
            catch
            {
                throw;
            }

            if (!requirePreview)
            {
                try
                {
                    bitmap.Dispose();
                }
                catch
                {
                }

                bitmap = null;
            }

            return bitmap;
        }

        private static Image captureByPrintWindow(IntPtr handle, string fileName, bool requirePreview)
        {
            RECT rect;

            if (!User32.GetWindowRect(handle, out rect))
            {
                throw new IOException("ウィンドウ サイズが取得できません。");
            }

            Bitmap bitmap;

            try
            {
                bitmap = new Bitmap((rect.Right - rect.Left), (rect.Bottom - rect.Top));
            }
            catch
            {
                throw;
            }

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                try
                {
                    IntPtr dc = graphics.GetHdc();

                    try
                    {
                        User32.PrintWindow(handle, dc, 0);
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        graphics.ReleaseHdc(dc);
                    }
                }
                catch
                {
                    throw;
                }
            }

            try
            {
                bitmap.Save(fileName, ImageFormat.Png);
            }
            catch
            {
                throw;
            }

            if (!requirePreview)
            {
                try
                {
                    bitmap.Dispose();
                }
                catch
                {
                }

                bitmap = null;
            }

            return bitmap;
        }

        #endregion
    }
}
