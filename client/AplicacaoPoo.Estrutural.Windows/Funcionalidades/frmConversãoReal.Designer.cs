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
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtValorConverterReal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorAtualDolar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(228, 292);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(120, 32);
            this.btnConverter.TabIndex = 20;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.TextChanged += new System.EventHandler(this.btnConverter_TextChanged);
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtValorConverterReal
            // 
            this.txtValorConverterReal.Location = new System.Drawing.Point(378, 196);
            this.txtValorConverterReal.Name = "txtValorConverterReal";
            this.txtValorConverterReal.Size = new System.Drawing.Size(100, 23);
            this.txtValorConverterReal.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "VALOR DOLAR CONVERTIDO PRA REAL:";
            // 
            // txtValorAtualDolar
            // 
            this.txtValorAtualDolar.Location = new System.Drawing.Point(309, 134);
            this.txtValorAtualDolar.Name = "txtValorAtualDolar";
            this.txtValorAtualDolar.Size = new System.Drawing.Size(100, 23);
            this.txtValorAtualDolar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Insira as informações corretamente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "VALOR ATUAL DO DOLAR: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "BEM-VINDO AO SISTEMA CONVERSÃO REAL/DOLAR ";
            // 
            // frmConversãoReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorConverterReal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorAtualDolar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConversãoReal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConversãoReal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResultadoConversao;
        private Button btnConverter;
        private Label label6;
        private TextBox txtValorConverterReal;
        private Label label5;
        private TextBox txtValorAtualDolar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}