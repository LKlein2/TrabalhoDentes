using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paciente : IAutenticavel
    {
        private string endereco;
        private string telefone;
        private DateTime dataNascimento;
        private Usuario usuario;

        public Paciente() {}

        public Paciente(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public Paciente(Usuario usuario, string endereco, string telefone, DateTime dataNascimento)
        {
            this.Usuario = usuario;
            this.endereco = endereco;
            this.telefone = telefone;
            this.DataNascimento = dataNascimento;
        }

        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public string Autenticacao()
        {
            return this.Usuario.Nome + " - " + " paciente.";
        }

        public int idUsuario()
        {
            return this.Usuario.ID;
        }

        public int tipoUsuario()
        {
            return this.Usuario.TipoAcesso;
        }
    }
}
