using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livros.Classes;
using Livros.Enum;

namespace Livros
{
    class Program
    {
        private static LivroRepositorio _livroRepositorio = new LivroRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        ListarLivros();
                        break;

                    case "2":
                        InserirLivro();
                        break;

                    case "3":
                        AtualizarLivro();
                        break;

                    case "4":
                        ExluirLivro();
                        break;

                    case "5":
                        VisualizarLivro();
                        break;

                    case "C":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Olá ! Livraria Hello World ao seu dispor!");
            Console.WriteLine("Informe a opção desejadas: ");

            Console.WriteLine("1- Listar livros");
            Console.WriteLine("2 - Inserir novo livro");
            Console.WriteLine("3 - Atualizar livro");
            Console.WriteLine("4 - Excluir livro");
            Console.WriteLine("5 - Visualizar livro");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine();

            return opcaoUsuario;
        }

        private static void ListarLivros()
        {
            Console.WriteLine("Listar livros");

            var lista = _livroRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há livros");
                return;

            }

            foreach (var item in lista)
            {
                var excluido = item.RetornaExcluido();


                Console.WriteLine("#ID {0} - {1} {2}", item.RetornaId(), item.RetornaTItulo(), (excluido ? "*Excluido*" : ""));

            }

        }

        private static void InserirLivro()
        {
            Console.WriteLine("Inserir novo livro");

            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Genero), i));
            }



            Escreva("Digite o gênero entre as opçoes acima: ");
            var generoId = int.Parse(Console.ReadLine());

            Escreva("Digite o Título da livro: ");
            var titulo = Console.ReadLine();

            Escreva("Digite o nome do autor ");
            var autor = Console.ReadLine();

            Escreva("Digite uma descrição");
            var descricao = Console.ReadLine();

            Escreva("Digite o ano de publicação");
            var ano = int.Parse(Console.ReadLine());

            Livro novoLivro = new Livro(_livroRepositorio.ProximoId(), (Genero)generoId, titulo, descricao, autor, ano);

            _livroRepositorio.Insere(novoLivro);
        }

        private static void AtualizarLivro()
        {
            Escreva("Digite o id da série: ");
            var id = int.Parse(Console.ReadLine());


            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Genero), i));
            }



            Escreva("Digite o gênero entre as opçoes acima: ");
            var generoId = int.Parse(Console.ReadLine());

            Escreva("Digite o Título da livro: ");
            var titulo = Console.ReadLine();

            Escreva("Digite o nome do autor ");
            var autor = Console.ReadLine();

            Escreva("Digite uma descrição");
            var descricao = Console.ReadLine();

            Escreva("Digite o ano de publicação");
            var ano = int.Parse(Console.ReadLine());

            Livro novoLivro = new Livro(_livroRepositorio.ProximoId(), (Genero)generoId, titulo, descricao, autor, ano);

            _livroRepositorio.Atualiza(id, novoLivro);
        }

        private static void ExluirLivro()
        {
            Escreva("Digite o id da livro");
            var id = int.Parse(Console.ReadLine());

            _livroRepositorio.Exclui(id);

            Escreva("Item removido com sucesso");
        }
        private static void VisualizarLivro()
        {
            Escreva("Digite o id do livro");
            var id = int.Parse(Console.ReadLine());

            var livro = _livroRepositorio.RetornaPorId(id);

            Escreva(livro.ToString());
        }

        private static void Escreva(string titulo)
        {
            Console.WriteLine(titulo);
        }
    }
}
