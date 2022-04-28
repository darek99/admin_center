using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace admin_center
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();

            /// <summary>
            /// Event when command execution failed and exception was thrown
            /// </summary>
            CommandExecute.ExecuteException += OnExecuteException;
        }

        private void OnExecuteException(Exception obj)
        {
            _ = MessageBox.Show(obj.Message);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            // caption information is set wheather user is admin or not

            Text = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
                ? $"Administrator: {Application.ProductName}"
                : $"{WindowsIdentity.GetCurrent().User.Value}: {Application.ProductName}";

            label_ver.Text = $"ver.{Application.ProductVersion}";
        }

        private void FrmAdmin_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string message = $"Copyright © {Application.CompanyName}\nWersja {Application.ProductVersion}";

            _ = MessageBox
                .Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            e.Cancel = true;
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            Commands.appwiz.Execute();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Commands.cleanmgr.Execute();
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            Commands.cmd_run.Execute();
        }

        private void Compmgmt_Click(object sender, EventArgs e)
        {
            Commands.compmgmt.Execute();
        }

        private void Diskmgmt_Click(object sender, EventArgs e)
        {
            Commands.diskmgmt.Execute();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            Commands.eventvwr.Execute();
        }

        private void Firewall_Click(object sender, EventArgs e)
        {
            Commands.firewall.Execute();
        }

        private void MsconfigButton_Click(object sender, EventArgs e)
        {
            Commands.msconfig.Execute();
        }

        private void Msinfo_Click(object sender, EventArgs e)
        {
            Commands.msinfo32.Execute();
        }

        private void ShadowsButton_Click(object sender, EventArgs e)
        {
            string command = " /c vssadmin delete shadows /all /quiet && pause";
            command.Execute(true);
        }

        private void TaskschedButton_Click(object sender, EventArgs e)
        {
            Commands.taskschd.Execute();
        }

        private void WbadButton_Click(object sender, EventArgs e)
        {
            Commands.wbadmin.Execute();
        }

        private void WbCleanButton_Click(object sender, EventArgs e)
        {
            string command = string.Format(Commands.wbadmin_delete, numUpDown.Value);
            command.Execute(true);
        }

        private void linkWmicList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Commands.wmic_list.Execute(true);
        }
    }
}