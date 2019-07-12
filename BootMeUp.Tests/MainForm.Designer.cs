namespace Tests
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.grpLibrarySettings = new System.Windows.Forms.GroupBox();
            this.grpObservableFormats = new System.Windows.Forms.GroupBox();
            this.lblObservableFilesDesc = new System.Windows.Forms.Label();
            this.chkObserveFiles = new System.Windows.Forms.CheckBox();
            this.lblObservableImagesDesc = new System.Windows.Forms.Label();
            this.chkObserveImages = new System.Windows.Forms.CheckBox();
            this.lblObservableTextsDesc = new System.Windows.Forms.Label();
            this.chkObserveTexts = new System.Windows.Forms.CheckBox();
            this.chkEnableBooting = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bootMeUp1 = new WK.Libraries.BootMeUpNS.BootMeUp(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLibrarySettings.SuspendLayout();
            this.grpObservableFormats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblOptions);
            this.panel1.Controls.Add(this.grpLibrarySettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 379);
            this.panel1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(76, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "BootMeUp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblOptions.ForeColor = System.Drawing.Color.Black;
            this.lblOptions.Location = new System.Drawing.Point(184, 13);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(86, 30);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Options";
            // 
            // grpLibrarySettings
            // 
            this.grpLibrarySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLibrarySettings.Controls.Add(this.grpObservableFormats);
            this.grpLibrarySettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLibrarySettings.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpLibrarySettings.Location = new System.Drawing.Point(26, 57);
            this.grpLibrarySettings.Name = "grpLibrarySettings";
            this.grpLibrarySettings.Size = new System.Drawing.Size(261, 309);
            this.grpLibrarySettings.TabIndex = 5;
            this.grpLibrarySettings.TabStop = false;
            this.grpLibrarySettings.Text = "Change library settings";
            // 
            // grpObservableFormats
            // 
            this.grpObservableFormats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpObservableFormats.Controls.Add(this.lblObservableFilesDesc);
            this.grpObservableFormats.Controls.Add(this.chkObserveFiles);
            this.grpObservableFormats.Controls.Add(this.lblObservableImagesDesc);
            this.grpObservableFormats.Controls.Add(this.chkObserveImages);
            this.grpObservableFormats.Controls.Add(this.lblObservableTextsDesc);
            this.grpObservableFormats.Controls.Add(this.chkObserveTexts);
            this.grpObservableFormats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObservableFormats.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpObservableFormats.Location = new System.Drawing.Point(17, 74);
            this.grpObservableFormats.Name = "grpObservableFormats";
            this.grpObservableFormats.Size = new System.Drawing.Size(229, 220);
            this.grpObservableFormats.TabIndex = 6;
            this.grpObservableFormats.TabStop = false;
            this.grpObservableFormats.Text = "Booting options";
            // 
            // lblObservableFilesDesc
            // 
            this.lblObservableFilesDesc.AutoSize = true;
            this.lblObservableFilesDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservableFilesDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblObservableFilesDesc.Location = new System.Drawing.Point(33, 184);
            this.lblObservableFilesDesc.Name = "lblObservableFilesDesc";
            this.lblObservableFilesDesc.Size = new System.Drawing.Size(176, 30);
            this.lblObservableFilesDesc.TabIndex = 11;
            this.lblObservableFilesDesc.Text = "Monitors any files/directories \r\nthat are copied to the clipboard.";
            // 
            // chkObserveFiles
            // 
            this.chkObserveFiles.AutoSize = true;
            this.chkObserveFiles.Checked = true;
            this.chkObserveFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObserveFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkObserveFiles.ForeColor = System.Drawing.Color.Black;
            this.chkObserveFiles.Location = new System.Drawing.Point(17, 163);
            this.chkObserveFiles.Name = "chkObserveFiles";
            this.chkObserveFiles.Size = new System.Drawing.Size(53, 21);
            this.chkObserveFiles.TabIndex = 10;
            this.chkObserveFiles.Text = "Files";
            this.chkObserveFiles.UseVisualStyleBackColor = true;
            // 
            // lblObservableImagesDesc
            // 
            this.lblObservableImagesDesc.AutoSize = true;
            this.lblObservableImagesDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservableImagesDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblObservableImagesDesc.Location = new System.Drawing.Point(33, 120);
            this.lblObservableImagesDesc.Name = "lblObservableImagesDesc";
            this.lblObservableImagesDesc.Size = new System.Drawing.Size(164, 30);
            this.lblObservableImagesDesc.TabIndex = 9;
            this.lblObservableImagesDesc.Text = "Monitors any images that are \r\ncopied to the clipboard.";
            // 
            // chkObserveImages
            // 
            this.chkObserveImages.AutoSize = true;
            this.chkObserveImages.Checked = true;
            this.chkObserveImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObserveImages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkObserveImages.ForeColor = System.Drawing.Color.Black;
            this.chkObserveImages.Location = new System.Drawing.Point(17, 99);
            this.chkObserveImages.Name = "chkObserveImages";
            this.chkObserveImages.Size = new System.Drawing.Size(71, 21);
            this.chkObserveImages.TabIndex = 8;
            this.chkObserveImages.Text = "Images";
            this.chkObserveImages.UseVisualStyleBackColor = true;
            // 
            // lblObservableTextsDesc
            // 
            this.lblObservableTextsDesc.AutoSize = true;
            this.lblObservableTextsDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservableTextsDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblObservableTextsDesc.Location = new System.Drawing.Point(33, 54);
            this.lblObservableTextsDesc.Name = "lblObservableTextsDesc";
            this.lblObservableTextsDesc.Size = new System.Drawing.Size(151, 30);
            this.lblObservableTextsDesc.TabIndex = 7;
            this.lblObservableTextsDesc.Text = "Monitors any texts that are \r\ncopied to the clipboard.";
            // 
            // chkObserveTexts
            // 
            this.chkObserveTexts.AutoSize = true;
            this.chkObserveTexts.Checked = true;
            this.chkObserveTexts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObserveTexts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkObserveTexts.ForeColor = System.Drawing.Color.Black;
            this.chkObserveTexts.Location = new System.Drawing.Point(17, 33);
            this.chkObserveTexts.Name = "chkObserveTexts";
            this.chkObserveTexts.Size = new System.Drawing.Size(58, 21);
            this.chkObserveTexts.TabIndex = 1;
            this.chkObserveTexts.Text = "Texts";
            this.chkObserveTexts.UseVisualStyleBackColor = true;
            // 
            // chkEnableBooting
            // 
            this.chkEnableBooting.AutoSize = true;
            this.chkEnableBooting.Checked = true;
            this.chkEnableBooting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableBooting.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkEnableBooting.ForeColor = System.Drawing.Color.Black;
            this.chkEnableBooting.Location = new System.Drawing.Point(18, 31);
            this.chkEnableBooting.Name = "chkEnableBooting";
            this.chkEnableBooting.Size = new System.Drawing.Size(247, 21);
            this.chkEnableBooting.TabIndex = 1;
            this.chkEnableBooting.Text = "Enable Notes to automatically start?";
            this.chkEnableBooting.UseVisualStyleBackColor = true;
            this.chkEnableBooting.CheckedChanged += new System.EventHandler(this.ChkEnableBooting_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "When checked, Notes will automatically \r\nstart whenever Windows starts. You can \r" +
    "\nthen easily access it from the Tray area.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(442, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Options";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(379, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkEnableBooting);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(379, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 135);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booting options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bootMeUp1
            // 
            this.bootMeUp1.BootArea = WK.Libraries.BootMeUpNS.BootMeUp.BootAreas.StartupFolder;
            this.bootMeUp1.ContainerControl = this;
            this.bootMeUp1.Enabled = true;
            this.bootMeUp1.ParentForm = this;
            this.bootMeUp1.RunWhenDebugging = false;
            this.bootMeUp1.Successful = false;
            this.bootMeUp1.Tag = null;
            this.bootMeUp1.TargetUser = WK.Libraries.BootMeUpNS.BootMeUp.TargetUsers.CurrentUser;
            this.bootMeUp1.UseAlternativeOnFail = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BootMeUp: Tests";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLibrarySettings.ResumeLayout(false);
            this.grpObservableFormats.ResumeLayout(false);
            this.grpObservableFormats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WK.Libraries.BootMeUpNS.BootMeUp bootMeUp1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.GroupBox grpLibrarySettings;
        private System.Windows.Forms.GroupBox grpObservableFormats;
        private System.Windows.Forms.Label lblObservableFilesDesc;
        private System.Windows.Forms.CheckBox chkObserveFiles;
        private System.Windows.Forms.Label lblObservableImagesDesc;
        private System.Windows.Forms.CheckBox chkObserveImages;
        private System.Windows.Forms.Label lblObservableTextsDesc;
        private System.Windows.Forms.CheckBox chkObserveTexts;
        private System.Windows.Forms.CheckBox chkEnableBooting;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

