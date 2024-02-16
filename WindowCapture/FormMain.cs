using NativeMethods;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowCapture
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private readonly FormPreview formPreview;
        private readonly List<ListViewItem> items = new List<ListViewItem>();
        private readonly SelectDirectoryDialog selectDirectoryDialog;

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
            selectDirectoryDialog = new SelectDirectoryDialog(true);
        }

        #endregion

        #region Private Methods

        private void DoCapture()
        {
            ListView.SelectedListViewItemCollection selectedItems = listViewWindows.SelectedItems;

            if (selectedItems.Count < 0)
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
                Image image = MainEngine.Capture((MainEngine.Mode)comboBoxMode.SelectedItem, (selectedItems[0].Tag as WindowData).Handle, fileName, requirePreview);

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
                ShowErrorMessage(exception.Message);
            }
        }

        private void DoRefresh()
        {
            listViewWindows.SmallImageList.Images.Clear();
            items.Clear();
            
            foreach (WindowData windowData in WindowManager.GetWindows().OrderBy(n => n.ToString()))
            {
                items.Add(ToListViewItem(windowData));
            }

            FilterVisible();
        }

        private void FilterVisible()
        {
            bool visibleOnly = checkBoxVisible.Checked;
            listViewWindows.Items.Clear();
            listViewWindows.BeginUpdate();

            try
            {
                foreach (ListViewItem item in items)
                {
                    if (!visibleOnly || ((WindowData)item.Tag).Visible)
                    {
                        listViewWindows.Items.Add(item);
                    }
                }

                listViewWindows.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            finally
            {
                listViewWindows.EndUpdate();
            }
        }

        private void ShowErrorMessage(string message)
        {
            ShowMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowMessage(string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            return MessageBox.Show(this, message, Text, messageBoxButtons, messageBoxIcon);
        }

        private ListViewItem ToListViewItem(WindowData windowData)
        {
            ImageList imageList = listViewWindows.SmallImageList;
            ListViewItem result = null;
            string title = windowData.Title;
            IntPtr hIcon = User32.GetClassLongPtr(windowData.Handle, GCL.HICONSM);

            if (hIcon != IntPtr.Zero)
            {
                try
                {
                    imageList.Images.Add(Icon.FromHandle(hIcon));
                    result = new ListViewItem(title, (imageList.Images.Count - 1));
                }
                catch
                {
                }
            }

            if (result == null)
            {
                result = new ListViewItem(title);
            }

            result.Tag = windowData;
            return result;
        }

        #endregion

        // Designer Methods

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            selectDirectoryDialog.DirectoryName = comboBoxOutputDirectory.Text;

            if (selectDirectoryDialog.ShowDialog() != DialogResult.OK) return;

            comboBoxOutputDirectory.Text = selectDirectoryDialog.DirectoryName;
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            DoCapture();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DoRefresh();
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            FilterVisible();
        }

        private void comboBoxOutputDirectory_DragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetData(DataFormats.FileDrop) is string[] dropData) || (dropData.Length < 1))
            {
                return;
            }

            (sender as ComboBox).Text = dropData[0];
        }

        private void comboBoxOutputDirectory_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect
                = (e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.All
                : DragDropEffects.None);
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            selectDirectoryDialog.Dispose();
        }

        private void load(object sender, EventArgs e)
        {
            DoRefresh();
            comboBoxOutputDirectory.Text = Application.StartupPath;
        }
    }
}
