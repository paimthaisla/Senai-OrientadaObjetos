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

            //Coloca os valores da nossa classe dentro do combobox...
            var list = new List<string>(); ;
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro); 
            list.Add(MoedaHelper.Libras);
            cbxMoeda.DataSource = list;
            cbxMoeda.SelectedIndex = 0;
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
            if (txtValorConverterReal.Text == "") return;

            #region EXEMPLIFICAÇÃO
            //const - único em todo sistema; Configurações padrões;
            #endregion
            var valorEmDolar = Decimal.Parse(txtValorConverterReal.Text);
            var moedaService = new ConverterMoedaServices();

            switch (cbxMoeda.SelectedValue)
            
            {
                case MoedaHelper.Dolar: 
                    {
                       var valorConvertido = moedaService.ConverterDolarEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar}";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }

                case MoedaHelper.Euro: 
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(Decimal.Parse(valorEmDolar));
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro}";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;

                    }

                case MoedaHelper.Libras: 
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(Decimal.Parse(valorEmDolar));
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras}";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
                default:
                   break;


            }
            
        }
    }
}
