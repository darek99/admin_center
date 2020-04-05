using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
