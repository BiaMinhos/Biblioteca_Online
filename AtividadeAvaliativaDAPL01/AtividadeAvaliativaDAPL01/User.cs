using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace AtividadeAvaliativaDAPL01
{
     class User
    {
        private string path = @"../../../users.txt";
        
        //cria o novo usuário
        public void CreateAccount (UserDTO usuario)
        {
            StoreUser(usuario);  
        }

        public bool ExistUser(string login, string password)
        {
            string lines = File.ReadAllText(path);
            if (lines.Length > 0 && lines.Contains("Login:" + login + ";" + "Password:" + password))
            {
                return true;
            }
            return false;

        }

        //salva os dados do usuário no arquivo .txt
        private void StoreUser (UserDTO usuario)
        {
            
            if (File.Exists(path) == false)
            {
                File.Create(path);
            }

            File.AppendAllText(path, usuario.ToString()+ "\r\n");

        }
        public string GeneratePassword()
        {
            string avaliable_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%";
            char[] characters = new char[8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                characters[i] = avaliable_chars[random.Next(0, avaliable_chars.Length)];
            }
            return new string(characters);

        }

    }
}
