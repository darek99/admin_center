﻿namespace admin_center
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msconfigButton = new System.Windows.Forms.Button();
            this.appButton = new System.Windows.Forms.Button();
            this.shadowsButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wbadButton = new System.Windows.Forms.Button();
            this.taskschedButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.endButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.msconfigButton.Location = new System.Drawing.Point(102, 52);
            this.msconfigButton.Name = "msconfigButton";
            this.msconfigButton.Size = new System.Drawing.Size(75, 23);
            this.msconfigButton.TabIndex = 3;
            this.msconfigButton.Text = "Msconfig";
            this.msconfigButton.UseVisualStyleBackColor = true;
            this.msconfigButton.Click += new System.EventHandler(this.MsconfigButton_Click);
            // 
            // appButton
            // 
            this.appButton.Location = new System.Drawing.Point(21, 52);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(75, 23);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Apps";
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 163);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(442, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wbadButton);
            this.groupBox2.Controls.Add(this.taskschedButton);
            this.groupBox2.Controls.Add(this.eventButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje";
            // 
            // wbadButton
            // 
            this.wbadButton.Location = new System.Drawing.Point(102, 52);
            this.wbadButton.Name = "wbadButton";
            this.wbadButton.Size = new System.Drawing.Size(75, 23);
            this.wbadButton.TabIndex = 2;
            this.wbadButton.Text = "WbAdmin";
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
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(341, 122);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(56, 13);
            this.aboutLink.TabIndex = 2;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "Informacja";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(251, 117);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 3;
            this.endButton.Text = "Koniec";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 185);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_center";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button shadowsButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button taskschedButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Button msconfigButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button wbadButton;
    }
}

