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
    public partial class Venda : Form
    {
        List<Cliente> lista = new List<Cliente>();
        List<DVD> listad = new List<DVD>();
        public Venda()
        {
            InitializeComponent();
        }

        private void btn_buscarcliente_Click(object sender, EventArgs e)
        {
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

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_nome.Text = lista[cmb_cliente.SelectedIndex].nome;
            txb_idcliente.Text = lista[cmb_cliente.SelectedIndex].id;
        }

        private void cmb_dvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_dvd.Text = listad[cmb_dvd.SelectedIndex].titulo;
            txb_iddvd.Text = listad[cmb_dvd.SelectedIndex].id;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fdtvenda = dt_venda.Value;
            DateTime fdtretirada = dt_retirada.Value;
            string fidproduto = txb_iddvd.Text;
            string fidcliente = txb_idcliente.Text;
            string fquantidade = txb_qnt.Text;
            BD bdobj = new BD();
            bdobj.conecta();
            Registro venda = new Registro(fidcliente, fidproduto, fquantidade, fdtretirada, fdtvenda);
            bool retorno = bdobj.RegistrarVenda(venda);

            Critica crit = new Critica();

            if (crit.letra(txb_nome.Text) && crit.vazio(txb_nome.Text) && crit.digito(txb_nome.Text) && !crit.letra_digito(txb_nome.Text))
            {
                if (retorno)
                {
                    MessageBox.Show("Venda Registrada com SUCESSO");
                }
                else if (retorno == false)
                {
                    MessageBox.Show("Algo deu errado");
                }
            }
            else
                MessageBox.Show("Caracter ou campo invalido");
            
        }
    }
}
