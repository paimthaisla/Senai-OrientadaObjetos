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
            txtValorConverterReal.Text = "1";

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
                if (txtValorConverterReal.Text == "")
                {
                    cbxMoeda.Enabled = false;
                    return;
                }
                cbxMoeda.Enabled = true;
                EfetuarConversãoDeMoeda();
        }


        private void cbxMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfetuarConversãoDeMoeda();
        }

        private void EfetuarConversãoDeMoeda()
        {

            if (txtValorConverterReal.Text == "") return;


                try
                {
                    
                    #region Cálculo de Conversão
                    //const - único em todo sistema; Configurações padrões;


                    var valorEmDolar = decimal.Parse(txtValorConverterReal.Text);
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
                                var valorConvertido = moedaService.ConverterEuroEmReal(valorEmDolar);
                                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro}";
                                lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                                break;

                            }

                        case MoedaHelper.Libras:
                            {
                                var valorConvertido = moedaService.ConverterLibraEmReal(valorEmDolar);
                                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras}";
                                lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                                break;
                            }
                        default:
                            break;

                            #endregion
                    }
                }
                catch (Exception)
                {
                MessageBox.Show("Querido usuário,\nVocê precisa informar um valor NUMÉRICO\nEx.:100");
                txtValorConverterReal.Text = String.Empty;
                txtValorConverterReal.Focus();
                }

                }
            }
         }

