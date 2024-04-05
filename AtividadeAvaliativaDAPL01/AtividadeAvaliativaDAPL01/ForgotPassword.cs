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
    }
}
