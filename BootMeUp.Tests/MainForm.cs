using System;
using System.Windows.Forms;

using WK.Libraries.BootMeUpNS;

namespace Tests
{
    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Fields

        private bool _loaded = false;

        #endregion

        #region Methods

        public void Reset()
        {
            if (bootMeUp1.Enabled)
                bootMeUp1.Register();
        }

        #endregion

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            chkEnableBooting.Checked = bootMeUp1.Enabled;

            _loaded = true;
        }

        private void ChkEnableBooting_CheckedChanged(object sender, EventArgs e)
        {
            if (_loaded)
            {
                bootMeUp1.RunWhenDebugging = true;
                bootMeUp1.Enabled = chkEnableBooting.Checked;
                
                if (bootMeUp1.Successful)
                {
                    if (_loaded)
                        MessageBox.Show("Success!");
                }
                else
                {
                    if (_loaded)
                        MessageBox.Show($"Something happened:\n " +
                                        $"{bootMeUp1.Exception.Message}");
                }
            }
        }

        private void ChkUseAlternativeOnFail_CheckedChanged(object sender, EventArgs e)
        {
            bootMeUp1.UseAlternativeOnFail = chkUseAlternativeOnFail.Checked;

            Reset();
        }

        private void CboBootAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBootAreas.SelectedIndex == 0)
                bootMeUp1.BootArea = BootMeUp.BootAreas.Registry;
            else if (cboBootAreas.SelectedIndex == 1)
                bootMeUp1.BootArea = BootMeUp.BootAreas.StartupFolder;

            Reset();
        }

        private void CboTargetUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTargetUsers.SelectedIndex == 0)
                bootMeUp1.TargetUser = BootMeUp.TargetUsers.CurrentUser;
            else if (cboBootAreas.SelectedIndex == 1)
                bootMeUp1.TargetUser = BootMeUp.TargetUsers.AllUsers;

            Reset();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BootMeUp is a .NET library that enables automatic startups for " +
                            "applications at system boot-time while providing additional " +
                            "startup management options.\n\n" +
                            "Copyright © 2019, Willy Kimura.", "About BootMeUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
