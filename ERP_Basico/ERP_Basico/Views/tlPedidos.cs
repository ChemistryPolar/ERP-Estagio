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
    public partial class tlPedidos : Form
    {
        public tlPedidos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
