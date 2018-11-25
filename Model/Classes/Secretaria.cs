using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Secretaria : Usuario, IAdministrativel, IAutenticavel
    {
        private Usuario usuario;

        public Secretaria(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public string Autenticacao()
        {
            return this.Usuario.Nome + " - " + " secretaria.";
        }

        public Usuario criarUsuario(string login, string senha, string nome, string documento, int tipoAcesso)
        {
            Usuario u = new Usuario(login, senha, nome, documento, tipoAcesso);
            u.DataCadastro = DateTime.Now;
            u.Criador = this;
            return u;
        }

        public int idCriador()
        {
            return this.Usuario.ID;
        }

        public int idUsuario()
        {
            return this.Usuario.ID;
        }

        public int tipoCriador()
        {
            return this.Usuario.TipoAcesso;
        }

        public int tipoUsuario()
        {
            return this.Usuario.TipoAcesso;
        }
    }
}
