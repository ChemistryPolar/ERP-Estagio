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
    public partial class tlCadastroCliente : Form
    {
        Cliente clienteSelecionado;
        public tlCadastroCliente(string _acao, Cliente cliente)
        {
            InitializeComponent();
            string acao = _acao;
            TelaCadastro(acao);
            Cadastrar();
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
        public Cliente clienteSelecao;
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
            Cliente cliente = new Cliente();


            cliente.ClienteNome = txtNomeCad.Text;
            cliente.ClienteEmail = txtEmailCad.Text;
            cliente.ClienteTel = txtTelCad.Text;
            cliente.ClienteEndereco = txtEnderecoCad.Text;
            cliente.ClienteCPF = txtCPFCad.Text;
            cliente.ClienteDatNasc = datetimepickerDatNasc.Value;

            ClienteController clienteController = new ClienteController();
            int IdCliente = 0;

            IdCliente = clienteController.InserirCliente(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso");
            this.Close();
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

            clienteController.AlterarCliente(cliente);

            MessageBox.Show("Cliente alterado com sucesso");
            this.Close();
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

            Cadastrar();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
