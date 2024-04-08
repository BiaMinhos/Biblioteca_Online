using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaDAPL01
{
    public partial class ForgotPasswordPage : Form
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void CAPageLabel_Click(object sender, EventArgs e)
        {
            EnterPage novoForm2 = new EnterPage();
            this.Hide();
            novoForm2.Show();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            MailMessage passwordmail = new MailMessage();
            passwordmail.To.Add(EmailBox.Text);
            passwordmail.Subject = "Nova senha gerada automaticamente.";
            passwordmail.From = new MailAddress("livia.guimaraes@edu.etefmc.com.br");
            passwordmail.Body = "Sua nova senha é " + user.GeneratePassword();
        }
        
    }
}
