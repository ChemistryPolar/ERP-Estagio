namespace ERP_Basico.Views
{
    partial class tlHomePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlHomePedido));
            btnExport = new Button();
            pictureBox1 = new PictureBox();
            funcionarioCollectionBindingSource = new BindingSource(components);
            lblHora = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            btnExcluir = new Button();
            pedidosToolStripMenuItem1 = new ToolStripMenuItem();
            toolClientes = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            toolFuncionarios = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            novoPedidoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            logoofToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            btnVisualizar = new Button();
            btnEditar = new Button();
            menuStrip1 = new MenuStrip();
            clienteCollectionBindingSource = new BindingSource(components);
            clienteDatNascDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteEnderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteCPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteTelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteNomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            dgvRegistros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioCollectionBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteCollectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(334, 475);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(96, 24);
            btnExport.TabIndex = 21;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // funcionarioCollectionBindingSource
            // 
            funcionarioCollectionBindingSource.DataSource = typeof(Models.FuncionarioCollection);
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(110, 475);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(117, 29);
            lblHora.TabIndex = 18;
            lblHora.Text = "Carregando...";
            lblHora.UseCompatibleTextRendering = true;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(818, 1);
            btnPesquisar.Margin = new Padding(2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(96, 24);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
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
            txtPesquisar.TabIndex = 16;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(10, 476);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 24);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // pedidosToolStripMenuItem1
            // 
            pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            pedidosToolStripMenuItem1.Size = new Size(145, 22);
            pedidosToolStripMenuItem1.Text = "Pedidos";
            // 
            // toolClientes
            // 
            toolClientes.Name = "toolClientes";
            toolClientes.Size = new Size(145, 22);
            toolClientes.Text = "Clientes";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // toolFuncionarios
            // 
            toolFuncionarios.Name = "toolFuncionarios";
            toolFuncionarios.Size = new Size(145, 22);
            toolFuncionarios.Text = "Funcionários";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolFuncionarios, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, toolClientes, pedidosToolStripMenuItem1 });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 18);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // novoPedidoToolStripMenuItem
            // 
            novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            novoPedidoToolStripMenuItem.Size = new Size(143, 22);
            novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoPedidoToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 18);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(109, 22);
            sairToolStripMenuItem.Text = "Fechar";
            // 
            // logoofToolStripMenuItem
            // 
            logoofToolStripMenuItem.Name = "logoofToolStripMenuItem";
            logoofToolStripMenuItem.Size = new Size(109, 22);
            logoofToolStripMenuItem.Text = "Logoff";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoofToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 18);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVisualizar.Location = new Point(708, 476);
            btnVisualizar.Margin = new Padding(2);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(96, 24);
            btnVisualizar.TabIndex = 13;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(809, 476);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 24);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, pedidosToolStripMenuItem, listarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MaximumSize = new Size(500, 50);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(500, 22);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteCollectionBindingSource
            // 
            clienteCollectionBindingSource.DataSource = typeof(Models.ClienteCollection);
            // 
            // clienteDatNascDataGridViewTextBoxColumn
            // 
            clienteDatNascDataGridViewTextBoxColumn.DataPropertyName = "ClienteDatNasc";
            clienteDatNascDataGridViewTextBoxColumn.HeaderText = "ClienteDatNasc";
            clienteDatNascDataGridViewTextBoxColumn.Name = "clienteDatNascDataGridViewTextBoxColumn";
            clienteDatNascDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteEnderecoDataGridViewTextBoxColumn
            // 
            clienteEnderecoDataGridViewTextBoxColumn.DataPropertyName = "ClienteEndereco";
            clienteEnderecoDataGridViewTextBoxColumn.HeaderText = "ClienteEndereco";
            clienteEnderecoDataGridViewTextBoxColumn.Name = "clienteEnderecoDataGridViewTextBoxColumn";
            clienteEnderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteCPFDataGridViewTextBoxColumn
            // 
            clienteCPFDataGridViewTextBoxColumn.DataPropertyName = "ClienteCPF";
            clienteCPFDataGridViewTextBoxColumn.HeaderText = "ClienteCPF";
            clienteCPFDataGridViewTextBoxColumn.Name = "clienteCPFDataGridViewTextBoxColumn";
            clienteCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteTelDataGridViewTextBoxColumn
            // 
            clienteTelDataGridViewTextBoxColumn.DataPropertyName = "ClienteTel";
            clienteTelDataGridViewTextBoxColumn.HeaderText = "ClienteTel";
            clienteTelDataGridViewTextBoxColumn.Name = "clienteTelDataGridViewTextBoxColumn";
            clienteTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteEmailDataGridViewTextBoxColumn
            // 
            clienteEmailDataGridViewTextBoxColumn.DataPropertyName = "ClienteEmail";
            clienteEmailDataGridViewTextBoxColumn.HeaderText = "ClienteEmail";
            clienteEmailDataGridViewTextBoxColumn.Name = "clienteEmailDataGridViewTextBoxColumn";
            clienteEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteNomeDataGridViewTextBoxColumn
            // 
            clienteNomeDataGridViewTextBoxColumn.DataPropertyName = "ClienteNome";
            clienteNomeDataGridViewTextBoxColumn.HeaderText = "ClienteNome";
            clienteNomeDataGridViewTextBoxColumn.Name = "clienteNomeDataGridViewTextBoxColumn";
            clienteNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(608, 476);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(96, 24);
            button1.TabIndex = 20;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
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
            dgvRegistros.TabIndex = 11;
            dgvRegistros.VirtualMode = true;
            // 
            // tlHomePedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 513);
            ControlBox = false;
            Controls.Add(btnExport);
            Controls.Add(pictureBox1);
            Controls.Add(lblHora);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnEditar);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(dgvRegistros);
            Name = "tlHomePedido";
            Text = "ERP Básico";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioCollectionBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteCollectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExport;
        private PictureBox pictureBox1;
        private BindingSource funcionarioCollectionBindingSource;
        private Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Button btnExcluir;
        private ToolStripMenuItem pedidosToolStripMenuItem1;
        private ToolStripMenuItem toolClientes;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem toolFuncionarios;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem novoPedidoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem logoofToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Button btnVisualizar;
        private Button btnEditar;
        private MenuStrip menuStrip1;
        private BindingSource clienteCollectionBindingSource;
        private DataGridViewTextBoxColumn clienteDatNascDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteEnderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteCPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteTelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private Button button1;
        private DataGridView dgvRegistros;
    }
}