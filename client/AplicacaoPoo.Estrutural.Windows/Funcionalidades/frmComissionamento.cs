using AplicacaoPOO.Dominio;
using AplicacaoPOO.Dominio.Helpers;
using AplicacaoPOO.Dominio.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{

    public partial class frmComissionamento : Form
    {
        public frmComissionamento()
        {
            InitializeComponent();
            var produtos = new Produto();

            cbxSelecionarCodigodaPeça.DataSource = produtos.ListaProdutosFakes();
            cbxSelecionarCodigodaPeça.DisplayMember = "Nome";
            cbxSelecionarCodigodaPeça.ValueMember = "Codigo";

  
        }

        private void txtValorUnitarioPeça_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtQuantidadeVendidaPeça_TextChanged(object sender, EventArgs e)
        {
            //Aqui será digitado a quantidade de peças vendidas para o cliente. 
            //será uma variável inteira pq não se pode vender uma "peça e meia".

            if (txtQuantidadeVendidaPeça.Text == "") return;
            
                try
                {
                    var num = int.Parse(txtQuantidadeVendidaPeça.Text);
                    var quant = new ValorPecaServices();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Querido usuário,\nVocê precisa informar um valor NUMÉRICO\nEx.:100");
                    txtQuantidadeVendidaPeça.Text = String.Empty;
                    txtQuantidadeVendidaPeça.Focus();
                }
            
        }

        private void cbxSelecionarCodigodaPeça_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valor = new ValorPecaServices();


            switch (cbxSelecionarCodigodaPeça.SelectedValue)
            {
                case CodigodaPeça.PecaUm:
                    {
                       
                        break;
                    }

                case CodigodaPeça.PecaDois:
                    {
                        
                        break;
                    }
                case CodigodaPeça.PecaTres:
                    {
                      
                        break;
                    }
            }
        }

        private void cbxIdFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxIdFuncionario.SelectedValue)
            {
                case IdsFuncionarios.IdUm:
                    {
                        lblNome.Text = $"{Funcionarios.FUm}";
                        break;
                    }
                case IdsFuncionarios.IdDois:
                    {
                        lblNome.Text = $"{Funcionarios.FDois}";
                        break;
                    }
                case IdsFuncionarios.IdTres:
                    {
                        lblNome.Text = $"{Funcionarios.FTres}";
                        break;
                    }
            }
        }
    }

}
