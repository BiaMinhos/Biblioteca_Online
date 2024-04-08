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
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            UserDTO userDTO = new UserDTO();

            userDTO.Login = LoginInBox.Text;
            userDTO.Password = PasswordInBox.Text;
            userDTO.Email = EmailInBox.Text;

            if (PasswordInBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("As senhas digitadas são incompatíveis");
            }
            else
            {
                User user = new User();
                user.CreateAccount(userDTO);
                
                EnterPage novoForm5 = new EnterPage();
                this.Hide();
                novoForm5.Show();
            }
           
        }

        private void LoginInBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
