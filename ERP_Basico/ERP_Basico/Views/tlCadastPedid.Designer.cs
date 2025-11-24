namespace ERP_Basico.Views
{
    partial class tlCadastPedid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbProd = new TextBox();
            label1 = new Label();
            tbCodProd = new TextBox();
            label2 = new Label();
            btProd = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            tbNomeClient = new TextBox();
            label4 = new Label();
            tbCodClient = new TextBox();
            btClient = new Button();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            tbProdQuant = new TextBox();
            btOk = new Button();
            btCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbProd
            // 
            tbProd.Location = new Point(71, 18);
            tbProd.Name = "tbProd";
            tbProd.Size = new Size(489, 23);
            tbProd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto:";
            // 
            // tbCodProd
            // 
            tbCodProd.Location = new Point(468, 47);
            tbCodProd.Name = "tbCodProd";
            tbCodProd.Size = new Size(92, 23);
            tbCodProd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 50);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 3;
            label2.Text = "Código do Produto:";
            // 
            // btProd
            // 
            btProd.Location = new Point(585, 18);
            btProd.Name = "btProd";
            btProd.Size = new Size(115, 52);
            btProd.TabIndex = 4;
            btProd.Text = "Pesquisar";
            btProd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 70);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Cliente:";
            // 
            // tbNomeClient
            // 
            tbNomeClient.Location = new Point(71, 102);
            tbNomeClient.Name = "tbNomeClient";
            tbNomeClient.Size = new Size(489, 23);
            tbNomeClient.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 134);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "Código do Cliente:";
            // 
            // tbCodClient
            // 
            tbCodClient.Location = new Point(468, 131);
            tbCodClient.Name = "tbCodClient";
            tbCodClient.Size = new Size(92, 23);
            tbCodClient.TabIndex = 9;
            // 
            // btClient
            // 
            btClient.Location = new Point(585, 105);
            btClient.Name = "btClient";
            btClient.Size = new Size(115, 52);
            btClient.TabIndex = 10;
            btClient.Text = "Pesquisar";
            btClient.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 294);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(715, 54);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 276);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 12;
            label5.Text = "Observações:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 50);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 13;
            label6.Text = "Quantidade:";
            // 
            // tbProdQuant
            // 
            tbProdQuant.Location = new Point(90, 47);
            tbProdQuant.Name = "tbProdQuant";
            tbProdQuant.Size = new Size(92, 23);
            tbProdQuant.TabIndex = 14;
            // 
            // btOk
            // 
            btOk.Location = new Point(633, 363);
            btOk.Name = "btOk";
            btOk.Size = new Size(96, 24);
            btOk.TabIndex = 15;
            btOk.Text = "Cadastrar";
            btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(531, 363);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(96, 24);
            btCancel.TabIndex = 16;
            btCancel.Text = "Cancelar";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // tlCadastPedid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 399);
            ControlBox = false;
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(tbProdQuant);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(btClient);
            Controls.Add(tbCodClient);
            Controls.Add(label4);
            Controls.Add(tbNomeClient);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btProd);
            Controls.Add(label2);
            Controls.Add(tbCodProd);
            Controls.Add(label1);
            Controls.Add(tbProd);
            Name = "tlCadastPedid";
            Text = "Novo Cadastro de Pedido";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProd;
        private Label label1;
        private TextBox tbCodProd;
        private Label label2;
        private Button btProd;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox tbNomeClient;
        private Label label4;
        private TextBox tbCodClient;
        private Button btClient;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label6;
        private TextBox tbProdQuant;
        private Button btOk;
        private Button btCancel;
    }
}