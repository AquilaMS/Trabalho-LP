using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trabalho_LP
{
    class BD
    {
        private MySqlConnection bdConn;

        //método para fazer a conexão ao banco de dados
        public bool conecta()
        {
            bool retorno = true; //cria variável de retorno
            bdConn = new MySqlConnection("server=localhost;database=bdlp;uid=root;pwd=''");
            try
            {
                bdConn.Open(); // tenta abrir o banco de dados.
            }
            catch
            {
                retorno = false; //altera a variável de retorno para false se não conseguir conexão.
            }
            return retorno;
        }

        //método para desfazer a conexão com o banco de dados
        public void desconecta()
        {
            bdConn.Close(); //desconecta a base de dados
        }

        public bool cadastroDvd(DVD novo) {

            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("INSERT INTO tab_dvd (titulo, data, genero, diretor, duracao, idade) VALUES (@titulo, @data, @genero, @diretor, @duracao, @idade)", bdConn);
                myobj.Parameters.AddWithValue("@titulo", novo.titulo);
                myobj.Parameters.AddWithValue("@data", novo.lancamento);
                myobj.Parameters.AddWithValue("@genero", novo.genero);
                myobj.Parameters.AddWithValue("@diretor", novo.diretor);
                myobj.Parameters.AddWithValue("@duracao", novo.duracao);
                myobj.Parameters.AddWithValue("@idade", novo.classificacao);
                myobj.ExecuteNonQuery();

            }
            catch {
                retorno = false;
            }

            return retorno;
            
        }

        public bool InserirCliente(Cliente novo) {
            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("INSERT INTO tab_cliente (nome, cpf, generofavorito, nascimento, data_cadastro) VALUES (@nome, @cpf, @genero, @nascimento, @cadastro)", bdConn);
                myobj.Parameters.AddWithValue("@nome", novo.nome);
                myobj.Parameters.AddWithValue("@cpf", novo.cpf);
                myobj.Parameters.AddWithValue("@genero", novo.generofavorito);
                myobj.Parameters.AddWithValue("@nascimento", novo.nascimento);
                myobj.Parameters.AddWithValue("@cadastro", novo.cadastro);
                
                myobj.ExecuteNonQuery();

            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public List<Cliente> AlterarDados(string nome_cliente)
        {
            List<Cliente> ListaAluno = new List<Cliente>();
            MySqlCommand Select = new MySqlCommand("SELECT * FROM tab_cliente WHERE nome LIKE @nome", bdConn);
            Select.Parameters.AddWithValue("@nome", nome_cliente + "%");
            

            MySqlDataReader reader = Select.ExecuteReader();
            while (reader.Read())
            {

                string generof = reader["generofavorito"].ToString();
                string nome = reader["nome"].ToString();
                DateTime nascimento = Convert.ToDateTime(reader["nascimento"].ToString());
                DateTime cadastrocliente = Convert.ToDateTime(reader["data_cadastro"].ToString());
                string CPF = reader["CPF"].ToString();
                string id = reader["id_cliente"].ToString();

                Cliente novo = new Cliente(nome, CPF, generof, nascimento, cadastrocliente, id);
                ListaAluno.Add(novo);
            }

            reader.Close();
            return ListaAluno;
        }

       

        public List<DVD> AlterarDVD(string stdvd)
        {
            List<DVD> Listadvd = new List<DVD>();
            MySqlCommand Select = new MySqlCommand("SELECT * FROM tab_dvd WHERE titulo LIKE @titulo", bdConn);
            Select.Parameters.AddWithValue("@titulo", stdvd + "%");


            MySqlDataReader reader = Select.ExecuteReader();
            while (reader.Read())
            {

                string titulo = reader["titulo"].ToString();
                DateTime data = Convert.ToDateTime(reader["data"].ToString());
                string genero = reader["genero"].ToString();
                string diretor = reader["diretor"].ToString();
                string duracao = reader["duracao"].ToString();
                string idade = reader["idade"].ToString();
                string id = reader["id_dvd"].ToString();

                DVD novo = new DVD(titulo, data, genero, diretor, duracao, idade, id);
                Listadvd.Add(novo);
            }

            reader.Close();
            return Listadvd;
        }

        public bool AtualizarCliente(Cliente novo) {
            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("UPDATE tab_cliente SET nome = @nome, cpf=@cpf, nascimento=@nascimento,generofavorito=@genero, data_cadastro=@cadastro WHERE id_cliente = @id", bdConn);
                myobj.Parameters.AddWithValue("@nome", novo.nome);
                myobj.Parameters.AddWithValue("@cpf", novo.cpf);
                myobj.Parameters.AddWithValue("@nascimento", novo.nascimento);
                myobj.Parameters.AddWithValue("@genero", novo.generofavorito);
                myobj.Parameters.AddWithValue("@cadastro", novo.cadastro);
                myobj.Parameters.AddWithValue("@id", novo.id);
                myobj.ExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public bool AtualizarDVD(DVD novo)
        {
            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("UPDATE tab_dvd SET titulo = @titulo, data=@lancamento, genero=@genero,diretor=@diretor, duracao=@duracao, idade = @idade WHERE id_dvd = @id", bdConn);
                myobj.Parameters.AddWithValue("@titulo", novo.titulo);
                myobj.Parameters.AddWithValue("@lancamento", novo.lancamento);
                myobj.Parameters.AddWithValue("@duracao", novo.duracao);
                myobj.Parameters.AddWithValue("@diretor", novo.diretor);
                myobj.Parameters.AddWithValue("@genero", novo.genero);
                myobj.Parameters.AddWithValue("@idade", novo.classificacao);
                myobj.Parameters.AddWithValue("@id", novo.id);
                myobj.ExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }
        public bool ExcluirDVD(DVD novo)
        {
            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("DELETE FROM tab_dvd WHERE id_dvd=@id", bdConn);
                myobj.Parameters.AddWithValue("@id", novo.id);
                myobj.ExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public bool ExcluirCliente(Cliente novo)
        {
            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("DELETE FROM tab_cliente WHERE id_cliente=@id", bdConn);
                myobj.Parameters.AddWithValue("@id", novo.id);
                myobj.ExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public bool RegistrarVenda(Registro novo)
        {
            bool retorno = true;
            try
            {
                MySqlCommand myobj = new MySqlCommand("INSERT INTO tab_cliente_emprestimo (id_cliente,id_dvd,data_retirada,data_venda, quantidade) VALUES(@idcliente,@iddvd,@retirada,@venda,@qnt)", bdConn);
                myobj.Parameters.AddWithValue("@iddvd", novo.id_dvd);
                myobj.Parameters.AddWithValue("@idcliente", novo.id_cliente);
                myobj.Parameters.AddWithValue("@retirada", novo.retirada);
                myobj.Parameters.AddWithValue("@venda", novo.venda);
                myobj.Parameters.AddWithValue("@qnt", novo.quantidade);
                
                myobj.ExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

    }
}
