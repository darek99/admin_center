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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.wbText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msconfigButton = new System.Windows.Forms.Button();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkUpdate);
            this.groupBox1.Controls.Add(this.wbText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.msconfigButton);
            this.groupBox1.Controls.Add(this.aboutLink);
            this.groupBox1.Controls.Add(this.appButton);
            this.groupBox1.Controls.Add(this.shadowsButton);
            this.groupBox1.Controls.Add(this.cleanButton);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cleaning";
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.Location = new System.Drawing.Point(100, 131);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(42, 13);
            this.linkUpdate.TabIndex = 2;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "Update";
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLink_Clicked);
            // 
            // wbText
            // 
            this.wbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wbText.Location = new System.Drawing.Point(122, 84);
            this.wbText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbText.Name = "wbText";
            this.wbText.Size = new System.Drawing.Size(32, 20);
            this.wbText.TabIndex = 5;
            this.wbText.Text = "3";
            this.wbText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "WB clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WbCleanButton_Click);
            // 
            // msconfigButton
            // 
            this.msconfigButton.Location = new System.Drawing.Point(102, 52);
            this.msconfigButton.Name = "msconfigButton";
            this.msconfigButton.Size = new System.Drawing.Size(75, 23);
            this.msconfigButton.TabIndex = 3;
            this.msconfigButton.Text = "Msconfig";
            this.msconfigButton.UseVisualStyleBackColor = true;
            this.msconfigButton.Click += new System.EventHandler(this.MsconfigButton_Click);
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(143, 131);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(35, 13);
            this.aboutLink.TabIndex = 1;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "About";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // appButton
            // 
            this.appButton.Location = new System.Drawing.Point(21, 52);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(75, 23);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Programs";
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.AppButton_Click);
            // 
            // shadowsButton
            // 
            this.shadowsButton.Location = new System.Drawing.Point(102, 23);
            this.shadowsButton.Name = "shadowsButton";
            this.shadowsButton.Size = new System.Drawing.Size(75, 23);
            this.shadowsButton.TabIndex = 1;
            this.shadowsButton.Text = "&Shadows";
            this.shadowsButton.UseVisualStyleBackColor = true;
            this.shadowsButton.Click += new System.EventHandler(this.ShadowsButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(21, 23);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // fwButton
            // 
            this.fwButton.Location = new System.Drawing.Point(103, 111);
            this.fwButton.Name = "fwButton";
            this.fwButton.Size = new System.Drawing.Size(75, 23);
            this.fwButton.TabIndex = 7;
            this.fwButton.Text = "Firewall";
            this.fwButton.UseVisualStyleBackColor = true;
            this.fwButton.Click += new System.EventHandler(this.Firewall_Click);
            // 
            // msinfoButton
            // 
            this.msinfoButton.Location = new System.Drawing.Point(21, 111);
            this.msinfoButton.Name = "msinfoButton";
            this.msinfoButton.Size = new System.Drawing.Size(75, 23);
            this.msinfoButton.TabIndex = 6;
            this.msinfoButton.Text = "Msinfo";
            this.msinfoButton.UseVisualStyleBackColor = true;
            this.msinfoButton.Click += new System.EventHandler(this.Msinfo_Click);
            // 
            // diskmgmtButton
            // 
            this.diskmgmtButton.Location = new System.Drawing.Point(103, 82);
            this.diskmgmtButton.Name = "diskmgmtButton";
            this.diskmgmtButton.Size = new System.Drawing.Size(75, 23);
            this.diskmgmtButton.TabIndex = 5;
            this.diskmgmtButton.Text = "Diskmgmt";
            this.diskmgmtButton.UseVisualStyleBackColor = true;
            this.diskmgmtButton.Click += new System.EventHandler(this.Diskmgmt_Click);
            // 
            // compmgmtButton
            // 
            this.compmgmtButton.Location = new System.Drawing.Point(21, 82);
            this.compmgmtButton.Name = "compmgmtButton";
            this.compmgmtButton.Size = new System.Drawing.Size(75, 23);
            this.compmgmtButton.TabIndex = 4;
            this.compmgmtButton.Text = "Compmgmt";
            this.compmgmtButton.UseVisualStyleBackColor = true;
            this.compmgmtButton.Click += new System.EventHandler(this.Compmgmt_Click);
            // 
            // cmdButton
            // 
            this.cmdButton.Location = new System.Drawing.Point(21, 52);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(75, 23);
            this.cmdButton.TabIndex = 2;
            this.cmdButton.Text = "Command";
            this.cmdButton.UseVisualStyleBackColor = true;
            this.cmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // wbadButton
            // 
            this.wbadButton.Location = new System.Drawing.Point(102, 52);
            this.wbadButton.Name = "wbadButton";
            this.wbadButton.Size = new System.Drawing.Size(75, 23);
            this.wbadButton.TabIndex = 3;
            this.wbadButton.Text = "Wbadmin";
            this.wbadButton.UseVisualStyleBackColor = true;
            this.wbadButton.Click += new System.EventHandler(this.WbadButton_Click);
            // 
            // taskschedButton
            // 
            this.taskschedButton.Location = new System.Drawing.Point(102, 23);
            this.taskschedButton.Name = "taskschedButton";
            this.taskschedButton.Size = new System.Drawing.Size(75, 23);
            this.taskschedButton.TabIndex = 1;
            this.taskschedButton.Text = "&Taskschd";
            this.taskschedButton.UseVisualStyleBackColor = true;
            this.taskschedButton.Click += new System.EventHandler(this.TaskschedButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.Location = new System.Drawing.Point(21, 24);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(75, 23);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 174);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(442, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            // 
            // label_ver
            // 
            this.label_ver.AutoSize = false;
            this.label_ver.Name = "label_ver";
            this.label_ver.Size = new System.Drawing.Size(427, 19);
            this.label_ver.Spring = true;
            this.label_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 198);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_center";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.LinkLabel aboutLink;
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
        private System.Windows.Forms.LinkLabel linkUpdate;
        private System.Windows.Forms.TextBox wbText;
        private System.Windows.Forms.Button button1;
    }
}

