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

        public void TelaCadastro(string tipo)
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
                case ("visualizar"):
                    btnCadastrar.Visible = false;
                    break;

            }
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
