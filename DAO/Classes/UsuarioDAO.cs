using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Interfaces;
using Model;

namespace DAO
{
    public class UsuarioDao : IDAO<Usuario>, IDisposable
    {
        private IConnection connection;

        public UsuarioDao(IConnection connection)
        {
            this.connection = connection;
        }

        public void Atualizar(Usuario model)
        {
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = ("update usuario set login=@login, senha=@senha, nome=@nome, documento=@documento, tipoacesso=@tipoAcesso where id=@id");

                comando.Parameters.Add("@login", SqlDbType.Text).Value = model.Login;
                comando.Parameters.Add("@senha", SqlDbType.Text).Value = model.Senha;
                comando.Parameters.Add("@ID", SqlDbType.Text).Value = model.ID;
                comando.Parameters.Add("@nome", SqlDbType.Text).Value = model.ID;
                comando.Parameters.Add("@documento", SqlDbType.Text).Value = model.ID;
                comando.Parameters.Add("@tipoAcesso", SqlDbType.Text).Value = model.ID;
                comando.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Usuario Inserir(Usuario model)
        {
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into usuario(login, senha, nome, documento, tipoacesso) values" +
                                      " (@login,@senha,@nome,@documento,@tipoAcesso); Select @Identity";

                comando.Parameters.Add("@login", SqlDbType.Text).Value = model.Login;
                comando.Parameters.Add("@senha", SqlDbType.Text).Value = model.Senha;
                comando.Parameters.Add("@nome", SqlDbType.Text).Value = model.Senha;
                comando.Parameters.Add("@documento", SqlDbType.Text).Value = model.Senha;
                comando.Parameters.Add("@tipoAcesso", SqlDbType.Text).Value = model.Senha;

                model.ID = int.Parse(comando.ExecuteScalar().ToString());
            }
            return model;
        }

        public Usuario LocalizarPorLogin(params object[] keys)
        {
            Usuario usuario = null;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select id, login, senha from usuario where id = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = keys[0];

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        usuario = new Usuario();
                        usuario.ID = reader.GetInt32(0);
                        usuario.Login = reader.GetString(1);
                        usuario.Senha = reader.GetString(2);
                    }
                }
            }
            return usuario;
        }

        public bool Remover(Usuario model)
        {
            Boolean retornar = false;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "delete from usuario where id=@id";

                comando.Parameters.Add("@id", SqlDbType.Int).Value = model.ID;

                if (comando.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }
            }
            return retornar;
        }
    }
}
