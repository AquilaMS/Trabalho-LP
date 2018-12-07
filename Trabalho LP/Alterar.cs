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
    public partial class Alterar : Form
    {
        List<Cliente> lista = new List<Cliente>();
        List<DVD> listad = new List<DVD>();
        public Alterar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Critica crit = new Critica();
            if (crit.vazio(txb_nome.Text)){ 
                cmb_cliente.Items.Clear();
                BD bdobj = new BD();

                bdobj.conecta();

                lista = bdobj.AlterarDados(txb_nome.Text);
                cmb_cliente.Items.Clear();

                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        cmb_cliente.Items.Add(lista[i].nome);
                    }
                }
            }
        }

        private void Alterar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_clientenome.Text = lista[cmb_cliente.SelectedIndex].nome;
            txb_clientecpf.Text = lista[cmb_cliente.SelectedIndex].cpf;
            
            dt_clientenascimento.Value = lista[cmb_cliente.SelectedIndex].nascimento;
            dt_clientedata.Value = lista[cmb_cliente.SelectedIndex].cadastro;
            txb_clientegenero.Text = lista[cmb_cliente.SelectedIndex].generofavorito;
            txb_idcliente.Text = lista[cmb_cliente.SelectedIndex].id;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fnome = txb_clientenome.Text;
            string fcpf =txb_clientecpf.Text;
            string fgenero = txb_clientegenero.Text;
            DateTime fnascimento = dt_clientenascimento.Value;
            DateTime fcadastro = dt_clientedata.Value;
            int id = Convert.ToInt32(txb_idcliente.Text);

            BD bdobj = new BD();
            bdobj.conecta();
            Cliente clienteobj = new Cliente(fnome, fcpf, fgenero, fnascimento, fcadastro, id.ToString());
            
             Critica crit = new Critica();
            if (!crit.letra(txb_clientecpf.Text) && crit.vazio(txb_clientecpf.Text) && crit.digito(txb_clientecpf.Text) && crit.letra_digito(txb_clientecpf.Text))
            {
                bool retorno = bdobj.AtualizarCliente(clienteobj);
                if (retorno)
                {
                    MessageBox.Show("Cliente alterado com SUCESSO");
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

        private void btn_alterardvd_Click(object sender, EventArgs e)
        {
            string ftitulo = txb_titulo.Text;
            DateTime fdata = dt_lancamento.Value;
            string fgenero = txb_genero.Text;
            string fdiretor = txb_diretor.Text;
            string fduracao = dt_duracao.Text;
            string fidade = cmb_idade.Text;
            string id = txb_iddvd.Text;


            //ftitulo, fdata, fgenero, fdiretor, fduracao, fidade, id.ToString()
            BD bdobj = new BD();
            bdobj.conecta();
            DVD dvdobj = new DVD(ftitulo, fdata, fgenero, fdiretor, fduracao, fidade, id);
            bool retorno = bdobj.AtualizarDVD(dvdobj);

            if (retorno)
            {
                MessageBox.Show("DVD alterado com SUCESSO");
            }else if(retorno == false)
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void cmb_dvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_titulo.Text = listad[cmb_dvd.SelectedIndex].titulo;
            dt_lancamento.Value = listad[cmb_dvd.SelectedIndex].lancamento;
            txb_genero.Text = listad[cmb_dvd.SelectedIndex].genero;

            txb_diretor.Text = listad[cmb_dvd.SelectedIndex].diretor;
            dt_duracao.Text = listad[cmb_dvd.SelectedIndex].duracao;
            cmb_idade.Text = listad[cmb_dvd.SelectedIndex].classificacao;

            txb_iddvd.Text = listad[cmb_dvd.SelectedIndex].id;
        }

        private void btn_dvd_Click(object sender, EventArgs e)
        {
            cmb_dvd.Items.Clear();
            BD bdobj = new BD();

            bdobj.conecta();

            listad = bdobj.AlterarDVD(txb_dvd.Text);
            cmb_dvd.Items.Clear();

            if (listad.Count > 0)
            {
                for (int i = 0; i < listad.Count; i++)
                {
                    cmb_dvd.Items.Add(listad[i].titulo);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string id = txb_idcliente.Text;
            BD bdobj = new BD();
            bdobj.conecta();
            Cliente dvdobj = new Cliente(id);
            bool retorno = bdobj.ExcluirCliente(dvdobj);

            if (retorno)
            {
                MessageBox.Show("Cliente excluido");
            }
            else if (retorno == false)
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = txb_iddvd.Text;
            BD bdobj = new BD();
            bdobj.conecta();
            DVD dvdobj = new DVD(id);
            bool retorno = bdobj.ExcluirDVD(dvdobj);

            if (retorno)
            {
                MessageBox.Show("Dvd excluido");
            }
            else if (retorno == false)
            {
                MessageBox.Show("Algo deu errado");
            }
        }
    }
}
