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
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.grpLibrarySettings = new System.Windows.Forms.GroupBox();
            this.grpObservableFormats = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBootAreas = new System.Windows.Forms.ComboBox();
            this.cboTargetUsers = new System.Windows.Forms.ComboBox();
            this.lblObservableImagesDesc = new System.Windows.Forms.Label();
            this.chkUseAlternativeOnFail = new System.Windows.Forms.CheckBox();
            this.lblObservableTextsDesc = new System.Windows.Forms.Label();
            this.chkEnableBooting = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bootMeUp1 = new WK.Libraries.BootMeUpNS.BootMeUp(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLibrarySettings.SuspendLayout();
            this.grpObservableFormats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblOptions);
            this.panel1.Controls.Add(this.grpLibrarySettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 501);
            this.panel1.TabIndex = 5;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(302, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(32, 31);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "?";
            this.toolTip1.SetToolTip(this.btnAbout, "About BootMeUp");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
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
            this.lblOptions.Location = new System.Drawing.Point(183, 13);
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
            this.grpLibrarySettings.Size = new System.Drawing.Size(289, 422);
            this.grpLibrarySettings.TabIndex = 5;
            this.grpLibrarySettings.TabStop = false;
            this.grpLibrarySettings.Text = "Change library settings";
            // 
            // grpObservableFormats
            // 
            this.grpObservableFormats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpObservableFormats.Controls.Add(this.label3);
            this.grpObservableFormats.Controls.Add(this.label4);
            this.grpObservableFormats.Controls.Add(this.label2);
            this.grpObservableFormats.Controls.Add(this.label1);
            this.grpObservableFormats.Controls.Add(this.cboBootAreas);
            this.grpObservableFormats.Controls.Add(this.cboTargetUsers);
            this.grpObservableFormats.Controls.Add(this.lblObservableImagesDesc);
            this.grpObservableFormats.Controls.Add(this.chkUseAlternativeOnFail);
            this.grpObservableFormats.Controls.Add(this.lblObservableTextsDesc);
            this.grpObservableFormats.Controls.Add(this.chkEnableBooting);
            this.grpObservableFormats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObservableFormats.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpObservableFormats.Location = new System.Drawing.Point(17, 28);
            this.grpObservableFormats.Name = "grpObservableFormats";
            this.grpObservableFormats.Size = new System.Drawing.Size(256, 380);
            this.grpObservableFormats.TabIndex = 6;
            this.grpObservableFormats.TabStop = false;
            this.grpObservableFormats.Text = "Booting options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Specify the target user to register with...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Target User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(17, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Specify the boot area to register in...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Boot Area";
            // 
            // cboBootAreas
            // 
            this.cboBootAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBootAreas.ForeColor = System.Drawing.Color.Black;
            this.cboBootAreas.FormattingEnabled = true;
            this.cboBootAreas.Items.AddRange(new object[] {
            "Registry",
            "Startup Folder"});
            this.cboBootAreas.Location = new System.Drawing.Point(17, 265);
            this.cboBootAreas.Name = "cboBootAreas";
            this.cboBootAreas.Size = new System.Drawing.Size(222, 23);
            this.cboBootAreas.TabIndex = 11;
            this.cboBootAreas.Text = "Registry";
            this.cboBootAreas.SelectedIndexChanged += new System.EventHandler(this.CboBootAreas_SelectedIndexChanged);
            // 
            // cboTargetUsers
            // 
            this.cboTargetUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTargetUsers.ForeColor = System.Drawing.Color.Black;
            this.cboTargetUsers.FormattingEnabled = true;
            this.cboTargetUsers.Items.AddRange(new object[] {
            "Current User",
            "All Users"});
            this.cboTargetUsers.Location = new System.Drawing.Point(17, 339);
            this.cboTargetUsers.Name = "cboTargetUsers";
            this.cboTargetUsers.Size = new System.Drawing.Size(222, 23);
            this.cboTargetUsers.TabIndex = 10;
            this.cboTargetUsers.Text = "Current User";
            this.cboTargetUsers.SelectedIndexChanged += new System.EventHandler(this.CboTargetUsers_SelectedIndexChanged);
            // 
            // lblObservableImagesDesc
            // 
            this.lblObservableImagesDesc.AutoSize = true;
            this.lblObservableImagesDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservableImagesDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblObservableImagesDesc.Location = new System.Drawing.Point(33, 148);
            this.lblObservableImagesDesc.Name = "lblObservableImagesDesc";
            this.lblObservableImagesDesc.Size = new System.Drawing.Size(179, 60);
            this.lblObservableImagesDesc.TabIndex = 9;
            this.lblObservableImagesDesc.Text = "When set to true, the alternative \r\nbooting area will be used when \r\nthe default " +
    "booting area fails in \r\nregistering the application.";
            // 
            // chkUseAlternativeOnFail
            // 
            this.chkUseAlternativeOnFail.AutoSize = true;
            this.chkUseAlternativeOnFail.Checked = true;
            this.chkUseAlternativeOnFail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseAlternativeOnFail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkUseAlternativeOnFail.ForeColor = System.Drawing.Color.Black;
            this.chkUseAlternativeOnFail.Location = new System.Drawing.Point(17, 127);
            this.chkUseAlternativeOnFail.Name = "chkUseAlternativeOnFail";
            this.chkUseAlternativeOnFail.Size = new System.Drawing.Size(164, 21);
            this.chkUseAlternativeOnFail.TabIndex = 8;
            this.chkUseAlternativeOnFail.Text = "Use alternative on fail?";
            this.chkUseAlternativeOnFail.UseVisualStyleBackColor = true;
            this.chkUseAlternativeOnFail.CheckedChanged += new System.EventHandler(this.ChkUseAlternativeOnFail_CheckedChanged);
            // 
            // lblObservableTextsDesc
            // 
            this.lblObservableTextsDesc.AutoSize = true;
            this.lblObservableTextsDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservableTextsDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblObservableTextsDesc.Location = new System.Drawing.Point(33, 54);
            this.lblObservableTextsDesc.Name = "lblObservableTextsDesc";
            this.lblObservableTextsDesc.Size = new System.Drawing.Size(181, 60);
            this.lblObservableTextsDesc.TabIndex = 7;
            this.lblObservableTextsDesc.Text = "Enable automatic booting of the \r\napplication? When unchecked, \r\nthe application " +
    "will be removed \r\nfrom the default registry area.";
            // 
            // chkEnableBooting
            // 
            this.chkEnableBooting.AutoSize = true;
            this.chkEnableBooting.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkEnableBooting.ForeColor = System.Drawing.Color.Black;
            this.chkEnableBooting.Location = new System.Drawing.Point(17, 33);
            this.chkEnableBooting.Name = "chkEnableBooting";
            this.chkEnableBooting.Size = new System.Drawing.Size(125, 21);
            this.chkEnableBooting.TabIndex = 1;
            this.chkEnableBooting.Text = "Enable booting?";
            this.chkEnableBooting.UseVisualStyleBackColor = true;
            this.chkEnableBooting.CheckedChanged += new System.EventHandler(this.ChkEnableBooting_CheckedChanged);
            // 
            // bootMeUp1
            // 
            this.bootMeUp1.BootArea = WK.Libraries.BootMeUpNS.BootMeUp.BootAreas.Registry;
            this.bootMeUp1.ContainerControl = this;
            this.bootMeUp1.Enabled = false;
            this.bootMeUp1.Exception = ((System.Exception)(resources.GetObject("bootMeUp1.Exception")));
            this.bootMeUp1.ParentForm = this;
            this.bootMeUp1.RunWhenDebugging = false;
            this.bootMeUp1.Tag = null;
            this.bootMeUp1.TargetUser = WK.Libraries.BootMeUpNS.BootMeUp.TargetUsers.CurrentUser;
            this.bootMeUp1.UseAlternativeOnFail = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 501);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BootMeUp: Tests";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLibrarySettings.ResumeLayout(false);
            this.grpObservableFormats.ResumeLayout(false);
            this.grpObservableFormats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WK.Libraries.BootMeUpNS.BootMeUp bootMeUp1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.GroupBox grpLibrarySettings;
        private System.Windows.Forms.GroupBox grpObservableFormats;
        private System.Windows.Forms.Label lblObservableImagesDesc;
        private System.Windows.Forms.CheckBox chkUseAlternativeOnFail;
        private System.Windows.Forms.Label lblObservableTextsDesc;
        private System.Windows.Forms.CheckBox chkEnableBooting;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboBootAreas;
        private System.Windows.Forms.ComboBox cboTargetUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

