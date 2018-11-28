using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Excessões
{
    public sealed class TipoInvalidoException : Exception
    {
        public TipoInvalidoException() : base("Usuario inválido!") { }
        public TipoInvalidoException(String msg) : base(msg) { }
    }
}
