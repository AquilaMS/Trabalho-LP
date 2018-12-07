		public bool digito(string texto)
        {
            bool retorno = true;//cria uma vari�vel do tipo booleana
            char[] c = texto.ToCharArray();//transforma a string de entrada em um vetor de char
            for (int i = 0; i < c.Count(); i++)//percorre todo o vetor
            {
                if (!char.IsDigit(c[i]))//prossegue se p caracter n�o for um digito
                {
                    retorno = false;//como encontrou um caracter que n�o � um digito a var�avel booleana recebe false
                    break;//para a execu��o do for
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
                if (char.IsLetter(c[i]) == false && char.IsWhiteSpace(c[i])==false && c[i] != ',')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }