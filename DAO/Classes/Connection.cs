using DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Classes
{
    public class Connection : IConnection, IDisposable
    {
        private SqlConnection connection;

        public Connection()
        {
           // connection = new SqlConnection("Data Source=DESKTOP-H7OTOKV; Initial Catalog=toothsdb; Integrated Security=True");
            connection = new SqlConnection("Data Source=DESKTOP-1S76M2V; Initial Catalog=tooths; Integrated Security=True");
        }

        public SqlConnection Abrir()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection Buscar()
        {
            return this.Abrir();
        }

        public void Fechar()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void Dispose()
        {
            this.Fechar();
            GC.SuppressFinalize(this);
        }
    }
}
