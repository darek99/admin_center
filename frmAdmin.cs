using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace admin_center
{
    public partial class FrmAdmin : Form
    {
        /// <summary>
        /// handle class Admin
        /// </summary>
        private readonly Admin admin = new Admin();

        public FrmAdmin()
        {
            InitializeComponent();

            /// <summary>
            /// Event when command execution failed and exception was thrown
            /// </summary>
            admin.CommandExecuteException += OnExcceptionRaised;
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = $"Copyright © {Application.CompanyName}\nWersja {Application.ProductVersion}";

            _ = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand(admin.appwiz);
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand(admin.appwiz);
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand("cmd.exe");
        }

        private void Compmgmt_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand("compmgmt.msc");
        }

        private void Diskmgmt_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand("diskmgmt.msc");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand(admin.eventvwr);
        }

        private void Firewall_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand("firewall.cpl");
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            // caption information is set wheather user is an admin or not
            Text = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
                ? $"Administrator: {Application.ProductName}"
                : $"{WindowsIdentity.GetCurrent().User.Value}: {Application.ProductName}";

            // show me application version in the status bar
            label_ver.Text = $"ver.{Application.ProductVersion}";
        }

        private void MsconfigButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand(admin.msconfig);
        }

        private void Msinfo_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand("msinfo32.exe");
        }

        private void OnExcceptionRaised(Exception obj)
        {
            _ = MessageBox.Show(obj.Message);
        }

        private void ShadowsButton_Click(object sender, EventArgs e)
        {
            string command = " /c vssadmin delete shadows /all /quiet & pause";
            admin.ExecuteCommand(command, true);
        }

        private void TaskschedButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand(admin.taskschd);
        }

        private void UpdateLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin.ExecuteCommand(admin.update2);
            Application.Exit();
        }

        private void WbadButton_Click(object sender, EventArgs e)
        {
            admin.ExecuteCommand(admin.wbadmin);
        }

        private void WbCleanButton_Click(object sender, EventArgs e)
        {
            string command = $" /c wbadmin delete backup -keepversions:{numUpDown.Value} & pause";
            admin.ExecuteCommand(command, true);
        }
    }
}