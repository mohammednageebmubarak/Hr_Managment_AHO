﻿namespace Hr_Managment_AHO.PL
{
    partial class BackupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(98, 36);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(129, 23);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "انشاء";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click_1);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 88);
            this.Controls.Add(this.btnBackup);
            this.Name = "BackupForm";
            this.Text = "انشاء نسخة احتياطية";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
    }
}