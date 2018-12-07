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
    public partial class CadastrarDVD : Form
    {
        public CadastrarDVD()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrardvd_Click(object sender, EventArgs e)
        {
            string ftitulo = txb_titulo.Text;
            DateTime flancamento = dt_lancamento.Value;
            string fduracao = txb_duracao.Text;
            string fgenero = txb_genero.Text;
            string fidade = cb_classificacao.Text;
            string fdiretor = txb_diretor.Text;

            BD objbd = new BD();
            objbd.conecta();
            DVD novo = new DVD(ftitulo, flancamento, fgenero, fdiretor, fduracao, fidade);

            Critica crit = new Critica();

            if (!crit.letra(txb_duracao.Text) && crit.vazio(txb_duracao.Text) && !crit.letra(txb_duracao.Text))
            {
                if (crit.letra(txb_genero.Text) && crit.vazio(txb_genero.Text))
                {
                    bool retorno = objbd.cadastroDvd(novo);
                    if (retorno == true)
                        {
                        MessageBox.Show("DVD cadastrado com SUCESSO");
                        }
                    else
                        {
                        MessageBox.Show("Algo deu errado");
                        }
                    }
                else MessageBox.Show("2");
            }
            else MessageBox.Show("3");
        }
    }
}

