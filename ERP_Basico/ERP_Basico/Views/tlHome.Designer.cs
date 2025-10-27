namespace ERP_Basico
{
    partial class tlHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlHome));
            dgvRegistros = new DataGridView();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteNomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteTelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteCPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteEnderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDatNascDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteCollectionBindingSource = new BindingSource(components);
            btnEditar = new Button();
            btnVisualizar = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            logoofToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoPedidoToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            toolFuncionarios = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            toolClientes = new ToolStripMenuItem();
            pedidosToolStripMenuItem1 = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            btnExcluir = new Button();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            timerHora = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            funcionarioCollectionBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteCollectionBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)funcionarioCollectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AllowUserToOrderColumns = true;
            dgvRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistros.AutoGenerateColumns = false;
            dgvRegistros.BackgroundColor = SystemColors.ButtonFace;
            dgvRegistros.BorderStyle = BorderStyle.Fixed3D;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { idClienteDataGridViewTextBoxColumn, clienteNomeDataGridViewTextBoxColumn, clienteEmailDataGridViewTextBoxColumn, clienteTelDataGridViewTextBoxColumn, clienteCPFDataGridViewTextBoxColumn, clienteEnderecoDataGridViewTextBoxColumn, clienteDatNascDataGridViewTextBoxColumn });
            dgvRegistros.DataSource = clienteCollectionBindingSource;
            dgvRegistros.Location = new Point(10, 29);
            dgvRegistros.Margin = new Padding(2);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(895, 428);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.VirtualMode = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteNomeDataGridViewTextBoxColumn
            // 
            clienteNomeDataGridViewTextBoxColumn.DataPropertyName = "ClienteNome";
            clienteNomeDataGridViewTextBoxColumn.HeaderText = "ClienteNome";
            clienteNomeDataGridViewTextBoxColumn.Name = "clienteNomeDataGridViewTextBoxColumn";
            clienteNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteEmailDataGridViewTextBoxColumn
            // 
            clienteEmailDataGridViewTextBoxColumn.DataPropertyName = "ClienteEmail";
            clienteEmailDataGridViewTextBoxColumn.HeaderText = "ClienteEmail";
            clienteEmailDataGridViewTextBoxColumn.Name = "clienteEmailDataGridViewTextBoxColumn";
            clienteEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteTelDataGridViewTextBoxColumn
            // 
            clienteTelDataGridViewTextBoxColumn.DataPropertyName = "ClienteTel";
            clienteTelDataGridViewTextBoxColumn.HeaderText = "ClienteTel";
            clienteTelDataGridViewTextBoxColumn.Name = "clienteTelDataGridViewTextBoxColumn";
            clienteTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteCPFDataGridViewTextBoxColumn
            // 
            clienteCPFDataGridViewTextBoxColumn.DataPropertyName = "ClienteCPF";
            clienteCPFDataGridViewTextBoxColumn.HeaderText = "ClienteCPF";
            clienteCPFDataGridViewTextBoxColumn.Name = "clienteCPFDataGridViewTextBoxColumn";
            clienteCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteEnderecoDataGridViewTextBoxColumn
            // 
            clienteEnderecoDataGridViewTextBoxColumn.DataPropertyName = "ClienteEndereco";
            clienteEnderecoDataGridViewTextBoxColumn.HeaderText = "ClienteEndereco";
            clienteEnderecoDataGridViewTextBoxColumn.Name = "clienteEnderecoDataGridViewTextBoxColumn";
            clienteEnderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDatNascDataGridViewTextBoxColumn
            // 
            clienteDatNascDataGridViewTextBoxColumn.DataPropertyName = "ClienteDatNasc";
            clienteDatNascDataGridViewTextBoxColumn.HeaderText = "ClienteDatNasc";
            clienteDatNascDataGridViewTextBoxColumn.Name = "clienteDatNascDataGridViewTextBoxColumn";
            clienteDatNascDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteCollectionBindingSource
            // 
            clienteCollectionBindingSource.DataSource = typeof(Models.ClienteCollection);
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(809, 476);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 24);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVisualizar.Location = new Point(708, 476);
            btnVisualizar.Margin = new Padding(2);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(96, 24);
            btnVisualizar.TabIndex = 2;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, pedidosToolStripMenuItem, listarToolStripMenuItem, adicionarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MaximumSize = new Size(500, 50);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(500, 22);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoofToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 18);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // logoofToolStripMenuItem
            // 
            logoofToolStripMenuItem.Name = "logoofToolStripMenuItem";
            logoofToolStripMenuItem.Size = new Size(109, 22);
            logoofToolStripMenuItem.Text = "Logoff";
            logoofToolStripMenuItem.Click += logoofToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(109, 22);
            sairToolStripMenuItem.Text = "Fechar";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoPedidoToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 18);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // novoPedidoToolStripMenuItem
            // 
            novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            novoPedidoToolStripMenuItem.Size = new Size(143, 22);
            novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            novoPedidoToolStripMenuItem.Click += novoPedidoToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolFuncionarios, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, toolClientes, pedidosToolStripMenuItem1 });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 18);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // toolFuncionarios
            // 
            toolFuncionarios.Name = "toolFuncionarios";
            toolFuncionarios.Size = new Size(145, 22);
            toolFuncionarios.Text = "Funcionários";
            toolFuncionarios.Click += toolFuncionarios_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // toolClientes
            // 
            toolClientes.Name = "toolClientes";
            toolClientes.Size = new Size(145, 22);
            toolClientes.Text = "Clientes";
            toolClientes.Click += toolClientes_Click;
            // 
            // pedidosToolStripMenuItem1
            // 
            pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            pedidosToolStripMenuItem1.Size = new Size(145, 22);
            pedidosToolStripMenuItem1.Text = "Pedidos";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, fornecedorToolStripMenuItem, funcionárioToolStripMenuItem, produtosToolStripMenuItem1 });
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(70, 18);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(137, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            fornecedorToolStripMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(137, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(137, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            produtosToolStripMenuItem1.Click += produtosToolStripMenuItem1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(10, 476);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 24);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPesquisar.BorderStyle = BorderStyle.None;
            txtPesquisar.Location = new Point(582, 5);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar...";
            txtPesquisar.Size = new Size(232, 16);
            txtPesquisar.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(818, 1);
            btnPesquisar.Margin = new Padding(2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(96, 24);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(184, 476);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(117, 29);
            lblHora.TabIndex = 7;
            lblHora.Text = "Carregando...";
            lblHora.UseCompatibleTextRendering = true;
            // 
            // funcionarioCollectionBindingSource
            // 
            funcionarioCollectionBindingSource.DataSource = typeof(Models.FuncionarioCollection);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // tlHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(914, 513);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(lblHora);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnEditar);
            Controls.Add(dgvRegistros);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "tlHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERP Básico";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteCollectionBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)funcionarioCollectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistros;
        private Button btnEditar;
        private Button btnVisualizar;
        private MenuStrip menuStrip1;
        private Button btnExcluir;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoPedidoToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem logoofToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem toolFuncionarios;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem toolClientes;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.Timer timerHora;
        private Label lblHora;
        private BindingSource clienteCollectionBindingSource;
        private BindingSource funcionarioCollectionBindingSource;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteTelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteCPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteEnderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDatNascDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
    }
}