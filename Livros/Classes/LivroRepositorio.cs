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
        public List<Livro> ListaLivro { get; } = new List<Livro>();

        public List<Livro> Lista()
        {
            return ListaLivro;
        }

        public Livro RetornaPorId(int id)
        {
            return ListaLivro[id];
        }

        public void Insere(Livro entidade)
        {
            ListaLivro.Add(entidade);
        }

        public void Exclui(int id)
        {
            ListaLivro[id].Excluir();
        }

        public void Atualiza(int id, Livro entidade)
        {
            ListaLivro[id] = entidade;
        }

        public int ProximoId()
        {
            return ListaLivro.Count();
        }
    }
}
