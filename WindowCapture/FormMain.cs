using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowCapture
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private FormPreview formPreview;

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            MinimumSize = Size;
            comboBoxMode.Items.Add(MainEngine.Mode.CopyFromScreen);
            comboBoxMode.Items.Add(MainEngine.Mode.PrintWindow);
            comboBoxMode.SelectedIndex = 0;
            formPreview = new FormPreview();
        }

        #endregion

        #region Private Methods

        private void capture()
        {
            if (listBoxWindows.SelectedIndex < 0)
            {
                return;
            }

            DateTime currentTime = DateTime.Now;
            string fileName = string.Format("{0:d4}{1:d2}{2:d2}{3:d2}{4:d2}{5:d2}.png",
                currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);

            try
            {
                string directoryName = comboBoxOutputDirectory.Text;

                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }

                fileName = Path.Combine(directoryName, fileName);
                int previewInterval = (int)numericUpDownPreviewTime.Value;
                bool requirePreview = (previewInterval > 0);
                Image image = MainEngine.Capture((MainEngine.Mode)comboBoxMode.SelectedItem, (listBoxWindows.SelectedItem as WindowData).Handle, fileName, requirePreview);

                if (requirePreview)
                {
                    if (image != null)
                    {
                        formPreview.Show(this, image, previewInterval);
                    }
                }
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
        }

        private void refresh()
        {
            listBoxWindows.Items.Clear();
            WindowData[] windows = WindowManager.GetWindows();
            listBoxWindows.Items.Clear();
            windows = windows.OrderBy(n => n.ToString()).ToArray();
            Array.ForEach(windows, n => listBoxWindows.Items.Add(n));
        }

        void showErrorMessage(string message)
        {
            showMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        DialogResult showMessage(string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            return MessageBox.Show(this, message, Text, messageBoxButtons, messageBoxIcon);
        }

        #endregion

        // Designer Methods

        private void buttonCapture_Click(object sender, System.EventArgs e)
        {
            capture();
        }

        private void buttonRefresh_Click(object sender, System.EventArgs e)
        {
            refresh();
        }

        private void load(object sender, System.EventArgs e)
        {
            refresh();
            comboBoxOutputDirectory.Text = Application.StartupPath;
        }
    }
}
