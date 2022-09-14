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
            txtCpf.Text = cliente.Nome;
            btContinue.Enter = tex

        }

        private void txtCredito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
