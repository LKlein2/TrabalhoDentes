using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Consulta
    {
        private string observacao;

        public Consulta() { }

        public Consulta(string observacao)
        {
            this.observacao = observacao;
        }

        public string Observacao { get => observacao; set => observacao = value; }

    }
}
