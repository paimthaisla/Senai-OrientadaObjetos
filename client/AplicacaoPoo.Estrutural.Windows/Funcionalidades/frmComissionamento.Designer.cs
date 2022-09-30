namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmComissionamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorUnitarioPeça = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVendidaPeça = new System.Windows.Forms.TextBox();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSelecionarCodigodaPeça = new System.Windows.Forms.ComboBox();
            this.lblComissão = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblMostrarComissão = new System.Windows.Forms.Label();
            this.cbxIdFuncionario = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID FUNCIONARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRODUTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTIDADE VENDIDA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "VALOR UNITÁRIO DA PEÇA:";
            // 
            // txtValorUnitarioPeça
            // 
            this.txtValorUnitarioPeça.Location = new System.Drawing.Point(222, 153);
            this.txtValorUnitarioPeça.Name = "txtValorUnitarioPeça";
            this.txtValorUnitarioPeça.Size = new System.Drawing.Size(138, 23);
            this.txtValorUnitarioPeça.TabIndex = 8;
            this.txtValorUnitarioPeça.TextChanged += new System.EventHandler(this.txtValorUnitarioPeça_TextChanged);
            // 
            // txtQuantidadeVendidaPeça
            // 
            this.txtQuantidadeVendidaPeça.Location = new System.Drawing.Point(222, 204);
            this.txtQuantidadeVendidaPeça.Name = "txtQuantidadeVendidaPeça";
            this.txtQuantidadeVendidaPeça.Size = new System.Drawing.Size(138, 23);
            this.txtQuantidadeVendidaPeça.TabIndex = 9;
            this.txtQuantidadeVendidaPeça.TextChanged += new System.EventHandler(this.txtQuantidadeVendidaPeça_TextChanged);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Location = new System.Drawing.Point(394, 355);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(129, 24);
            this.btnConcluirVenda.TabIndex = 10;
            this.btnConcluirVenda.Text = "CONCLUIR VENDA";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOTAL VENDA:";
            // 
            // cbxSelecionarCodigodaPeça
            // 
            this.cbxSelecionarCodigodaPeça.FormattingEnabled = true;
            this.cbxSelecionarCodigodaPeça.Items.AddRange(new object[] {
            "1111",
            "2222",
            "3333"});
            this.cbxSelecionarCodigodaPeça.Location = new System.Drawing.Point(222, 102);
            this.cbxSelecionarCodigodaPeça.Name = "cbxSelecionarCodigodaPeça";
            this.cbxSelecionarCodigodaPeça.Size = new System.Drawing.Size(138, 23);
            this.cbxSelecionarCodigodaPeça.TabIndex = 13;
            this.cbxSelecionarCodigodaPeça.SelectedIndexChanged += new System.EventHandler(this.cbxSelecionarCodigodaPeça_SelectedIndexChanged);
            // 
            // lblComissão
            // 
            this.lblComissão.AutoSize = true;
            this.lblComissão.Location = new System.Drawing.Point(54, 301);
            this.lblComissão.Name = "lblComissão";
            this.lblComissão.Size = new System.Drawing.Size(118, 15);
            this.lblComissão.TabIndex = 14;
            this.lblComissão.Text = "Comissão por Venda:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(336, 264);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(13, 15);
            this.lblValorTotal.TabIndex = 12;
            this.lblValorTotal.Text = "0";
            // 
            // lblMostrarComissão
            // 
            this.lblMostrarComissão.AutoSize = true;
            this.lblMostrarComissão.Location = new System.Drawing.Point(336, 301);
            this.lblMostrarComissão.Name = "lblMostrarComissão";
            this.lblMostrarComissão.Size = new System.Drawing.Size(13, 15);
            this.lblMostrarComissão.TabIndex = 15;
            this.lblMostrarComissão.Text = "0";
            // 
            // cbxIdFuncionario
            // 
            this.cbxIdFuncionario.FormattingEnabled = true;
            this.cbxIdFuncionario.Items.AddRange(new object[] {
            "0123456",
            "1023456",
            "1203456"});
            this.cbxIdFuncionario.Location = new System.Drawing.Point(222, 51);
            this.cbxIdFuncionario.Name = "cbxIdFuncionario";
            this.cbxIdFuncionario.Size = new System.Drawing.Size(138, 23);
            this.cbxIdFuncionario.TabIndex = 16;
            this.cbxIdFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbxIdFuncionario_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(420, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(431, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 15);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "FUNCIONARIO:";
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(560, 405);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxIdFuncionario);
            this.Controls.Add(this.lblMostrarComissão);
            this.Controls.Add(this.lblComissão);
            this.Controls.Add(this.cbxSelecionarCodigodaPeça);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.txtQuantidadeVendidaPeça);
            this.Controls.Add(this.txtValorUnitarioPeça);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComissionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtValorUnitarioPeça;
        private TextBox txtQuantidadeVendidaPeça;
        private Button btnConcluirVenda;
        private Label label6;
        private ComboBox cbxSelecionarCodigodaPeça;
        private Label lblComissão;
        private Label lblValorTotal;
        private Label lblMostrarComissão;
        private ComboBox cbxIdFuncionario;
        private PictureBox pictureBox1;
        private Label lblNome;
    }
}