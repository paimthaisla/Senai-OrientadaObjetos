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
            this.txtValorUnitarioDoProduto = new System.Windows.Forms.TextBox();
            this.txtInserirQuantidadeVendidaDaPeca = new System.Windows.Forms.TextBox();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.cbxSelecionarNomeDaPeca = new System.Windows.Forms.ComboBox();
            this.cbxIdFuncionario = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMostrarValorTotalDaVenda = new System.Windows.Forms.Label();
            this.lblComissão = new System.Windows.Forms.Label();
            this.lblMostrarComissãoDoFuncionario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoDoProduto = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "FUNCIONÁRIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRODUTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTIDADE VENDIDA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "VALOR UNITÁRIO DA PEÇA:";
            // 
            // txtValorUnitarioDoProduto
            // 
            this.txtValorUnitarioDoProduto.Location = new System.Drawing.Point(394, 148);
            this.txtValorUnitarioDoProduto.Name = "txtValorUnitarioDoProduto";
            this.txtValorUnitarioDoProduto.Size = new System.Drawing.Size(129, 23);
            this.txtValorUnitarioDoProduto.TabIndex = 8;
            // 
            // txtInserirQuantidadeVendidaDaPeca
            // 
            this.txtInserirQuantidadeVendidaDaPeca.Location = new System.Drawing.Point(394, 196);
            this.txtInserirQuantidadeVendidaDaPeca.Name = "txtInserirQuantidadeVendidaDaPeca";
            this.txtInserirQuantidadeVendidaDaPeca.Size = new System.Drawing.Size(129, 23);
            this.txtInserirQuantidadeVendidaDaPeca.TabIndex = 9;
            this.txtInserirQuantidadeVendidaDaPeca.TextChanged += new System.EventHandler(this.txtQuantidadeVendidaPeça_TextChanged);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Location = new System.Drawing.Point(220, 369);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(129, 24);
            this.btnConcluirVenda.TabIndex = 10;
            this.btnConcluirVenda.Text = "CONCLUIR VENDA";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            // 
            // cbxSelecionarNomeDaPeca
            // 
            this.cbxSelecionarNomeDaPeca.FormattingEnabled = true;
            this.cbxSelecionarNomeDaPeca.Location = new System.Drawing.Point(394, 100);
            this.cbxSelecionarNomeDaPeca.Name = "cbxSelecionarNomeDaPeca";
            this.cbxSelecionarNomeDaPeca.Size = new System.Drawing.Size(129, 23);
            this.cbxSelecionarNomeDaPeca.TabIndex = 13;
            // 
            // cbxIdFuncionario
            // 
            this.cbxIdFuncionario.FormattingEnabled = true;
            this.cbxIdFuncionario.Location = new System.Drawing.Point(38, 156);
            this.cbxIdFuncionario.Name = "cbxIdFuncionario";
            this.cbxIdFuncionario.Size = new System.Drawing.Size(138, 23);
            this.cbxIdFuncionario.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacaoPoo.Estrutural.Windows.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(44, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 196);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 15);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "ID FUNCIONÁRIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOTAL VENDA:";
            // 
            // lblMostrarValorTotalDaVenda
            // 
            this.lblMostrarValorTotalDaVenda.AutoSize = true;
            this.lblMostrarValorTotalDaVenda.Location = new System.Drawing.Point(491, 264);
            this.lblMostrarValorTotalDaVenda.Name = "lblMostrarValorTotalDaVenda";
            this.lblMostrarValorTotalDaVenda.Size = new System.Drawing.Size(13, 15);
            this.lblMostrarValorTotalDaVenda.TabIndex = 12;
            this.lblMostrarValorTotalDaVenda.Text = "0";
            // 
            // lblComissão
            // 
            this.lblComissão.AutoSize = true;
            this.lblComissão.Location = new System.Drawing.Point(229, 310);
            this.lblComissão.Name = "lblComissão";
            this.lblComissão.Size = new System.Drawing.Size(130, 15);
            this.lblComissão.TabIndex = 14;
            this.lblComissão.Text = "COMISSÃO DA VENDA:";
            // 
            // lblMostrarComissãoDoFuncionario
            // 
            this.lblMostrarComissãoDoFuncionario.AutoSize = true;
            this.lblMostrarComissãoDoFuncionario.Location = new System.Drawing.Point(491, 310);
            this.lblMostrarComissãoDoFuncionario.Name = "lblMostrarComissãoDoFuncionario";
            this.lblMostrarComissãoDoFuncionario.Size = new System.Drawing.Size(13, 15);
            this.lblMostrarComissãoDoFuncionario.TabIndex = 15;
            this.lblMostrarComissãoDoFuncionario.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "CÓDIGO DO PRODUTO:";
            // 
            // txtCodigoDoProduto
            // 
            this.txtCodigoDoProduto.Location = new System.Drawing.Point(394, 52);
            this.txtCodigoDoProduto.Name = "txtCodigoDoProduto";
            this.txtCodigoDoProduto.Size = new System.Drawing.Size(129, 23);
            this.txtCodigoDoProduto.TabIndex = 21;
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(560, 405);
            this.Controls.Add(this.txtCodigoDoProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxIdFuncionario);
            this.Controls.Add(this.lblMostrarComissãoDoFuncionario);
            this.Controls.Add(this.lblComissão);
            this.Controls.Add(this.cbxSelecionarNomeDaPeca);
            this.Controls.Add(this.lblMostrarValorTotalDaVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.txtInserirQuantidadeVendidaDaPeca);
            this.Controls.Add(this.txtValorUnitarioDoProduto);
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
        private TextBox txtValorUnitarioDoProduto;
        private TextBox txtInserirQuantidadeVendidaDaPeca;
        private Button btnConcluirVenda;
        private ComboBox cbxSelecionarNomeDaPeca;
        private ComboBox cbxIdFuncionario;
        private PictureBox pictureBox1;
        private Label lblNome;
        private Label label6;
        private Label lblMostrarValorTotalDaVenda;
        private Label lblComissão;
        private Label lblMostrarComissãoDoFuncionario;
        private Label label7;
        private TextBox txtCodigoDoProduto;
    }
}