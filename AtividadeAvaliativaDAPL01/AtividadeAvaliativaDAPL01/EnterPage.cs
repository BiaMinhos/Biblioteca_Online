using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaDAPL01
{
    public partial class EnterPage : Form
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void FPPage_Click(object sender, EventArgs e)
        {
            // Criando uma instância do novo formulario
            ForgotPasswordPage novoForm =  new ForgotPasswordPage();
                this.Hide();
            //Exibir o novo formuário
            novoForm.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            HomePage novoForm3 = new HomePage();
            this.Hide();
            novoForm3.Show();
        }

        private void CAPageLabel_Click(object sender, EventArgs e)
        {
            CreateAcc novoForm4 = new CreateAcc();
            this.Hide();
            novoForm4.Show();
        }
    }
}
