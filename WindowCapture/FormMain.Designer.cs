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
            this.labelWindows = new System.Windows.Forms.Label();
            this.listBoxWindows = new System.Windows.Forms.ListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelOutputDirectory = new System.Windows.Forms.Label();
            this.comboBoxOutputDirectory = new System.Windows.Forms.ComboBox();
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
            // listBoxWindows
            // 
            this.listBoxWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWindows.FormattingEnabled = true;
            this.listBoxWindows.ItemHeight = 12;
            this.listBoxWindows.Location = new System.Drawing.Point(12, 24);
            this.listBoxWindows.Name = "listBoxWindows";
            this.listBoxWindows.Size = new System.Drawing.Size(695, 352);
            this.listBoxWindows.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(713, 24);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "&Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelOutputDirectory
            // 
            this.labelOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutputDirectory.AutoSize = true;
            this.labelOutputDirectory.Location = new System.Drawing.Point(12, 392);
            this.labelOutputDirectory.Name = "labelOutputDirectory";
            this.labelOutputDirectory.Size = new System.Drawing.Size(92, 12);
            this.labelOutputDirectory.TabIndex = 4;
            this.labelOutputDirectory.Text = "Output &Directory:";
            // 
            // comboBoxOutputDirectory
            // 
            this.comboBoxOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOutputDirectory.FormattingEnabled = true;
            this.comboBoxOutputDirectory.Location = new System.Drawing.Point(108, 389);
            this.comboBoxOutputDirectory.Name = "comboBoxOutputDirectory";
            this.comboBoxOutputDirectory.Size = new System.Drawing.Size(680, 20);
            this.comboBoxOutputDirectory.TabIndex = 5;
            // 
            // labelMode
            // 
            this.labelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(12, 418);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(34, 12);
            this.labelMode.TabIndex = 6;
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
            this.comboBoxMode.TabIndex = 7;
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(235, 418);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(86, 12);
            this.labelPreview.TabIndex = 8;
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
            this.numericUpDownPreviewTime.TabIndex = 9;
            this.numericUpDownPreviewTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCapture.Location = new System.Drawing.Point(713, 415);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(75, 23);
            this.buttonCapture.TabIndex = 10;
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
            this.Controls.Add(this.comboBoxOutputDirectory);
            this.Controls.Add(this.labelOutputDirectory);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listBoxWindows);
            this.Controls.Add(this.labelWindows);
            this.Name = "FormMain";
            this.Text = "Window Capture";
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreviewTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWindows;
        private System.Windows.Forms.ListBox listBoxWindows;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelOutputDirectory;
        private System.Windows.Forms.ComboBox comboBoxOutputDirectory;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.NumericUpDown numericUpDownPreviewTime;
        private System.Windows.Forms.Button buttonCapture;
    }
}

