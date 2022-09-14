﻿namespace AplicacaoPoo.Windows
{
    partial class FrmCliente
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
            this.lblCred = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCred
            // 
            this.lblCred.AutoSize = true;
            this.lblCred.Location = new System.Drawing.Point(98, 288);
            this.lblCred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCred.Name = "lblCred";
            this.lblCred.Size = new System.Drawing.Size(69, 18);
            this.lblCred.TabIndex = 15;
            this.lblCred.Text = "Crédito:";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(95, 229);
            this.lblDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(63, 18);
            this.lblDebito.TabIndex = 14;
            this.lblDebito.Text = "Débito:";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(211, 280);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(219, 26);
            this.txtCredito.TabIndex = 13;
            this.txtCredito.TextChanged += new System.EventHandler(this.txtCredito_TextChanged);
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(211, 221);
            this.txtDebito.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(219, 26);
            this.txtDebito.TabIndex = 12;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(211, 167);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(219, 26);
            this.txtCpf.TabIndex = 11;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(211, 114);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(343, 26);
            this.txtCliente.TabIndex = 10;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(113, 170);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 18);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(98, 114);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 18);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Preencha seus Dados Corretamente:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(269, 313);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 47);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(649, 372);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCred);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCred;
        private Label lblDebito;
        private TextBox txtCredito;
        private TextBox txtDebito;
        private TextBox txtCpf;
        private TextBox txtCliente;
        private Label lblCpf;
        private Label lblNome;
        private Label label1;
        private Button btContinue;
        private Button btnCalcular;
    }
}