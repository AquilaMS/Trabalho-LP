using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_LP
{
    class DVD
    {
        public string titulo { get; private set; }
        public DateTime lancamento { get; private set; }
        public string duracao { get; private set; }
        public string diretor { get; private set; }
        public string genero { get; private set; }
        public string classificacao { get; private set; }
        public string id { get; private set; }

        public DVD(string _titulo, DateTime _lancamento, string _genero, string _diretor, string _duracao, string _idade)
        {
            titulo = _titulo;
            lancamento = _lancamento;
            genero = _genero;
            diretor = _diretor;
            duracao = _duracao;
            classificacao = _idade;
        }
        public DVD(string _titulo, DateTime _lancamento, string _genero, string _diretor, string _duracao, string _idade, string _id)
        {
            titulo = _titulo;
            lancamento = _lancamento;
            genero = _genero;
            diretor = _diretor;
            duracao = _duracao;
            classificacao = _idade;
            id = _id;
        }

        public DVD( string _id)
        {
            id = _id;
        }
    }
}
