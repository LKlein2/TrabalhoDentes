using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IDAO<T>:IDisposable
    {
        T Inserir(T model);

        void Atualizar(T model);

        bool Remover(T model);

        T LocalizarPorCodigo(params Object[] Keys);

        Collection<T> ListarTudo();
    }
}
