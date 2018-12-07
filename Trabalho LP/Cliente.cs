using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP
{
    class Cliente
    {
        public string nome { get; private set; }
        public string cpf { get; private set; }
        public string generofavorito { get; private set; }
        public DateTime nascimento { get; private set; }
        public DateTime cadastro { get; private set; }
        public string id { get; private set; }

        public Cliente(string _nome, string _cpf, string _generofavorito, DateTime _nascimento, DateTime _cadastro) {
            nome = _nome;
            cpf = _cpf;
            generofavorito = _generofavorito;
            nascimento = _nascimento;
            cadastro = _cadastro;
        }
        public Cliente(string _nome, string _cpf, string _generofavorito, DateTime _nascimento, DateTime _cadastro, string _id)
        {
            nome = _nome;
            cpf = _cpf;
            generofavorito = _generofavorito;
            nascimento = _nascimento;
            cadastro = _cadastro;
            id = _id;
        }

        public Cliente(string _generofavorito, string _nome, DateTime _nascimento, string _cpf)
        {
            nome = _nome;
            cpf = _cpf;
            generofavorito = _generofavorito;
            nascimento = _nascimento;
            
        }

        public Cliente( string _id)
        {
            id = _id;
        }
    }
}
