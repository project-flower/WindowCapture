namespace WindowCapture
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWindows = new System.Windows.Forms.Label();
            this.listViewWindows = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelOutputDirectory = new System.Windows.Forms.Label();
            this.comboBoxOutputDirectory = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.labelPreview = new System.Windows.Forms.Label();
            this.numericUpDownPreviewTime = new System.Windows.Forms.NumericUpDown();
            this.buttonCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreviewTime)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWindows
            // 
            this.labelWindows.AutoSize = true;
            this.labelWindows.Location = new System.Drawing.Point(12, 9);
            this.labelWindows.Name = "labelWindows";
            this.labelWindows.Size = new System.Drawing.Size(43, 12);
            this.labelWindows.TabIndex = 0;
            this.labelWindows.Text = "&Window";
            // 
            // listViewWindows
            // 
            this.listViewWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle});
            this.listViewWindows.FullRowSelect = true;
            this.listViewWindows.HideSelection = false;
            this.listViewWindows.Location = new System.Drawing.Point(12, 24);
            this.listViewWindows.MultiSelect = false;
            this.listViewWindows.Name = "listViewWindows";
            this.listViewWindows.Size = new System.Drawing.Size(695, 336);
            this.listViewWindows.SmallImageList = this.imageList;
            this.listViewWindows.TabIndex = 1;
            this.listViewWindows.UseCompatibleStateImageBehavior = false;
            this.listViewWindows.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.Checked = global::WindowCapture.Properties.Settings.Default.VisibleOnly;
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowCapture.Properties.Settings.Default, "VisibleOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxVisible.Location = new System.Drawing.Point(12, 366);
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.Size = new System.Drawing.Size(86, 16);
            this.checkBoxVisible.TabIndex = 2;
            this.checkBoxVisible.Text = "&Visible Only";
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(713, 24);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "&Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelOutputDirectory
            // 
            this.labelOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutputDirectory.AutoSize = true;
            this.labelOutputDirectory.Location = new System.Drawing.Point(12, 391);
            this.labelOutputDirectory.Name = "labelOutputDirectory";
            this.labelOutputDirectory.Size = new System.Drawing.Size(92, 12);
            this.labelOutputDirectory.TabIndex = 4;
            this.labelOutputDirectory.Text = "Output &Directory:";
            // 
            // comboBoxOutputDirectory
            // 
            this.comboBoxOutputDirectory.AllowDrop = true;
            this.comboBoxOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOutputDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowCapture.Properties.Settings.Default, "OutputDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxOutputDirectory.FormattingEnabled = true;
            this.comboBoxOutputDirectory.Location = new System.Drawing.Point(110, 388);
            this.comboBoxOutputDirectory.Name = "comboBoxOutputDirectory";
            this.comboBoxOutputDirectory.Size = new System.Drawing.Size(599, 20);
            this.comboBoxOutputDirectory.TabIndex = 5;
            this.comboBoxOutputDirectory.Text = global::WindowCapture.Properties.Settings.Default.OutputDirectory;
            this.comboBoxOutputDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxOutputDirectory_DragDrop);
            this.comboBoxOutputDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxOutputDirectory_DragEnter);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(713, 386);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "&Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelMode
            // 
            this.labelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(12, 418);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(34, 12);
            this.labelMode.TabIndex = 7;
            this.labelMode.Text = "&Mode:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(108, 415);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMode.TabIndex = 8;
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(235, 418);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(86, 12);
            this.labelPreview.TabIndex = 9;
            this.labelPreview.Text = "&Preview (msec):";
            // 
            // numericUpDownPreviewTime
            // 
            this.numericUpDownPreviewTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPreviewTime.Location = new System.Drawing.Point(327, 416);
            this.numericUpDownPreviewTime.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownPreviewTime.Name = "numericUpDownPreviewTime";
            this.numericUpDownPreviewTime.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownPreviewTime.TabIndex = 10;
            this.numericUpDownPreviewTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCapture.Location = new System.Drawing.Point(713, 415);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(75, 23);
            this.buttonCapture.TabIndex = 11;
            this.buttonCapture.Text = "&Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.numericUpDownPreviewTime);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.comboBoxOutputDirectory);
            this.Controls.Add(this.labelOutputDirectory);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.checkBoxVisible);
            this.Controls.Add(this.listViewWindows);
            this.Controls.Add(this.labelWindows);
            this.Name = "FormMain";
            this.Text = "Window Capture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreviewTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWindows;
        private System.Windows.Forms.ListView listViewWindows;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelOutputDirectory;
        private System.Windows.Forms.ComboBox comboBoxOutputDirectory;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.NumericUpDown numericUpDownPreviewTime;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.ImageList imageList;
    }
}

