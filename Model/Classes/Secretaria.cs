using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Secretaria : Usuario, IAdministrativel
    {
        public void criarUsuario(string login, string senha, string nome, string documento, int tipoAcesso)
        {
            throw new NotImplementedException();
        }
    }
}
