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
        private readonly Admin admin = new Admin();

        public FrmAdmin()
        {
            InitializeComponent();

            /// <summary>
            /// Event when command execution failed and exception was thrown
            /// </summary>
            admin.ExceptionRaised += OnExcceptionRaised;
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = string.Format("Copyright © {0}\nWersja {1}", Application.CompanyName, Application.ProductVersion);

            _ = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand(admin.APPWIZ);
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand(admin.APPWIZ);
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand("cmd.exe");
        }

        private void Compmgmt_Click(object sender, EventArgs e)
        {
            admin.RunCommand("compmgmt.msc");
        }

        private void Diskmgmt_Click(object sender, EventArgs e)
        {
            admin.RunCommand("diskmgmt.msc");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand(admin.EVENTVWR);
        }

        private void Firewall_Click(object sender, EventArgs e)
        {
            admin.RunCommand("firewall.cpl");
        }

        /// <summary>
        /// Set a few things on form in run time
        /// </summary>
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            // caption information is set wheather user is an admin or not

            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                Text = "Administrator: " + Application.ProductName;
            else
                Text = WindowsIdentity.GetCurrent().User.Value + ": " + Application.ProductName;

            // show me application version in the status bar

            label_ver.Text = string.Format("ver.{0}", Application.ProductVersion);
        }

        private void MsconfigButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand(admin.MSCONFIG);
        }

        private void Msinfo_Click(object sender, EventArgs e)
        {
            admin.RunCommand("msinfo32.exe");
        }

        private void OnExcceptionRaised(Exception obj)
        {
            _ = MessageBox.Show(obj.Message);
        }

        private void ShadowsButton_Click(object sender, EventArgs e)
        {
            string command = " /c vssadmin delete shadows /all /quiet & pause";
            admin.RunCommand(command, true);
        }

        private void TaskschedButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand(admin.TASKSCHD);
        }

        private void UpdateLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin.RunCommand(admin.UPDATE2);
            Application.Exit();
        }

        private void WbadButton_Click(object sender, EventArgs e)
        {
            admin.RunCommand(admin.WBADMIN);
        }
    }
}