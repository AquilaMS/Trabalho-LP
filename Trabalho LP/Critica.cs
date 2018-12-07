using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP
{
    class Critica
    {
        public bool digito(string texto)
        {
            bool retorno = true;//cria uma variável do tipo booleana
            char[] c = texto.ToCharArray();//transforma a string de entrada em um vetor de char
            for (int i = 0; i < c.Count(); i++)//percorre todo o vetor
            {
                if (!char.IsDigit(c[i]))//prossegue se p caracter não for um digito
                {
                    retorno = false;//como encontrou um caracter que não é um digito a varíavel booleana recebe false
                    break;//para a execução do for
                }
            }
            return retorno;
        }

        public bool letra(string texto)
        {
            bool retorno = true;
            char[] c = texto.ToCharArray();
            for (int i = 0; i < c.Count(); i++)
            {
                if (!char.IsLetter(c[i]))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        public bool letra_digito(string texto)
        {
            bool retorno = true;
            char[] c = texto.ToCharArray();
            for (int i = 0; i < c.Count(); i++)
            {
                if (!char.IsLetterOrDigit(c[i]))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        public bool letra_espaco(string texto)
        {
            bool retorno = true;
            char[] c = texto.ToCharArray();
            for (int i = 0; i < c.Count(); i++)
            {
                if (!char.IsLetter(c[i]) && !char.IsWhiteSpace(c[i]))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public bool vazio(string texto)
        {
            bool retorno = true;
            int tamanho = texto.Length;
            if (tamanho == 0)
                retorno = false;

            return retorno;
        }

        public bool digito_virgula(string texto)
        {
            bool retorno = true;
            char[] c = texto.ToCharArray();
            for (int i = 0; i < c.Count(); i++)
            {
                if (char.IsDigit(c[i]) == false && c[i] != ',')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public bool letra_espaco_virgula(string texto)
        {
            bool retorno = true;
            char[] c = texto.ToCharArray();
            for (int i = 0; i < c.Count(); i++)
            {
                if (char.IsLetter(c[i]) == false && char.IsWhiteSpace(c[i]) == false && c[i] != ',')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
    }
}
