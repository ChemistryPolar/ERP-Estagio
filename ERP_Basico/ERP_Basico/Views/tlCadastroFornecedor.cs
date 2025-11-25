using ERP_Basico.Controllers;
using ERP_Basico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Basico.Views
{
    public partial class tlCadastroFornecedor : Form
    {
        Fornecedor fornecedorSelecionado;
        public tlCadastroFornecedor(string _acao, Fornecedor fornecedor)
        {
            InitializeComponent();
            string acao = _acao;
            TelaCadastro(acao);
            Cadastrar();
            labelCPF.Visible = false;
            txtCPFCad.Visible = false;
            radioAdm.Visible = false;
            radioFun.Visible = false;
            txtUser.Visible = false;
            txtPassword.Visible = false;
            labelUser.Visible = false;
            labelPassword.Visible = false;
            txtSetorCad.Visible = false;
            labelSetor.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public Funcionario funcionarioSelecao;
        public void TelaCadastro(string acao)
        {
            switch (acao)
            {
                case ("Visualizar"):
                    btnAlterar.Visible = false;
                    btnCadastrar.Visible = false;
                    CarregarDados();
                    break;
                case ("Cadastrar"):
                    btnAlterar.Visible = false;
                    break;
                case ("Alterar"):
                    btnCadastrar.Visible = false;
                    CarregarDados();
                    break;

            }
        }
        private void Cadastrar()
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.FornecedorNome = txtNomeCad.Text;
            fornecedor.FornecedorEmail = txtEmailCad.Text;
            fornecedor.FornecedorTel = txtTelCad.Text;
            fornecedor.FornecedorEndereco = txtEnderecoCad.Text;
            fornecedor.FornecedorCNPJ = txtCPFCad.Text;
            FornecedorController fornecedorController = new FornecedorController();
            int IdFornecedor = 0;

            IdFornecedor = fornecedorController.InserirFornecedor(fornecedor);

            MessageBox.Show("Fornecedor cadastrado com sucesso");
            this.Close();
        }


        private void Salvar()
        {
            int IdFornecedor = 0;
            Fornecedor fornecedor = new Fornecedor();

            int.TryParse(labelId.Text, out IdFornecedor);
            fornecedor.IdFornecedor = IdFornecedor; 

            fornecedor.FornecedorNome = txtNomeCad.Text;
            fornecedor.FornecedorEmail = txtEmailCad.Text;
            fornecedor.FornecedorTel = txtTelCad.Text;
            fornecedor.FornecedorCNPJ = txtCPFCad.Text;
            fornecedor.FornecedorEndereco = txtEnderecoCad.Text;


            FornecedorController fornecedorController = new FornecedorController(); 

            fornecedorController.AlterarFornecedor(fornecedor);

            MessageBox.Show("Fornecedor alterado com sucesso");
            this.Close();
        }

        private void CarregarDados()
        {
            labelId.Text = fornecedorSelecionado.IdFornecedor.ToString();
            txtNomeCad.Text = fornecedorSelecionado.FornecedorNome;
            txtEmailCad.Text = fornecedorSelecionado.FornecedorEmail;
            txtTelCad.Text = fornecedorSelecionado.FornecedorTel;
            txtCPFCad.Text = fornecedorSelecionado.FornecedorCNPJ;
            txtEnderecoCad.Text = fornecedorSelecionado.FornecedorEndereco;
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
            //fun.ChamarTelaCadastro("Cliente", "Cadastrar", Cliente);

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // fun.ChamarTelaCadastro("Fornecedor", "Cadastrar");
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  fun.ChamarTelaCadastro("Fornecedor", "Cadastrar");

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Cadastrar();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}

