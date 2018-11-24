using DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Classes
{
    public class Connection : IConnection, IDisposable
    {
        public SqlConnection Abrir()
        {
            throw new NotImplementedException();
        }

        public SqlConnection Buscar()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Fechar()
        {
            throw new NotImplementedException();
        }
    }
}
