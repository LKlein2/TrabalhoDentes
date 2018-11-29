using DAO.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Classes
{
    class AgendaDAO : IDAO<Agenda>, IDisposable
    {
        private IConnection connection;

        public AgendaDAO(IConnection connection)
        {
            this.connection = connection;
        }

        public void Atualizar(Agenda model)
        {
            throw new NotImplementedException(); // colocar sql
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Agenda Inserir(Agenda model)
        {
            throw new NotImplementedException(); // colocar sql
        }

        public bool Remover(Agenda model)
        {
            throw new NotImplementedException(); // colocar sql
        }
    }
}
