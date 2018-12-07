using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_LP
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string fnome = txb_nome.Text;
            string fcpf = txb_cpf.Text;
            string fgenero = txb_genero.Text;
            DateTime fnascimento = dt_nascimento.Value;
            DateTime fcadastro = dt_cadastro.Value;

            BD bdobj = new BD();
            bdobj.conecta();
            Cliente novo = new Cliente(fnome, fcpf, fgenero, fnascimento, fcadastro);

            Critica crit = new Critica();
            if (!crit.letra(txb_cpf.Text) && crit.vazio(txb_cpf.Text) && crit.digito(txb_cpf.Text) && crit.letra_digito(txb_cpf.Text) && crit.letra(txb_genero.Text) && crit.vazio(txb_genero.Text) && crit.digito(txb_genero.Text) && !crit.letra_digito(txb_genero.Text) && crit.letra(txb_nome.Text) && crit.vazio(txb_nome.Text) && crit.digito(txb_nome.Text) && !crit.letra_digito(txb_nome.Text))
            {


                bool retorno = bdobj.InserirCliente(novo);
                if (retorno == true)
                {

                    MessageBox.Show("Cadastro do cliente efetuado com SUCESSO");

                }
                else if (retorno == false)
                {
                    MessageBox.Show("Algo deu errado");
                }
            }
            else {
                MessageBox.Show("Caracter ou campo invalido");
            }

        }
    }
}
