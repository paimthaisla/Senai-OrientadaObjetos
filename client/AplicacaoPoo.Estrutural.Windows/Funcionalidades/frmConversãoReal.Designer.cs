namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmConversãoReal
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
            this.txtValorConverterReal = new System.Windows.Forms.TextBox();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.cbxMoeda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorConverterReal
            // 
            this.txtValorConverterReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorConverterReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorConverterReal.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorConverterReal.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtValorConverterReal.Location = new System.Drawing.Point(48, 183);
            this.txtValorConverterReal.Multiline = true;
            this.txtValorConverterReal.Name = "txtValorConverterReal";
            this.txtValorConverterReal.PlaceholderText = "Informe o Valor";
            this.txtValorConverterReal.Size = new System.Drawing.Size(275, 26);
            this.txtValorConverterReal.TabIndex = 18;
            this.txtValorConverterReal.TextChanged += new System.EventHandler(this.txtValorConverterReal_TextChanged);
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSegundoValor.Location = new System.Drawing.Point(48, 71);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 37);
            this.lblSegundoValor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(48, 38);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 15);
            this.lblPrimeiroValor.TabIndex = 12;
            // 
            // cbxMoeda
            // 
            this.cbxMoeda.FormattingEnabled = true;
            this.cbxMoeda.Items.AddRange(new object[] {
            "Dolar Americano",
            "Euro ",
            "Libra"});
            this.cbxMoeda.Location = new System.Drawing.Point(372, 47);
            this.cbxMoeda.Name = "cbxMoeda";
            this.cbxMoeda.Size = new System.Drawing.Size(118, 23);
            this.cbxMoeda.TabIndex = 19;
            this.cbxMoeda.SelectedIndexChanged += new System.EventHandler(this.cbxMoeda_SelectedIndexChanged);
            // 
            // frmConversãoReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(522, 273);
            this.Controls.Add(this.cbxMoeda);
            this.Controls.Add(this.txtValorConverterReal);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Name = "frmConversãoReal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConversãoReal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResultadoConversao;
        private Label label6;
        private TextBox txtValorConverterReal;
        private Label lblSegundoValor;
        private Label label2;
        private Label lblPrimeiroValor;
        private ComboBox comboBox1;
        private ComboBox cbxMoeda;
    }
}