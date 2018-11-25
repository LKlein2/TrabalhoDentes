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
        private string nome;
        private string documento;
        private int tipoAcesso; 
        // 1 - Administrador.
        // 2 - Odontologista.
        // 3 - Secretaria.
        // 4 - Paciente.

        public Usuario() { }

        public Usuario(string login, string senha, string nome, string documento, int tipoAcesso)
        {
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.documento = documento;
            this.tipoAcesso = tipoAcesso;
        }

        public int ID { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Documento { get => documento; set => documento = value; }
        public int TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
    }
}
