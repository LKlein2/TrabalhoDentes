using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IAdministrativel
    {
        Usuario criarUsuario(string login, string senha, string nome, string documento, int tipoAcesso);

        int idCriador();

        int tipoCriador();
    }
}
