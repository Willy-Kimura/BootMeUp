namespace Tests
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bootMeUp1 = new WK.Libraries.BootMeUpNS.BootMeUp(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bootMeUp1
            // 
            this.bootMeUp1.BootArea = WK.Libraries.BootMeUpNS.BootMeUp.BootAreas.Registry;
            this.bootMeUp1.ContainerControl = this;
            this.bootMeUp1.Enabled = true;
            this.bootMeUp1.ParentForm = this;
            this.bootMeUp1.RunWhenDebugging = false;
            this.bootMeUp1.ShortcutOptions.Arguments = null;
            this.bootMeUp1.ShortcutOptions.Hotkey = System.Windows.Forms.Keys.None;
            this.bootMeUp1.Successful = false;
            this.bootMeUp1.Tag = null;
            this.bootMeUp1.TargetUser = WK.Libraries.BootMeUpNS.BootMeUp.TargetUsers.CurrentUser;
            this.bootMeUp1.UseAlternativeOnFail = true;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(655, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BootMeUp: Tests";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private WK.Libraries.BootMeUpNS.BootMeUp bootMeUp1;
        private System.Windows.Forms.Button button2;
    }
}

