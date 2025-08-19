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

        private void clientecadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Cliente");
            this.Close();
            cadastro.ShowDialog();
        }

        private void fornecedorcadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Fornecedor");
            this.Close();
            cadastro.ShowDialog();
        }

        private void funcionáriocadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Funcionário");
            this.Close();
            cadastro.ShowDialog();
        }

        private void produtocadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastProdut cadastProdut = new tlCadastProdut();
            cadastProdut.ShowDialog();
            this.Close();
        }
    }
}
