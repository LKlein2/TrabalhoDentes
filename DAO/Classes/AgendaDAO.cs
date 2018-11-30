using DAO.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
    public class AgendaDao : IDAO<Agenda>, IDisposable
    {
        private IConnection connection;

        public AgendaDao(IConnection connection)
        {
            this.connection = connection;
        }

        public void Atualizar(Agenda model)
        {
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql;
                sql = MontaSqlUpdate(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = (sql);

                comando.Parameters.Add("@id_dentista", SqlDbType.Int).Value = model.Dentista.Id1;
                comando.Parameters.Add("@id_paciente", SqlDbType.Int).Value = model.Paciente.Id;
                if (model.Observacao_1 != "") comando.Parameters.Add("@observacao_1", SqlDbType.Text).Value = model.Observacao_1;
                comando.Parameters.Add("@dataConsulta", SqlDbType.DateTime).Value = model.DataConsulta.ToShortDateString();
                comando.Parameters.Add("@inicio", SqlDbType.Time).Value = model.Inicio;
                comando.Parameters.Add("@fim", SqlDbType.Time).Value = model.Fim;
                //comando.Parameters.Add("@id", SqlDbType.Int).Value = model.Id;
                string asas = comando.Parameters.ToString();
                comando.ExecuteNonQuery();

            } 
        }

        private string MontaSqlUpdate(Agenda agenda)
        {
            string sql;
            sql = "update agenda set ";
            sql += " id_dentista=@id_dentista ";
            sql += ", id_paciente=@id_paciente ";
            if (agenda.Observacao_1 != "")
                sql += ", observacao_1=@observacao_1 ";
            sql += "where dataConsulta=@dataConsulta and inicio=@inicio and fim=@fim;";

            return sql;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Agenda Inserir(Agenda model)
        {
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql = MontaSqlInsert(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.Parameters.Add("@dataConsulta", SqlDbType.DateTime).Value = model.DataConsulta;
                comando.Parameters.Add("@id_dentista", SqlDbType.Int).Value = model.Dentista.Id1;
                comando.Parameters.Add("@id_paciente", SqlDbType.Int).Value = model.Paciente.Id;
                comando.Parameters.Add("@inicio", SqlDbType.Time).Value = model.Inicio;
                comando.Parameters.Add("@fim", SqlDbType.Time).Value = model.Fim;
                if (model.Observacao_1 != null)
                    comando.Parameters.Add("@observacao_1", SqlDbType.Text).Value = model.Observacao_1;

                comando.ExecuteScalar();
            }
            return model;
        }

        private string MontaSqlInsert(Agenda model)
        {
            string sql;
            sql = "insert into agenda(dataConsulta, id_dentista, id_paciente, inicio, fim ";
            if (model.Observacao_1 != null)
                sql += ", observacao_1 ";
            sql += ") values (";
            sql += "@dataConsulta, @id_dentista, @id_paciente, @inicio, @fim ";
            if (model.Observacao_1 != null)
                sql += ", @observacao_1 ";
            sql += ");";

            return sql;
        }
        
        public bool Remover(Agenda model)
        {
            Boolean retornar = false;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "delete from agenda where id=@id";

                comando.Parameters.Add("@id", SqlDbType.Int).Value = model.Id;

                if (comando.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }
            }
            return retornar;
        }

        public List<Agenda> BuscaListaAgendas(DateTime dataInicial, DateTime dataFinal, Paciente paciente = null, Dentista dentista = null)
        {
            List<Agenda> agendas = new List<Agenda>();

            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql;
                sql = MontaSqlLista(dataInicial, dataFinal, paciente, dentista);
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Parameters.Add("@dataInicial", SqlDbType.DateTime).Value = dataInicial;
                comando.Parameters.Add("@dataFinal", SqlDbType.DateTime).Value = dataFinal;
                if (dentista != null)
                    comando.Parameters.Add("@id_dentista", SqlDbType.Int).Value = dentista.Id1;
                if (paciente != null)
                    comando.Parameters.Add("@id_paciente", SqlDbType.Int).Value = paciente.Id;

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Agenda ag = new Agenda();
                        ag.Dentista = dentista;
                        ag.Paciente = paciente;

                        ag.Id = int.Parse(row["id"].ToString());
                        ag.DataConsulta = DateTime.Parse(row["dataConsulta"].ToString());
                        if (ag.Dentista != null) ag.Dentista.Id1 = int.Parse(row["id_dentista"].ToString());
                        if (ag.Paciente != null) ag.Paciente.Id = int.Parse(row["id_paciente"].ToString());
                        ag.Inicio = row["inicio"].ToString();
                        ag.Fim = row["fim"].ToString();
                        ag.Observacao_1 = row["observacao_1"].ToString();

                        agendas.Add(ag);
                    }
                }
            }

            return agendas;
        }

        private string MontaSqlLista(DateTime dataInicial, DateTime dataFinal, Paciente paciente, Dentista dentista)
        {
            string sql;
            sql = "Select id, dataConsulta, isNull(id_dentista,0) as id_dentista, isNull(id_paciente,0) as id_paciente, inicio, fim, isNull(observacao_1,'') as observacao_1";
            sql += " from agenda where";
            sql += " dataConsulta between @dataInicial and @dataFinal";
            if (dentista != null) sql += " and id_dentista = @id_dentista";
            if (paciente != null) sql += " and id_paciente = @id_paciente";
            sql += " order by dataConsulta, inicio, fim;";
            return sql;
        }

        public Agenda PopularAgenda(Agenda model)
        {
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql = MontaSqlInsert(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.Parameters.Add("@dataConsulta", SqlDbType.DateTime).Value = model.DataConsulta;
                comando.Parameters.Add("@id_dentista", SqlDbType.Int).Value = 0;
                comando.Parameters.Add("@id_paciente", SqlDbType.Int).Value = 0;
                comando.Parameters.Add("@inicio", SqlDbType.Time).Value = model.Inicio;
                comando.Parameters.Add("@fim", SqlDbType.Time).Value = model.Fim;
                comando.Parameters.Add("@observacao_1", SqlDbType.Text).Value = "";

                comando.ExecuteScalar();
            }
            return model;
        }

        private string MontaPopularAgenda(Agenda model)
        {
            string sql;
            sql = "insert into agenda(dataConsulta, inicio, fim ";
            sql += ") values (";
            sql += "@dataConsulta, @inicio, @fim );";

            return sql;
        }

        public bool IsPopulada(DateTime model)
        {
            Boolean retornar = false;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql = MontaIsPopulada(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.Parameters.Add("@dataConsulta", SqlDbType.DateTime).Value = model;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return retornar;
        }

        private string MontaIsPopulada(DateTime model)
        {
            string sql;
            sql = "select distinct(1) from agenda where year(dataConsulta) = Year(@dataConsulta);";

            return sql;
        }

        public bool LocalizarConsulta(Agenda model)
        {
            Boolean retornar = false;
            using (SqlCommand comando = connection.Buscar().CreateCommand())
            {
                string sql;
                sql = MontaLocalizarConsulta(model);
                comando.CommandType = CommandType.Text;
                comando.CommandText = (sql);
                comando.Parameters.Add("@dataConsulta", SqlDbType.DateTime).Value = model.DataConsulta.ToShortDateString();
                //comando.Parameters.Add("@id_dentista", SqlDbType.Int).Value = model.Dentista.Id1;
                //comando.Parameters.Add("@id_paciente", SqlDbType.Int).Value = model.Paciente.Id;
                comando.Parameters.Add("@inicio", SqlDbType.Time).Value = model.Inicio;
                comando.Parameters.Add("@fim", SqlDbType.Time).Value = model.Fim;
                //comando.Parameters.Add("@id", SqlDbType.Int).Value = model.Id;
                //if (model.Observacao_1 != null) comando.Parameters.Add("@observacao_1", SqlDbType.Text).Value = model.Observacao_1;
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private string MontaLocalizarConsulta(Agenda agenda)
        {
            string sql;
            sql = "select 1 ";
            sql += "from agenda ";
            sql += "where ";// id_dentista=@id_dentista ";
            sql += "dataConsulta=@dataConsulta ";
            sql += "and inicio=@inicio ";
            sql += "and fim=@fim;";
            return sql;
        }
    }
}
