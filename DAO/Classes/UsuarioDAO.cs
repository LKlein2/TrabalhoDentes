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
                string sql;
                sql = MontaSqlUpdate(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = (sql);

                comando.Parameters.Add("@login", SqlDbType.Text).Value = model.Login;
                comando.Parameters.Add("@senha", SqlDbType.Text).Value = model.Senha;
                comando.Parameters.Add("@ID", SqlDbType.Text).Value = model.ID;
                if (model.Nome != null) comando.Parameters.Add("@nome", SqlDbType.Text).Value = model.Nome;
                if (model.Documento != null) comando.Parameters.Add("@documento", SqlDbType.Text).Value = model.Documento;
                if (model.TipoAcesso != 0) comando.Parameters.Add("@tipoAcesso", SqlDbType.Text).Value = model.TipoAcesso;
                if (model.DataCadastro != null) comando.Parameters.Add("datacadastro", SqlDbType.DateTime).Value = model.DataCadastro;

                comando.ExecuteNonQuery();
            }
        }

        private string MontaSqlUpdate (Usuario usuario)
        {
            string sql;
            sql = "update usuario set ";
            sql += "login=@login ";
            sql += ", senha=@senha ";
            if (usuario.Nome != null)           sql += ", nome=@nome ";
            if (usuario.Documento != null)      sql += ", documento=@documento ";
            if (usuario.TipoAcesso != 0)        sql += ", tipacesso=@tipoacesso ";
            if (usuario.DataCadastro != null)   sql += ", datacadastro=@datacadastro ";

            return sql;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Usuario Inserir(Usuario model)
        {
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql = MontaSqlInsert(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.Parameters.Add("@login", SqlDbType.Text).Value = model.Login;
                comando.Parameters.Add("@senha", SqlDbType.Text).Value = model.Senha;
                comando.Parameters.Add("@nome", SqlDbType.Text).Value = model.Senha;
                if (model.Documento != null)
                    comando.Parameters.Add("@documento", SqlDbType.Text).Value = model.Senha;
                if (model.TipoAcesso != 0)
                    comando.Parameters.Add("@tipoAcesso", SqlDbType.Int).Value = model.TipoAcesso;
                if (model.DataCadastro != null)
                    comando.Parameters.Add("@datacadastro", SqlDbType.DateTime).Value = model.DataCadastro;
                if (model.Criador != null)
                    comando.Parameters.Add("@idcriador", SqlDbType.Int).Value = model.Criador.idCriador();
                if (model.Criador != null)
                    comando.Parameters.Add("@tipocriador", SqlDbType.Int).Value = model.Criador.tipoCriador();
                if (model.Endereco != null)
                    comando.Parameters.Add("@endereco", SqlDbType.Text).Value = model.Endereco;
                if (model.Contato != null)
                    comando.Parameters.Add("@contato", SqlDbType.Text).Value = model.Contato;
                if (model.DataNascimento != null)
                    comando.Parameters.Add("@dataNascimento", SqlDbType.DateTime).Value = model.DataNascimento;

                comando.ExecuteScalar();

            }
            return model;
        }

        private string MontaSqlInsert(Usuario model)
        {
            string sql;
            sql = "insert into usuario(login, senha, nome";
            if (model.Documento != null)
                sql += ", documento ";
            if (model.TipoAcesso != 0)
                sql += ", tipoAcesso";
            if (model.DataCadastro != null)
                sql += ", datacadastro ";
            if (model.Criador != null)
                sql += ", idCriador ";
            if (model.Criador != null)
                sql += ", tipoCriador ";
            if (model.Endereco != null)
                sql += ", endereco ";
            if (model.Contato != null)
                sql += ", contato ";
            if (model.DataNascimento != null)
                sql += ", dataNascimento";
            sql += ") values (";
            sql += "@login, @senha, @nome";
            if (model.Documento != null)
                sql += ", @documento ";
            if (model.TipoAcesso != 0)
                sql += ", @tipoAcesso";
            if (model.DataCadastro != null)
                sql += ", @datacadastro ";
            if (model.Criador != null)
                sql += ", @idCriador ";
            if (model.Criador != null)
                sql += ", @tipoCriador ";
            if (model.Endereco != null)
                sql += ", @endereco ";
            if (model.Contato != null)
                sql += ", @contato ";
            if (model.DataNascimento != null)
                sql += ", @dataNascimento";
            sql += ");";

            return sql;
        }

        public Usuario LocalizarPorLogin(string login, string senha)
        {
            Usuario usuario = null;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select id, login, senha, nome, documento, tipoacesso from usuario where login = @login and senha = @senha";
                comando.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        usuario = new Usuario();
                        reader.Read();
                        usuario.ID = reader.GetInt32(0);
                        usuario.Login = reader.GetString(1);
                        usuario.Senha = reader.GetString(2);
                        usuario.Nome = reader.GetString(3);
                        usuario.Documento = reader.GetString(4);
                        usuario.TipoAcesso = reader.GetInt32(5);
                    }
                }
            }
            return usuario;
        }

        public Usuario LocalizarPorId(int id)
        {
            Usuario usuario = null;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select id, login, senha, nome, documento, tipoacesso, datacadastro, endereco, contato, dataNascimento from usuario where id = @id";
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        usuario = new Usuario();
                        reader.Read();
                        usuario.ID = reader.GetInt32(0);
                        usuario.Login = reader.GetString(1);
                        usuario.Senha = reader.GetString(2);
                        usuario.Nome = reader.GetString(3);
                        usuario.Documento = reader.GetString(4);
                        usuario.TipoAcesso = reader.GetInt32(5);
                        usuario.DataCadastro = reader.GetDateTime(6);
                        usuario.Endereco = reader.GetString(7);
                        usuario.Contato = reader.GetString(8);
                        usuario.DataNascimento = reader.GetDateTime(9);
                        

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
