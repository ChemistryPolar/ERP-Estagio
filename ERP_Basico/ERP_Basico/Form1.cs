namespace ERP_Basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tlHome home = new tlHome();
            home.Show();
            this.Hide();
        }

        private void btnSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
