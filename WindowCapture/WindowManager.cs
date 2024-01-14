using NativeMethods;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowCapture
{
    public static class WindowManager
    {
        #region Private Fields

        private static bool allowEmptyTitle = false;

        #endregion

        #region Public Methods

        public static WindowData[] GetWindows(bool allowEmptyTitle = false)
        {
            WindowManager.allowEmptyTitle = allowEmptyTitle;
            var result = new List<WindowData>();
            GCHandle listHandle = GCHandle.Alloc(result);

            try
            {
                var wndEnumProc = new WNDENUMPROC(EnumWindow);
                User32.EnumWindows(wndEnumProc, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                if (listHandle.IsAllocated)
                {
                    listHandle.Free();
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Private Methods

        private static bool EnumWindow(IntPtr hWnd, IntPtr lParam)
        {
            GCHandle gch = GCHandle.FromIntPtr(lParam);
            List<WindowData> list;

            try
            {
                list = (List<WindowData>)(gch.Target);
            }
            catch
            {
                throw;
            }

            var builder = new StringBuilder(byte.MaxValue);
            string windowName = string.Empty;

            if (User32.GetWindowText(hWnd, builder, builder.Capacity) > 0)
            {
                windowName = builder.ToString();
            }
            else if (allowEmptyTitle)
            {
                if (User32.GetClassName(hWnd, builder, builder.Capacity) > 0)
                {
                    windowName = string.Format("[{0}]", builder.ToString());
                }
            }

            if (!string.IsNullOrEmpty(windowName))
            {
                list.Add(new WindowData(hWnd, windowName));
            }

            return true;
        }

        #endregion
    }
}
