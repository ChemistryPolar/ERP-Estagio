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
        public Funcionario funcionarioSelecao;
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
            ChamarTelaCadastro("Cliente", "Visualizar", RecuperarCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ChamarTelaCadastro("Cliente", "Alterar", RecuperarCliente());
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
        public void ChamarTelaCadastro(string tipo, string acao, Cliente cliente)
        {
            tlCadastro frm = new tlCadastro(tipo, acao, cliente);
            frm.ShowDialog();
            frm.AtualizarMensagem(tipo + acao);

            if (acao != "Visualizar")
                PesquisarCliente();
        }
        #endregion

        #endregion
    }
}



