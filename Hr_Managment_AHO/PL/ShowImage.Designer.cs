﻿namespace Hr_Managment_AHO.PL
{
    partial class ShowImage
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
            this.picShowImage = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picShowImage
            // 
            this.picShowImage.Location = new System.Drawing.Point(12, 12);
            this.picShowImage.Name = "picShowImage";
            this.picShowImage.Size = new System.Drawing.Size(351, 484);
            this.picShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowImage.TabIndex = 1;
            this.picShowImage.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(150, 518);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(392, 553);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.picShowImage);
            this.MinimizeBox = false;
            this.Name = "ShowImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مستعرض الصور";
            ((System.ComponentModel.ISupportInitialize)(this.picShowImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picShowImage;
        private System.Windows.Forms.Button btnPrint;
    }
}