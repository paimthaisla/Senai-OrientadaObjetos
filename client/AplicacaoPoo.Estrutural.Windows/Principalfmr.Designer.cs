namespace AplicacaoPoo.Estrutural.Windows
{
    partial class Principalfmr
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
            this.btnAbrirFormConversão = new System.Windows.Forms.Button();
            this.btnAbrirFormPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormConversão
            // 
            this.btnAbrirFormConversão.BackColor = System.Drawing.Color.Red;
            this.btnAbrirFormConversão.FlatAppearance.BorderSize = 5;
            this.btnAbrirFormConversão.Location = new System.Drawing.Point(273, 262);
            this.btnAbrirFormConversão.Name = "btnAbrirFormConversão";
            this.btnAbrirFormConversão.Size = new System.Drawing.Size(90, 38);
            this.btnAbrirFormConversão.TabIndex = 0;
            this.btnAbrirFormConversão.Text = "Conversão REAL/DOLAR";
            this.btnAbrirFormConversão.UseVisualStyleBackColor = false;
            // 
            // btnAbrirFormPagamento
            // 
            this.btnAbrirFormPagamento.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAbrirFormPagamento.Location = new System.Drawing.Point(440, 262);
            this.btnAbrirFormPagamento.Name = "btnAbrirFormPagamento";
            this.btnAbrirFormPagamento.Size = new System.Drawing.Size(90, 38);
            this.btnAbrirFormPagamento.TabIndex = 1;
            this.btnAbrirFormPagamento.Text = "Pagamento";
            this.btnAbrirFormPagamento.UseVisualStyleBackColor = false;
            this.btnAbrirFormPagamento.Click += new System.EventHandler(this.btnAbrirFormPagamento_Click);
            // 
            // Principalfmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacaoPoo.Estrutural.Windows.Properties.Resources.decisão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirFormPagamento);
            this.Controls.Add(this.btnAbrirFormConversão);
            this.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Principalfmr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principalfmr";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormConversão;
        private Button btnAbrirFormPagamento;
    }
}