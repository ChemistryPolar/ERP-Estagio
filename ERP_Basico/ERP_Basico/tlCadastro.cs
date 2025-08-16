using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Basico
{
    public partial class tlCadastro : Form
    {
        public tlCadastro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void AtualizarMensagem(string loading)
        {
            label9.Text = loading;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.Show();
            cadastro.AtualizarMensagem("Cadastrar Novo Cliente");
            this.Close();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.Show();
            cadastro.AtualizarMensagem("Cadastrar Novo Fornecedor");
            this.Close();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.Show();
            cadastro.AtualizarMensagem("Cadastrar Novo Funcionário");
            this.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastProdut cadastProdut = new tlCadastProdut();
            cadastProdut.Show();
            this.Close();
        }
    }
}
