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
        private bool CotacaoEhvalido; //Todo valor inical bool é falso; (private) pq só usará estás variáveis neste formulário.
        private bool ValoremDolarValido;

        public frmConversãoReal()
        {
            InitializeComponent();
            habilitarOuDesabilitarBotaoCalcularConversao();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            var dolar = decimal.Parse(txtValorAtualDolar.Text);
            var real = decimal.Parse(txtValorConverterReal.Text);

            var resultado = dolar * real;
            MessageBox.Show("O resultado é: " + resultado);
                
 
        }

        private void txtValorAtualDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorAtualDolar.Text);
                CotacaoEhvalido = true;
                habilitarOuDesabilitarBotaoCalcularConversao();
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha apenas com números!");
                txtValorAtualDolar.Show();
                CotacaoEhvalido = false;
                habilitarOuDesabilitarBotaoCalcularConversao();

            }

        }


        private void txtValorConverterReal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorConverterReal.Text);
                ValoremDolarValido = true;
                habilitarOuDesabilitarBotaoCalcularConversao();
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha apenas com números!");
                txtValorConverterReal.Focus();
                ValoremDolarValido = false;
                habilitarOuDesabilitarBotaoCalcularConversao();
            }
        }

        private void habilitarOuDesabilitarBotaoCalcularConversao()
        {
            if (ValoremDolarValido && CotacaoEhvalido)
            {
                btnConverter.Enabled = true;
            }
            else
            {
                btnConverter.Enabled = false;
            }
        }

       
    }
}
