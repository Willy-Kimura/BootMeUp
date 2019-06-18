using System;
using System.Windows.Forms;

using WK.Libraries.BootMeUpNS;

namespace Tests
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bootMeUp1.Successful)
                MessageBox.Show("Success!");
            else
                MessageBox.Show($"Unsuccessful: {bootMeUp1.Exception.Message}");


            // var bootMeUp = new BootMeUp();
            // 
            // bootMeUp.UseAlternativeOnFail = true;
            // bootMeUp.BootArea = BootMeUp.BootAreas.Registry;
            // bootMeUp.TargetUser = BootMeUp.TargetUsers.CurrentUser;
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
    }
}
