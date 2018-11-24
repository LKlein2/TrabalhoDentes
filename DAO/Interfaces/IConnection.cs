using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO.Interfaces
{
    public interface IConnection
    {
        SqlConnection Abrir();

        SqlConnection Buscar();

        void Fechar();
    }
}
