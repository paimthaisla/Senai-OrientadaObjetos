using AplicacaoPoo.Estrutural.Windows.Funcionalidades;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form //classe
    {
        public frmPrincipal()  //construtor //identificar p construtor - campos já pré-definidos.9                                                                                                                                                                                                                                                                                          
        {
            InitializeComponent();

        }

        private void btnAbrirFormConversão_Click(object sender, EventArgs e)
        {
            var form = new frmConversãoReal();
            form.Show();
        }

        private void btnAbrirFormPagamento_Click(object sender, EventArgs e)
        {
            var form = new frmComissionamento();
            form.Show();
        }


        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmConversãoReal();
            form.MdiParent = this;
            form.Show();
        }

        private void comissionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmComissionamento();
            form.MdiParent = this;
            form.Show();
        }
    }
}
