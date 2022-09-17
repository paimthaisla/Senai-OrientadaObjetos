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

            var dolar = float.Parse(txtValorAtualDolar.Text);
            var real = float.Parse(txtValorConverterReal.Text);

            var resultado = dolar * real;
            var mensagem = resultado.ToString();
            string titulo = " Valor Convertido";
            MessageBox.Show(mensagem, titulo);

        }

    }
}
