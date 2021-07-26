using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId();
        void Insere(T entidade);
        void Exclui(Guid id);
        void Atualiza(Guid id, T entidade);
        Guid ProximoId();
    }
}
