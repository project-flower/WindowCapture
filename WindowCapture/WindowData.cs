using System.Diagnostics;

namespace WindowCapture
{
    public class WindowData
    {
        public string MainWindowTitle
        {
            get;
        }

        public Process Process
        {
            get;
        }

        public WindowData(Process process)
        {
            MainWindowTitle = process.MainWindowTitle;
            Process = process;
        }

        public override string ToString()
        {
            return MainWindowTitle;
        }
    }
}
