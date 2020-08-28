using System.Diagnostics;

namespace WindowCapture
{
    public class WindowData
    {
        #region Public Properties

        public string MainWindowTitle
        {
            get;
        }

        public Process Process
        {
            get;
        }

        #endregion

        #region Public Methods

        public WindowData(Process process)
        {
            MainWindowTitle = process.MainWindowTitle;
            Process = process;
        }

        public override string ToString()
        {
            return MainWindowTitle;
        }

        #endregion
    }
}
