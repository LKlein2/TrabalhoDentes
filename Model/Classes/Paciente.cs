using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paciente
    {
        private string endereco;
        private string telefone;
        private DateTime dataNascimento;
        private Usuario usuario;

        public Paciente() {}

        public Paciente(Usuario usuario, string endereco, string telefone, DateTime dataNascimento)
        {
            this.usuario = usuario;
            this.endereco = endereco;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
        }

        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataNascimento { get => DataNascimento; set => DataNascimento = value; }
    }
}
