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
using System.Drawing.Text;
using ERP_Basico.Models;
using ERP_Basico.Controllers;

namespace ERP_Basico
{
    public partial class tlHome : Form
    {
        public string Tipo = null;
        public tlHome(string role)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false;
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
            cadastro.TelaCadastro("cliente");
            cadastro.ShowDialog();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Fornecedor");
            cadastro.TelaCadastro("fornecedor");
            cadastro.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadastro cadastro = new tlCadastro();
            cadastro.AtualizarMensagem("Cadastrar Novo Funcionário");
            cadastro.TelaCadastro("funcionario");
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
        //private itemSelecao RecuperarItem()
        //{
           // if (dgvRegistros.SelectedRows.Count == 0)
           // {
             //   MessageBox.Show("Nenhum item selecionado.", "Informação",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return null;
           // }
          //  else
          //  {
           //     return dgvRegistros.SelectedRows[0].DataBoundItem as Item;
            //}
//}

private void toolFuncionarios_Click(object sender, EventArgs e)
        {
            //FuncionarioController funcionarioController = new FuncionarioController();
        }
        private void toolClientes_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();
        }
    }
}

