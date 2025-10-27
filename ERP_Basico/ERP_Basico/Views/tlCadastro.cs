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
        Cliente clienteSelecionado;
        tlHome fun = new tlHome("Admin");
        public tlCadastro(string _tipo, string _acao, Cliente cliente)
        {
            InitializeComponent();
            clienteSelecionado = cliente;
            string tipo = _tipo;
            string acao = _acao;
            TelaCadastro(tipo, acao);
            Cadastrar(tipo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public Cliente clienteSelecao;
        public void TelaCadastro(string tipo, string acao)
        {
            switch (tipo)
            {
                case ("funcionario"):
                    labelCNPJ.Visible = false;
                    txtCNPJCad.Visible = false;
                    txtEmailCad.Visible = false;
                    labelEmail.Visible = false;
                    break;
                case ("cliente"):
                    labelCNPJ.Visible = false;
                    txtCNPJCad.Visible = false;
                    radioAdm.Visible = false;
                    radioFun.Visible = false;
                    txtUser.Visible = false;
                    txtPassword.Visible = false;
                    labelUser.Visible = false;
                    labelPassword.Visible = false;
                    txtSetorCad.Visible = false;
                    labelSetor.Visible = false;
                    break;
                case ("fornecedor"):
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
                    break;

            }
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
        private void Cadastrar(string tipo)
        {
            switch (label9.Text)
            {
                case ("Cliente"):
                    Cliente cliente = new Cliente();
                    cliente.ClienteNome = txtNomeCad.Text;
                    cliente.ClienteEmail = txtEmailCad.Text;
                    cliente.ClienteTel = txtTelCad.Text;
                    cliente.ClienteCPF = txtCPFCad.Text;
                    cliente.ClienteEndereco = txtEnderecoCad.Text;
                    cliente.ClienteDatNasc = datetimepickerDatNasc.Value;
                    ClienteController clienteController = new ClienteController();
                    int IdCliente = 0;
                    IdCliente = clienteController.InserirCliente(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso");
                    this.Close();
                    break;
            }

        }
        private void Salvar()
        {
            int IdCliente = 0;
            Cliente cliente = new Cliente();
            int.TryParse(labelId.Text, out IdCliente);
            cliente.IdCliente = IdCliente;
            cliente.ClienteNome = txtNomeCad.Text;
            cliente.ClienteEmail = txtEmailCad.Text;
            cliente.ClienteTel = txtTelCad.Text;
            cliente.ClienteCPF = txtCPFCad.Text;
            cliente.ClienteEndereco = txtEnderecoCad.Text;
            cliente.ClienteDatNasc = datetimepickerDatNasc.Value;
            ClienteController clienteController = new ClienteController();
            IdCliente = clienteController.AlterarCliente(cliente);
        }
        private void CarregarDados()
        {
            labelId.Text = clienteSelecionado.IdCliente.ToString();
            txtNomeCad.Text = clienteSelecionado.ClienteNome;
            txtEmailCad.Text = clienteSelecionado.ClienteEmail;
            txtTelCad.Text = clienteSelecionado.ClienteTel;
            txtCPFCad.Text = clienteSelecionado.ClienteCPF;
            txtEnderecoCad.Text = clienteSelecionado.ClienteEndereco;
            datetimepickerDatNasc.Value = clienteSelecionado.ClienteDatNasc;
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

            Cadastrar("Cliente");

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}

