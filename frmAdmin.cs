using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace admin_center

{
    public partial class frmAdmin : Form
    {
        /// <summary>
        /// Obiekt klasy admin
        /// </summary>
        private Admin admin;

        public frmAdmin()
        {
            InitializeComponent();

            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                Text = "Administrator: " + Application.ProductName;
            else
                Text = WindowsIdentity.GetCurrent().User.Value + ": " + Application.ProductName;

            label_ver.Text = "ver." + Application.ProductVersion;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            admin.Run(admin.APPWIZ);
        }

        private void shadowsButton_Click(object sender, EventArgs e)
        {
            admin.CleanShadows();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            admin.Run(admin.EVENTVWR);
        }

        private void taskschedButton_Click(object sender, EventArgs e)
        {
            admin.Run(admin.TASKSCHD);
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str_message = string.Format("Copyright © {0}\nWersja {1}", Application.CompanyName, Application.ProductVersion);

            MessageBox.Show(str_message, Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void appButton_Click(object sender, EventArgs e)
        {
            admin.Run(admin.APPWIZ);
        }

        private void msconfigButton_Click(object sender, EventArgs e)
        {
            admin.Run(admin.MSCONFIG);
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wbadButton_Click(object sender, EventArgs e)
        {
            admin.Run(admin.WBADMIN);
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            admin.Run("cmd.exe");
        }

        private void compmgmt_Click(object sender, EventArgs e)
        {
            admin.Run("compmgmt.msc");
        }

        private void diskmgmt_Click(object sender, EventArgs e)
        {
            admin.Run("diskmgmt.msc");
        }

        private void msinfo_Click(object sender, EventArgs e)
        {
            admin.Run("msinfo32.exe");
        }

        private void firewall_Click(object sender, EventArgs e)
        {
            admin.Run("firewall.cpl");
        }

        private void updateLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin.Run(admin.UPDATE2);
            Application.Exit();
        }
    }
}