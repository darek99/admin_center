using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace admin_center

{
    public partial class FrmAdmin : Form
    {
        /// <summary>
        /// Obiekt klasy admin
        /// </summary>
        private readonly Admin admin;

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = string.Format("Copyright © {0}\nWersja {1}", Application.CompanyName, Application.ProductVersion);

            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand(admin.APPWIZ);
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand(admin.APPWIZ);
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand("cmd.exe");
        }

        private void Compmgmt_Click(object sender, EventArgs e)
        {
            admin.Runcommand("compmgmt.msc");
        }

        private void Diskmgmt_Click(object sender, EventArgs e)
        {
            admin.Runcommand("diskmgmt.msc");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand(admin.EVENTVWR);
        }

        private void Firewall_Click(object sender, EventArgs e)
        {
            admin.Runcommand("firewall.cpl");
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            // caption information is set wheather user is an admin or not
            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                Text = "Administrator: " + Application.ProductName;
            else
                Text = WindowsIdentity.GetCurrent().User.Value + ": " + Application.ProductName;

            // show me application version in the status bar
            label_ver.Text = "ver." + Application.ProductVersion;
        }

        private void MsconfigButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand(admin.MSCONFIG);
        }

        private void Msinfo_Click(object sender, EventArgs e)
        {
            admin.Runcommand("msinfo32.exe");
        }

        private void ShadowsButton_Click(object sender, EventArgs e)
        {
            string command = " /c vssadmin delete shadows /all /quiet & pause";
            admin.ExecuteCmdCommand(command);
        }

        private void TaskschedButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand(admin.TASKSCHD);
        }

        private void UpdateLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin.Runcommand(admin.UPDATE2);
            Application.Exit();
        }

        private void WbadButton_Click(object sender, EventArgs e)
        {
            admin.Runcommand(admin.WBADMIN);
        }
    }
}