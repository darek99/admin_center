﻿using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace admin_center

{
    public partial class frmMain : Form
    {
        //AdminCenter adminCenter = new AdminCenter();

        public frmMain()
        {
            InitializeComponent();

            // check if administrator
            bool IsAdministrator = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (IsAdministrator) Text = "Administrator: " + Application.ProductName;
            else Text = WindowsIdentity.GetCurrent().User.Value + ": " + Application.ProductName;

            //OperatingSystem os = Environment.OSVersion;
            //statusLabel.Text = os.VersionString;
            //statusLabel.Text = string.Format("© {0}  ver. {1}",
            //label2.Text = Application.CompanyName;
            label_ver.Text = "ver. " + Application.ProductVersion;
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

        private void cmdButton_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand("cmd.exe");
        }

        private void compmgmt_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand("compmgmt.msc");
        }

        private void diskmgmt_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand("diskmgmt.msc");
        }

        private void msinfo_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand("msinfo32.exe");
        }

        private void firewall_Click(object sender, EventArgs e)
        {
            AdminCenter.RunCommand("firewall.cpl");
        }

        private void UpdateLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminCenter.RunCommand(AdminCenter.UPDATE2);
            Application.Exit();
        }
    }
}