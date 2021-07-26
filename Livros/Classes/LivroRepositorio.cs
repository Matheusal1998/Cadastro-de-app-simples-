using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livros.Interfaces;

namespace Livros.Classes
{
    public class LivroRepositorio : IRepositorio<Livro>
    {

        private List<Livro> listaLivro = new List<Livro>();

        public List<Livro> Lista()
        {
            throw new NotImplementedException();
        }

        public Livro RetornaPorId()
        {
            throw new NotImplementedException();
        }

        public void Insere(Livro entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Atualiza(Guid id, Livro entidade)
        {
            throw new NotImplementedException();
        }

        public Guid ProximoId()
        {
            throw new NotImplementedException();
        }
    }
}
