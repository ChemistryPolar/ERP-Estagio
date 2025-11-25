using ERP_Basico.Controllers;
using ERP_Basico.Models;
using ERP_Basico.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Basico
{
    public partial class tlCadastro : Form
    {
        Funcionario funcionarioSelecionado;
        public tlCadastro(string _acao, Funcionario funcionario)
        {
            InitializeComponent();
            string acao = _acao;
            TelaCadastro(acao);
            Cadastrar();
            labelCNPJ.Visible = false;
            txtCNPJCad.Visible = false;
            txtEmailCad.Visible = false;
            labelEmail.Visible = false;
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
                    Funcionario funcionario = new Funcionario();
                    funcionario.FuncionarioNome = txtNomeCad.Text;
                    funcionario.FuncionarioEmail = txtEmailCad.Text;
                    funcionario.FuncionarioTel = txtTelCad.Text;
                    funcionario.FuncionarioCPF = txtCPFCad.Text;
                    funcionario.FuncionarioDatNasc = datetimepickerDatNasc.Value;
                    funcionario.FuncionarioSetor = txtSetorCad.Text;
                    if (radioFun.Checked == true )
                    {
                        funcionario.FuncionarioRole = "User";
                    }else if (radioAdm.Checked == true ) {
                        funcionario.FuncionarioRole = "Adm";
                    }
                        FuncionarioController fincionarioController = new FuncionarioController();
                    int IdFuncionario = 0;
                    IdFuncionario = fincionarioController.InserirFuncionario(funcionario);
                    MessageBox.Show("Funcionario cadastrado com sucesso");
                    this.Close();

            }

                   
        private void Salvar()
        {
            int IdFuncionario = 0;
            Funcionario funcionario = new Funcionario();

            int.TryParse(labelId.Text, out IdFuncionario);
            funcionario.IdFuncionario = IdFuncionario;

            funcionario.FuncionarioNome = txtNomeCad.Text;
            funcionario.FuncionarioEmail = txtEmailCad.Text;
            funcionario.FuncionarioTel = txtTelCad.Text;
            funcionario.FuncionarioCPF = txtCPFCad.Text;
            funcionario.FuncionarioEndereco = txtEnderecoCad.Text;
            funcionario.FuncionarioDatNasc = datetimepickerDatNasc.Value;

            FuncionarioController funcionarioController = new FuncionarioController();

            funcionarioController.AlterarFuncionario(funcionario);

            MessageBox.Show("Funcionário alterado com sucesso");
            this.Close();
        }
        private void CarregarDados()
        {
            labelId.Text = funcionarioSelecionado.IdFuncionario.ToString();
            txtNomeCad.Text = funcionarioSelecionado.FuncionarioNome;
            txtEmailCad.Text = funcionarioSelecionado.FuncionarioEmail;
            txtTelCad.Text = funcionarioSelecionado.FuncionarioTel;
            txtCPFCad.Text = funcionarioSelecionado.FuncionarioCPF;
            txtEnderecoCad.Text = funcionarioSelecionado.FuncionarioEndereco;
            datetimepickerDatNasc.Value = funcionarioSelecionado.FuncionarioDatNasc;
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

