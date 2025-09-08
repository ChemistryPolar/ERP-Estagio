using ERP_Basico.Services;
using ERP_Basico.Models;
using ERP_Basico.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Basico
{
    public partial class Form1 : Form
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text;
            string Password = txtSenha.Text;
            dataBase.ValidarUser(User, Password);
        }
        private void btnSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
