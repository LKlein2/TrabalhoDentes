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

        public Paciente() { }

        public Paciente(string endereco, string telefone, DateTime dataNascimento)
        {
            this.endereco = endereco;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
        }

        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataNascimento { get => DataNascimento; set => DataNascimento = value; }



        public bool Autentica(string login, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
