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
    public partial class frmConversãoReal : Form
    {
        private int moeda;

        public frmConversãoReal()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a:";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
        }
            



        private void txtValorConverterReal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorConverterReal.Text == "") return;
                {
                    var dolar = decimal.Parse(txtValorConverterReal.Text);

                   
                    var moeda = new ConverterMoedaServices(); //variave
                    var resultado = moeda.ConverterDolarEmReal(dolar);
                    lblPrimeiroValor.Text = $"{dolar} {MoedaHelper.Dolar}";
                    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                }
            }
           
            catch (Exception)
            {
                MessageBox.Show("Preencha apenas com números!");
                txtValorConverterReal.Focus();


            }
        }

        private void cbxMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMoeda_SelectedIndexChanged)
            {
                case "Dolar":
                    
                    var dolar = decimal.Parse(txtValorConverterReal.Text);


                    var moeda = new ConverterMoedaServices(); //variave
                    var resultado = moeda.ConverterDolarEmReal(dolar);
                    lblPrimeiroValor.Text = $"{dolar} {MoedaHelper.Dolar}";
                    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
                    break;

            case Euro:
                    MessageBox.Show("123");
                    lblPrimeiroValor.Text = $"1 {MoedaHelper.Euro} igual a:";
                    lblSegundoValor.Text = $"6,12 {MoedaHelper.Real}";

                    var euro = decimal.Parse(txtValorConverterReal.Text);


                    var moeda2 = new ConverterMoedaServices(); //variave
                    var resultado2 = moeda2.ConverterDolarEmReal(euro);
                    lblPrimeiroValor.Text = $"{euro} {MoedaHelper.Euro}";
                    lblSegundoValor.Text = $"{resultado2} {MoedaHelper.Euro}";

                    break;
            }
        }
    }
}
