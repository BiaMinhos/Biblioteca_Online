using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativaDAPL01
{
    public class UserDTO
    {
        private string login;
        private string email;
        private string password;

         public string Login
         {
             get
             {
                 return this.login;
             }
            set
            {
                this.login = value;
            }
         }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }


        public override string ToString() 
        {
            return "Login:" + login + ";" + "Password:" + password + ";" + "Email:" + email;
        }
    }

}
