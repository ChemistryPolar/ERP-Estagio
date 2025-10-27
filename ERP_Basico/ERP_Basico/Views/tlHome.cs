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
        public Cliente clienteSelecao;
        public tlHome(string role)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false;
            this.MinimumSize = new Size(930, 530);

            switch (role)
            {
                case ("User"):
                    clienteToolStripMenuItem.Visible = false;
                    fornecedorToolStripMenuItem.Visible = false;
                    funcionárioToolStripMenuItem.Visible = false;
                    produtosToolStripMenuItem1.Visible = false;
                    novoPedidoToolStripMenuItem.Visible = false;
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    pedidosToolStripMenuItem.Visible = false;
                    adicionarToolStripMenuItem.Visible = false;
                    break;
                case ("Admin"):
                    break;
            }
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
            //  ChamarTelaCadastro("Cliente", "Cadastrar");

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  ChamarTelaCadastro("Fornecedor", "Cadastrar");
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  ChamarTelaCadastro("Funcionario", "Cadastrar");

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


        private void toolFuncionarios_Click(object sender, EventArgs e)
        {
            //FuncionarioController funcionarioController = new FuncionarioController();
        }
        private void PesquisarCliente()
        {

            ClienteController clienteController = new ClienteController();
            ClienteCollection clienteCollection = new ClienteCollection();

            dgvRegistros.DataSource = null;
            clienteCollection = clienteController.PesquisarClienteAll();
            dgvRegistros.DataSource = clienteCollection;

            dgvRegistros.Update();
            dgvRegistros.Refresh();
        }

        private void toolClientes_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }
        private Cliente RecuperarCliente()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum item selecionado.", "Informação",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return dgvRegistros.SelectedRows[0].DataBoundItem as Cliente;
        }

        private void ExcluirCliente()
        {
            Cliente clienteSelecionado = RecuperarCliente();

            if (clienteSelecionado != null)
            {
                if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    ClienteController clienteController = new ClienteController();

                    if (clienteController.ApagarCliente(clienteSelecionado.IdCliente) > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso.",
                            "Informação", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        PesquisarCliente();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o regsitro.",
                            "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
        }
        public void ChamarTelaCadastro(string tipo, string acao, Cliente cliente)
        {
            tlCadastro frm = new tlCadastro(tipo, acao, cliente);
            frm.ShowDialog();
            frm.AtualizarMensagem(tipo + acao);

            if (acao != "Visualizar")
                PesquisarCliente();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro("Cliente", "Visualizar", RecuperarCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar();
        }
        private void Selecionar()
        {
            clienteSelecao = RecuperarCliente();
            if (clienteSelecao != null)
                this.DialogResult = DialogResult.OK;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro("Cliente", "Alterar", RecuperarCliente());
        }
    }
}



