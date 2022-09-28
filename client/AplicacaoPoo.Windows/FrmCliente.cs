using AplicacaoPOO.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Windows
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.Nome = "Thaísla Paim";
            txtCliente.Text = cliente.Nome;
            txtCpf.Text = "195.888.000-33";
            lblSaldoInicialValor.Text = "1000";

                      
        }
        

        private void txtCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSaldoInicialValor_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();
            
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
