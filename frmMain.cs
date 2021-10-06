using System;
using System.Security.Principal;
using System.Windows.Forms;


namespace admin_center

{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
            // check if administrator
            bool IsAdministrator = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (IsAdministrator) Text = "Administrator: " + ProductName.ToString();

            OperatingSystem os = Environment.OSVersion;
            //statusLabel.Text = os.VersionString;
            statusLabel.Text = string.Format("© {0}  ver. {1}",
                Application.CompanyName,
                Application.ProductVersion);
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

        private void AppButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.APPWIZ);
        }

        private void MsconfigButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.MSCONFIG);
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WbadButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.WBADMIN);
        }
    }
}
