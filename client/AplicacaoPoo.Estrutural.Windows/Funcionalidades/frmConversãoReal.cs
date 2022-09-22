using AplicacaoPOO.Dominio;
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
    public partial class frmConversãoReal : Form
    {
     
        public frmConversãoReal()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
            
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
          
            var moeda = new ConverterMoedaServices(); //variavel que recebe o valor da Classe 
            var real = decimal.Parse(txtValorConverterReal.Text); // variavel que recebe o valor do TextBox

            //string interpolation
            var resultado = moeda.ConverterDolarEmReal(real);
            MessageBox.Show($"O Valor convertido é: {resultado} reais");
           
        }

        private void txtValorConverterReal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorConverterReal.Text == "")
                {
                    btnConverter.Enabled = false;
                    return;
                }
                
                var resultado = decimal.Parse(txtValorConverterReal.Text);
                btnConverter.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha apenas com números!");
                txtValorConverterReal.Focus();
                btnConverter.Enabled = false;

            }
        }
    }
}
