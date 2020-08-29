using System;

namespace WindowCapture
{
    public class WindowData
    {
        #region Public Properties

        public IntPtr Handle
        {
            get;
        }

        public string Title
        {
            get;
        }

        #endregion

        #region Public Methods

        public WindowData(IntPtr handle, string title)
        {
            Handle = handle;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }

        #endregion
    }
}
