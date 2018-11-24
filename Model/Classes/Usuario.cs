using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string login;
        private string senha;

        public Usuario() { }

        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.senha = senha;
        }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
