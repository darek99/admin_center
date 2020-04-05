using System;
using System.Windows.Forms;

namespace admin_center

{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            OperatingSystem os = Environment.OSVersion;
            statusLabel.Text = os.VersionString;
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.CLEANMGR);
        }

        private void ShadowsButton_Click(object sender, EventArgs e)
        {
            AdminCenter.CleanShadows();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.EVENTVWR);
        }

        private void TaskschedButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.TASKSCHD);
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str_message = string.Format("Copyright © {0}\nWersja {1}", 
                Application.CompanyName,
                Application.ProductVersion);
            MessageBox.Show(str_message, Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
