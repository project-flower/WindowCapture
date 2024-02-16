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

        public bool Visible
        {
            get;
        }

        #endregion

        #region Public Methods

        public WindowData(IntPtr handle, string title, bool visible)
        {
            Handle = handle;
            Title = title;
            Visible = visible;
        }

        public override string ToString()
        {
            return Title;
        }

        #endregion
    }
}
