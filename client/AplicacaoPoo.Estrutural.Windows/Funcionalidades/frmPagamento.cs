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
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();

        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            double precoUnitario = double.Parse(txtValorUnitarioPeça.Text);
            int quantidade = int.Parse(txtQuantidadeVendidaPeça.Text);
            lblValorTotal.Visible = false;

            var total = precoUnitario * quantidade;
            var mensagem = total.ToString();
            lblValorTotal.Text = mensagem;
            lblValorTotal.Visible = true;
           
     
        }
    }
}
