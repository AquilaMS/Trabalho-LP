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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD bdobj = new BD();
            bool retorno = bdobj.conecta();
            MessageBox.Show(retorno.ToString());
        }

        private void cadastrarDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarDVD cdvd = new CadastrarDVD();
            cdvd.Show();
        
        }

        private void cadastrarClenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente formcliente = new CadastrarCliente();
            formcliente.Show();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar formcliente = new Alterar();
            formcliente.Show();
        }

        private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda formcliente = new Venda();
            formcliente.Show();
        }
    }
}
