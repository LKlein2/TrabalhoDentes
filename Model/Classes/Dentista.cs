using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dentista : IAdministrativel, IAutenticavel
    {
        private int Id;
        private Usuario usuario;

        public Dentista()
        {

        }

        public Dentista(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public Usuario Usuario { get => usuario; set => usuario = value; }
        public int Id1 { get => Id; set => Id = value; }

        public string Autenticacao()
        {
            return this.usuario.Nome + " - " + " dentista.";
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

        public int tipoCriador()
        {
            return this.Usuario.TipoAcesso;
        }
    }
}
