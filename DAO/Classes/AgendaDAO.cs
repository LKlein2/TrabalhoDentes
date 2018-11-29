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
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Agenda Inserir(Agenda model)
        {
            throw new NotImplementedException();
        }

        public bool Remover(Agenda model)
        {
            throw new NotImplementedException();
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
                        ag.Dentista.Id1 = int.Parse(row["id_dentista"].ToString());
                        ag.Paciente.Id = int.Parse(row["id_paciente"].ToString());
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
            sql += ";";
            return sql;
        }
    }
}
