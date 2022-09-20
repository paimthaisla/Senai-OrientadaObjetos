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

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmConversãoReal : Form
    {
        public frmConversãoReal()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            var dolar = decimal.Parse(txtValorAtualDolar.Text);
            var real = decimal.Parse(txtValorConverterReal.Text);
 
        }

        private void btnConverter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorConverterReal.Text);  
            }

            catch(Exception)
            {
                MessageBox.Show("Preencha com números!");
                txtValorConverterReal.Focus();

                throw;
            }
        }
    }
}
