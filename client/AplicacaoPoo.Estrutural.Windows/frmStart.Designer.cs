﻿namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmStart
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
            this.components = new System.ComponentModel.Container();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(59, 218);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(542, 30);
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLoading.TabIndex = 0;
            this.progressBarLoading.Click += new System.EventHandler(this.progressBarLoading_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacaoPoo.Estrutural.Windows.Properties.Resources.senai;
            this.pictureBox1.Location = new System.Drawing.Point(175, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick_1);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(664, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBarLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Senai 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar progressBarLoading;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerLoading;
    }
}