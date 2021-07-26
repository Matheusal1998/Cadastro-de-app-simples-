using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livros.Enum;

namespace Livros.Classes
{
    public class Livro : EntidadeBase
    {

        #region Propriedades

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private string Autor { get; set; }
        private int AnoPublicacao { get; set; }
        private bool Excluido { get; set; }
        #endregion

        #region Construtor
        public Livro(int id, Genero genero, string titulo, string descricao, string autor, int anoPublicacao)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Excluido = false;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            var retorno = "";

            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de publicação: " + this.AnoPublicacao + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;

            return retorno;
        }

        public string RetornaTItulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
        #endregion
    }
}
