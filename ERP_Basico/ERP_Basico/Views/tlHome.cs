using ERP_Basico.Controllers;
using ERP_Basico.Models;
using ERP_Basico.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ERP_Basico
{
    public partial class tlHome : Form

    {
        public string Tipo = null;
        public Cliente clienteSelecao;
        public Funcionario funcionarioSelecao;
        private readonly string _roleDoFuncionario;
        public tlHome(string role)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false;
            this.MinimumSize = new Size(930, 530);
            _roleDoFuncionario = role;
            switch (role)
            {
                case ("User"):
                    novoPedidoToolStripMenuItem.Visible = false;
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    pedidosToolStripMenuItem.Visible = false;
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
            tlCadastroCliente pedidos = new tlCadastroCliente("Cadastrar", null);
            pedidos.ShowDialog();

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
            ChamarTelaHome("Funcionario");
        }
        private void toolClientes_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro("Visualizar", RecuperarCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro("Cadastrar", null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro("Alterar", RecuperarCliente());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportarParaCSV(dgvRegistros, "RegistrosExportados");
        }
        #region Funções

        #region ExportarCSV
        private void ExportarParaCSV(DataGridView dgv, string nomeArquivo)
        {
            const string Separador = ";";

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar, faça uma pesquisa.", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivos CSV (*.csv)|*.csv";
            sfd.FileName = nomeArquivo;
            sfd.Title = "Salvar Registros como CSV (Separador: Ponto e Vírgula)";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder csv = new StringBuilder();

                    string header = "";
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        header += "\"" + dgv.Columns[i].HeaderText.Replace("\"", "\"\"") + "\"";

                        if (i < dgv.Columns.Count - 1)
                        {
                            header += Separador;
                        }
                    }
                    csv.AppendLine(header);

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string line = "";
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            object cellValue = row.Cells[i].Value;
                            string cellString = cellValue != null ? cellValue.ToString() : "";
                            cellString = "\"" + cellString.Replace("\"", "\"\"") + "\"";

                            line += cellString;

                            if (i < dgv.Columns.Count - 1)
                            {
                                line += Separador;
                            }
                        }
                        csv.AppendLine(line);
                    }

                    File.WriteAllText(sfd.FileName, csv.ToString(), Encoding.UTF8);

                    MessageBox.Show("Dados exportados com sucesso!", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro durante a exportação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Pesquisar
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
        #endregion

        #region Recuperar

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
        #endregion

        #region Selecionar

        private void Selecionar()
        {
            clienteSelecao = RecuperarCliente();
            if (clienteSelecao != null)
                this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region Excluir
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
        #endregion

        #region ChamarTela
        public void ChamarTelaCadastro(string acao, Cliente cliente)
        {
            tlCadastroCliente frm = new tlCadastroCliente(acao, cliente);
            frm.ShowDialog();
            frm.AtualizarMensagem(acao);

            if (acao != "Visualizar")
                PesquisarCliente();
        }
        #endregion

        public void ChamarTelaHome(string tipo)
        {
            switch (tipo)
            {
                case ("Cliente"):
                    tlHome frm = new tlHome(_roleDoFuncionario);
                    frm.ShowDialog();
                    break;
                case ("Funcionario"):
                    tlHomeFuncionario frm2 = new tlHomeFuncionario(_roleDoFuncionario);
                    frm2.ShowDialog();
                    break;
                case ("Produto"):
                    tlHomeProduto frm3 = new tlHomeProduto(_roleDoFuncionario);
                    frm3.ShowDialog();
                    break;
                case ("Fornecedor"):
                    tlHomeFornecedor frm4 = new tlHomeFornecedor(_roleDoFuncionario);
                    frm4.ShowDialog();
                    break;
                case ("Pedido"):
                    tlHomePedido frm5 = new tlHomePedido(_roleDoFuncionario);
                    frm5.ShowDialog();
                    break;
            }
        }
        #endregion

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamarTelaHome("Produto");
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamarTelaHome("Fornecedor");
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}



