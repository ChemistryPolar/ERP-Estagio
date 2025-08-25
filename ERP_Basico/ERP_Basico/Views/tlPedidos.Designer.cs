namespace ERP_Basico
{
    partial class tlPedidos
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
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            textBox7 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            alterarTipoDeCadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 29);
            label9.Name = "label9";
            label9.Size = new Size(133, 15);
            label9.TabIndex = 39;
            label9.Text = "Cadastrar Novo Pedido";
            // 
            // button2
            // 
            button2.Location = new Point(526, 237);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 38;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(621, 237);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 37;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 99);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 35;
            label8.Text = "Produto:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(108, 97);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(509, 23);
            textBox7.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(593, 193);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(2500, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 196);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 32;
            label7.Text = "Data Estimada de Entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 148);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 29;
            label5.Text = "Endereço Entrega:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 146);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(486, 23);
            textBox5.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 21;
            label1.Text = "Nome Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 58);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(509, 23);
            textBox1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alterarTipoDeCadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(714, 24);
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStrip1";
            // 
            // alterarTipoDeCadastroToolStripMenuItem
            // 
            alterarTipoDeCadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, fornecedorToolStripMenuItem, funcionárioToolStripMenuItem, produtoToolStripMenuItem });
            alterarTipoDeCadastroToolStripMenuItem.Name = "alterarTipoDeCadastroToolStripMenuItem";
            alterarTipoDeCadastroToolStripMenuItem.Size = new Size(147, 20);
            alterarTipoDeCadastroToolStripMenuItem.Text = "Alterar Tipo de Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(137, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(137, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(137, 22);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(621, 57);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 40;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(621, 97);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 41;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 42;
            label2.Text = "Valor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 190);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 43;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Location = new Point(621, 146);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 44;
            button5.Text = "Alterar";
            button5.UseVisualStyleBackColor = true;
            // 
            // tlPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 266);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tlPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Pedido";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Button button2;
        private Button button1;
        private Label label8;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label5;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alterarTipoDeCadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private Button button5;
    }
}