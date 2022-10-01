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
            btnConcluirVenda.Enabled = false;

            cbxSelecionarNomeDaPeca.DataSource = produtos.ListaProdutosFakes();
            cbxSelecionarNomeDaPeca.DisplayMember = "Nome";
            cbxSelecionarNomeDaPeca.ValueMember = "Codigo";
        }

        private void txtQuantidadeVendidaPeça_TextChanged(object sender, EventArgs e)
        {


            

            if (txtInserirQuantidadeVendidaDaPeca.Text == "") return;

            try
            {
                var num = int.Parse(txtInserirQuantidadeVendidaDaPeca.Text);
                var quantidade = new ValorPecaServices();

            }
            catch (Exception)
            {
                MessageBox.Show("Querido usuário,\nVocê precisa informar um valor NUMÉRICO\nEx.:100");
                txtInserirQuantidadeVendidaDaPeca.Text = String.Empty;
                txtInserirQuantidadeVendidaDaPeca.Focus();
            }

        }

        private void cbxSelecionarNomeDaPeca_SelectedIndexChanged(object sender, EventArgs e)
        {

            var dados = (Produto)cbxSelecionarNomeDaPeca.SelectedValue;
            var listaFake = dados.ListaProdutosFakes();

            var resultado = listaFake.Where(x => x.Codigo == dados.Codigo).FirstOrDefault();
            txtCodigoDoProduto.Text = resultado.Codigo.ToString();
            txtValorUnitarioDoProduto.Text = resultado.Valor.ToString();
            
        }
    }
}
