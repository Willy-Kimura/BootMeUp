using System;
using System.Windows.Forms;

using WK.Libraries.BootMeUpNS;

namespace Tests
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bootMeUp1.RunWhenDebugging = true;
            bootMeUp1.Enabled = true;

            if (bootMeUp1.Successful)
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show($"Failed: {bootMeUp1.Exception.Message}");
            }

            // var bootMeUp = new BootMeUp();
            // 
            // bootMeUp.UseAlternativeOnFail = true;
            // bootMeUp.BootArea = BootMeUp.BootAreas.StartupFolder;
            // bootMeUp.TargetUser = BootMeUp.TargetUsers.CurrentUser;
            // 
            // bootMeUp1.ShortcutOptions.Hotkey = Keys.Control & Keys.Alt & Keys.F2;
            // 
            // bootMeUp.Enabled = true;
            // 
            // if (bootMeUp.Successful)
            //     MessageBox.Show("Success!");
            // else
            //     MessageBox.Show($"Unsuccessful: {bootMeUp.Exception.Message}");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ChkEnableBooting_CheckedChanged(object sender, EventArgs e)
        {
            bootMeUp1.Enabled = chkEnableBooting.Checked;
        }
    }
}
