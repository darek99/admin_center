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
        //private readonly Admin admin = new Admin();

        public FrmAdmin()
        {
            InitializeComponent();

            /// <summary>
            /// Event when command execution failed and exception was thrown
            /// </summary>

            Extension.CommandExecuteException += OnExcceptionRaised;
            //admin.CommandExecuteException += OnExcceptionRaised;
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = $"Copyright © {Application.CompanyName}\nWersja {Application.ProductVersion}";
            _ = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            //admin.ExecuteCommand(admin.appwiz);
            Admin.appwiz.ExecuteCommand();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            //admin.ExecuteCommand(admin.cleanmgr);
            Admin.cleanmgr.ExecuteCommand();
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            Admin.cmd.ExecuteCommand();
        }

        private void Compmgmt_Click(object sender, EventArgs e)
        {
            Admin.compmgmt.ExecuteCommand();
        }

        private void Diskmgmt_Click(object sender, EventArgs e)
        {
            Admin.diskmgmt.ExecuteCommand();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            Admin.eventvwr.ExecuteCommand();
        }

        private void Firewall_Click(object sender, EventArgs e)
        {
            Admin.firewall.ExecuteCommand();
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
            Admin.msconfig.ExecuteCommand();
        }

        private void Msinfo_Click(object sender, EventArgs e)
        {
            Admin.msinfo32.ExecuteCommand();
        }

        private void OnExcceptionRaised(Exception obj)
        {
            _ = MessageBox.Show(obj.Message);
        }

        private void ShadowsButton_Click(object sender, EventArgs e)
        {
            string command = " /c vssadmin delete shadows /all /quiet & pause";
            command.ExecuteCommand(true);
            //admin.ExecuteCommand(command, true);
        }

        private void TaskschedButton_Click(object sender, EventArgs e)
        {
            Admin.taskschd.ExecuteCommand();
        }

        private void WbadButton_Click(object sender, EventArgs e)
        {
            Admin.wbadmin.ExecuteCommand();
        }

        private void WbCleanButton_Click(object sender, EventArgs e)
        {
            string command = $" /c wbadmin delete backup -keepversions:{numUpDown.Value} & pause";
            command.ExecuteCommand(true);
            //admin.ExecuteCommand(command, true);
        }
    }
}