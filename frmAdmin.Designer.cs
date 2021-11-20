namespace admin_center
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.endButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label_ver = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msconfigButton);
            this.groupBox1.Controls.Add(this.appButton);
            this.groupBox1.Controls.Add(this.shadowsButton);
            this.groupBox1.Controls.Add(this.cleanButton);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oczyszczanie";
            // 
            // msconfigButton
            // 
            this.msconfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msconfigButton.Location = new System.Drawing.Point(102, 52);
            this.msconfigButton.Name = "msconfigButton";
            this.msconfigButton.Size = new System.Drawing.Size(75, 23);
            this.msconfigButton.TabIndex = 3;
            this.msconfigButton.Text = "Msconfig";
            this.msconfigButton.UseVisualStyleBackColor = true;
            this.msconfigButton.Click += new System.EventHandler(this.msconfigButton_Click);
            // 
            // appButton
            // 
            this.appButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appButton.Location = new System.Drawing.Point(21, 52);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(75, 23);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Programs";
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // shadowsButton
            // 
            this.shadowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shadowsButton.Location = new System.Drawing.Point(102, 23);
            this.shadowsButton.Name = "shadowsButton";
            this.shadowsButton.Size = new System.Drawing.Size(75, 23);
            this.shadowsButton.TabIndex = 1;
            this.shadowsButton.Text = "&Shadows";
            this.shadowsButton.UseVisualStyleBackColor = true;
            this.shadowsButton.Click += new System.EventHandler(this.shadowsButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Location = new System.Drawing.Point(21, 23);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 3;
            this.cleanButton.Text = "&Cleanmgr";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(200, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje";
            // 
            // fwButton
            // 
            this.fwButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fwButton.Location = new System.Drawing.Point(103, 111);
            this.fwButton.Name = "fwButton";
            this.fwButton.Size = new System.Drawing.Size(75, 23);
            this.fwButton.TabIndex = 7;
            this.fwButton.Text = "Firewall";
            this.fwButton.UseVisualStyleBackColor = true;
            this.fwButton.Click += new System.EventHandler(this.firewall_Click);
            // 
            // msinfoButton
            // 
            this.msinfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msinfoButton.Location = new System.Drawing.Point(21, 111);
            this.msinfoButton.Name = "msinfoButton";
            this.msinfoButton.Size = new System.Drawing.Size(75, 23);
            this.msinfoButton.TabIndex = 6;
            this.msinfoButton.Text = "Msinfo";
            this.msinfoButton.UseVisualStyleBackColor = true;
            this.msinfoButton.Click += new System.EventHandler(this.msinfo_Click);
            // 
            // diskmgmtButton
            // 
            this.diskmgmtButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diskmgmtButton.Location = new System.Drawing.Point(103, 82);
            this.diskmgmtButton.Name = "diskmgmtButton";
            this.diskmgmtButton.Size = new System.Drawing.Size(75, 23);
            this.diskmgmtButton.TabIndex = 5;
            this.diskmgmtButton.Text = "Diskmgmt";
            this.diskmgmtButton.UseVisualStyleBackColor = true;
            this.diskmgmtButton.Click += new System.EventHandler(this.diskmgmt_Click);
            // 
            // compmgmtButton
            // 
            this.compmgmtButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.compmgmtButton.Location = new System.Drawing.Point(21, 82);
            this.compmgmtButton.Name = "compmgmtButton";
            this.compmgmtButton.Size = new System.Drawing.Size(75, 23);
            this.compmgmtButton.TabIndex = 4;
            this.compmgmtButton.Text = "Compmgmt";
            this.compmgmtButton.UseVisualStyleBackColor = true;
            this.compmgmtButton.Click += new System.EventHandler(this.compmgmt_Click);
            // 
            // cmdButton
            // 
            this.cmdButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdButton.Location = new System.Drawing.Point(21, 52);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(75, 23);
            this.cmdButton.TabIndex = 3;
            this.cmdButton.Text = "Command";
            this.cmdButton.UseVisualStyleBackColor = true;
            this.cmdButton.Click += new System.EventHandler(this.cmdButton_Click);
            // 
            // wbadButton
            // 
            this.wbadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wbadButton.Location = new System.Drawing.Point(102, 52);
            this.wbadButton.Name = "wbadButton";
            this.wbadButton.Size = new System.Drawing.Size(75, 23);
            this.wbadButton.TabIndex = 2;
            this.wbadButton.Text = "WbAdmin";
            this.wbadButton.UseVisualStyleBackColor = true;
            this.wbadButton.Click += new System.EventHandler(this.wbadButton_Click);
            // 
            // taskschedButton
            // 
            this.taskschedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskschedButton.Location = new System.Drawing.Point(102, 23);
            this.taskschedButton.Name = "taskschedButton";
            this.taskschedButton.Size = new System.Drawing.Size(75, 23);
            this.taskschedButton.TabIndex = 1;
            this.taskschedButton.Text = "&Taskschd";
            this.taskschedButton.UseVisualStyleBackColor = true;
            this.taskschedButton.Click += new System.EventHandler(this.taskschedButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eventButton.Location = new System.Drawing.Point(21, 24);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(75, 23);
            this.eventButton.TabIndex = 0;
            this.eventButton.Text = "&Eventvwr";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(121, 16);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(56, 13);
            this.aboutLink.TabIndex = 2;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "Informacja";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // endButton
            // 
            this.endButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endButton.Location = new System.Drawing.Point(21, 16);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 0;
            this.endButton.Text = "Koniec";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_ver});
            this.statusStrip.Location = new System.Drawing.Point(0, 161);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkUpdate);
            this.groupBox3.Controls.Add(this.endButton);
            this.groupBox3.Controls.Add(this.aboutLink);
            this.groupBox3.Location = new System.Drawing.Point(230, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 51);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.Location = new System.Drawing.Point(121, 29);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(42, 13);
            this.linkUpdate.TabIndex = 4;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "Update";
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLink_Clicked);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 185);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_center";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button wbadButton;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel label_ver;
        private System.Windows.Forms.Button diskmgmtButton;
        private System.Windows.Forms.Button compmgmtButton;
        private System.Windows.Forms.Button cmdButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button fwButton;
        private System.Windows.Forms.Button msinfoButton;
        private System.Windows.Forms.LinkLabel linkUpdate;
    }
}

