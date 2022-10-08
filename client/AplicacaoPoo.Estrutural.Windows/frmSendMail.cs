using MailKit.Net.Smtp;
using MimeKit;
 
namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try
            {
                var mensagem = new MimeMessage();
                mensagem.From.Add(
                    new MailboxAddress(txtNomeCompleto.Text, txtEmail.Text));
                mensagem.To.Add(
                    new MailboxAddress("testesenai2022", "senaiteste2022@gmail.com"));

                mensagem.Subject = txtAssunto.Text;

                mensagem.Body = new TextPart("plain")
                {
                    Text = txtMensagem.Text
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");

                    client.Send(mensagem);
                    client.Disconnect(true);
                }
            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            button1.Enabled = false;


        }
    }
}
