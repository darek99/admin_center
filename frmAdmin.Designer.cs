﻿namespace admin_center
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.msconfigButton = new System.Windows.Forms.Button();
            this.appButton = new System.Windows.Forms.Button();
            this.shadowsButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fwButton = new System.Windows.Forms.Button();
            this.msinfoButton = new System.Windows.Forms.Button();
            this.diskmgmtButton = new System.Windows.Forms.Button();
            this.compmgmtButton = new System.Windows.Forms.Button();
            this.cmdButton = new System.Windows.Forms.Button();
            this.wbadButton = new System.Windows.Forms.Button();
            this.taskschedButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label_ver = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkWmicList = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkWmicList);
            this.groupBox1.Controls.Add(this.numUpDown);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.msconfigButton);
            this.groupBox1.Controls.Add(this.appButton);
            this.groupBox1.Controls.Add(this.shadowsButton);
            this.groupBox1.Controls.Add(this.cleanButton);
            this.groupBox1.Location = new System.Drawing.Point(307, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cleaning";
            // 
            // numUpDown
            // 
            this.numUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDown.Location = new System.Drawing.Point(136, 103);
            this.numUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(101, 22);
            this.numUpDown.TabIndex = 5;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "WbClean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WbCleanButton_Click);
            // 
            // msconfigButton
            // 
            this.msconfigButton.Location = new System.Drawing.Point(136, 64);
            this.msconfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msconfigButton.Name = "msconfigButton";
            this.msconfigButton.Size = new System.Drawing.Size(100, 28);
            this.msconfigButton.TabIndex = 3;
            this.msconfigButton.Text = "Msconfig";
            this.msconfigButton.UseVisualStyleBackColor = true;
            this.msconfigButton.Click += new System.EventHandler(this.MsconfigButton_Click);
            // 
            // appButton
            // 
            this.appButton.Location = new System.Drawing.Point(28, 64);
            this.appButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(100, 28);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Programs";
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.AppButton_Click);
            // 
            // shadowsButton
            // 
            this.shadowsButton.Location = new System.Drawing.Point(136, 28);
            this.shadowsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowsButton.Name = "shadowsButton";
            this.shadowsButton.Size = new System.Drawing.Size(100, 28);
            this.shadowsButton.TabIndex = 1;
            this.shadowsButton.Text = "&Shadows";
            this.shadowsButton.UseVisualStyleBackColor = true;
            this.shadowsButton.Click += new System.EventHandler(this.ShadowsButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(28, 28);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(100, 28);
            this.cleanButton.TabIndex = 0;
            this.cleanButton.Text = "&Cleanmgr";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fwButton);
            this.groupBox2.Controls.Add(this.msinfoButton);
            this.groupBox2.Controls.Add(this.diskmgmtButton);
            this.groupBox2.Controls.Add(this.compmgmtButton);
            this.groupBox2.Controls.Add(this.cmdButton);
            this.groupBox2.Controls.Add(this.wbadButton);
            this.groupBox2.Controls.Add(this.taskschedButton);
            this.groupBox2.Controls.Add(this.eventButton);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // fwButton
            // 
            this.fwButton.Location = new System.Drawing.Point(137, 137);
            this.fwButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fwButton.Name = "fwButton";
            this.fwButton.Size = new System.Drawing.Size(100, 28);
            this.fwButton.TabIndex = 7;
            this.fwButton.Text = "Firewall";
            this.fwButton.UseVisualStyleBackColor = true;
            this.fwButton.Click += new System.EventHandler(this.Firewall_Click);
            // 
            // msinfoButton
            // 
            this.msinfoButton.Location = new System.Drawing.Point(28, 137);
            this.msinfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msinfoButton.Name = "msinfoButton";
            this.msinfoButton.Size = new System.Drawing.Size(100, 28);
            this.msinfoButton.TabIndex = 6;
            this.msinfoButton.Text = "Msinfo";
            this.msinfoButton.UseVisualStyleBackColor = true;
            this.msinfoButton.Click += new System.EventHandler(this.Msinfo_Click);
            // 
            // diskmgmtButton
            // 
            this.diskmgmtButton.Location = new System.Drawing.Point(137, 101);
            this.diskmgmtButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diskmgmtButton.Name = "diskmgmtButton";
            this.diskmgmtButton.Size = new System.Drawing.Size(100, 28);
            this.diskmgmtButton.TabIndex = 5;
            this.diskmgmtButton.Text = "Diskmgmt";
            this.diskmgmtButton.UseVisualStyleBackColor = true;
            this.diskmgmtButton.Click += new System.EventHandler(this.Diskmgmt_Click);
            // 
            // compmgmtButton
            // 
            this.compmgmtButton.Location = new System.Drawing.Point(28, 101);
            this.compmgmtButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compmgmtButton.Name = "compmgmtButton";
            this.compmgmtButton.Size = new System.Drawing.Size(100, 28);
            this.compmgmtButton.TabIndex = 4;
            this.compmgmtButton.Text = "Compmgmt";
            this.compmgmtButton.UseVisualStyleBackColor = true;
            this.compmgmtButton.Click += new System.EventHandler(this.Compmgmt_Click);
            // 
            // cmdButton
            // 
            this.cmdButton.Location = new System.Drawing.Point(28, 64);
            this.cmdButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(100, 28);
            this.cmdButton.TabIndex = 2;
            this.cmdButton.Text = "Command";
            this.cmdButton.UseVisualStyleBackColor = true;
            this.cmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // wbadButton
            // 
            this.wbadButton.Location = new System.Drawing.Point(136, 64);
            this.wbadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wbadButton.Name = "wbadButton";
            this.wbadButton.Size = new System.Drawing.Size(100, 28);
            this.wbadButton.TabIndex = 3;
            this.wbadButton.Text = "Wbadmin";
            this.wbadButton.UseVisualStyleBackColor = true;
            this.wbadButton.Click += new System.EventHandler(this.WbadButton_Click);
            // 
            // taskschedButton
            // 
            this.taskschedButton.Location = new System.Drawing.Point(136, 28);
            this.taskschedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskschedButton.Name = "taskschedButton";
            this.taskschedButton.Size = new System.Drawing.Size(100, 28);
            this.taskschedButton.TabIndex = 1;
            this.taskschedButton.Text = "&Taskschd";
            this.taskschedButton.UseVisualStyleBackColor = true;
            this.taskschedButton.Click += new System.EventHandler(this.TaskschedButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.Location = new System.Drawing.Point(28, 30);
            this.eventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(100, 28);
            this.eventButton.TabIndex = 0;
            this.eventButton.Text = "&Eventvwr";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.EventButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_ver});
            this.statusStrip.Location = new System.Drawing.Point(0, 220);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(589, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            // 
            // label_ver
            // 
            this.label_ver.AutoSize = false;
            this.label_ver.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.label_ver.Name = "label_ver";
            this.label_ver.Size = new System.Drawing.Size(569, 18);
            this.label_ver.Spring = true;
            this.label_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkWmicList
            // 
            this.linkWmicList.Location = new System.Drawing.Point(25, 150);
            this.linkWmicList.Name = "linkWmicList";
            this.linkWmicList.Size = new System.Drawing.Size(211, 15);
            this.linkWmicList.TabIndex = 7;
            this.linkWmicList.TabStop = true;
            this.linkWmicList.Text = "useraccount get Disabled, Lockout, Name, PasswordChangeable, PasswordExpires, Pas" +
    "swordRequired";
            this.toolTip1.SetToolTip(this.linkWmicList, "wmic useraccount get Disabled, Lockout, Name, PasswordChangeable, PasswordExpires" +
        ", PasswordRequired");
            this.linkWmicList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWmicList_LinkClicked);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 244);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_center";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmAdmin_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button shadowsButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button taskschedButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Button msconfigButton;
        private System.Windows.Forms.Button wbadButton;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel label_ver;
        private System.Windows.Forms.Button diskmgmtButton;
        private System.Windows.Forms.Button compmgmtButton;
        private System.Windows.Forms.Button cmdButton;
        private System.Windows.Forms.Button fwButton;
        private System.Windows.Forms.Button msinfoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.LinkLabel linkWmicList;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

