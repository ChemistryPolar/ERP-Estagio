using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ERP_Basico
{
    public partial class tlHome : Form
    {
        public tlHome()
        {
            InitializeComponent();
            this.MinimumSize = new Size(930, 530);
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlPedidos pedidos = new tlPedidos();
            pedidos.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Cliente");
            cadastro.ShowDialog();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Fornecedor");
            cadastro.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Funcionário");
            cadastro.ShowDialog();

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tlCadastProdut cadastProdut = new tlCadastProdut();
            cadastProdut.ShowDialog();
        }

        private void logoofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}

