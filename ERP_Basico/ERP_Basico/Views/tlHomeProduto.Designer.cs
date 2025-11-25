namespace ERP_Basico.Views
{
    partial class tlHomeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlHomeProduto));
            button1 = new Button();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            toolClientes = new ToolStripMenuItem();
            pedidosToolStripMenuItem1 = new ToolStripMenuItem();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            btnExcluir = new Button();
            timerHora = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            funcionarioCollectionBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            btnExport = new Button();
            toolFuncionarios = new ToolStripMenuItem();
            dgvRegistros = new DataGridView();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteNomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteTelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteCPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteEnderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDatNascDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteCollectionBindingSource = new BindingSource(components);
            btnVisualizar = new Button();
            btnEditar = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            logoofToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoPedidoToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)funcionarioCollectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteCollectionBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // pedidosToolStripMenuItem1
            // 
            pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            pedidosToolStripMenuItem1.Size = new Size(145, 22);
            pedidosToolStripMenuItem1.Text = "Pedidos";
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
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
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
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Produtos";
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
            // toolFuncionarios
            // 
            toolFuncionarios.Name = "toolFuncionarios";
            toolFuncionarios.Size = new Size(145, 22);
            toolFuncionarios.Text = "Funcionários";
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
            logoofToolStripMenuItem.Size = new Size(180, 22);
            logoofToolStripMenuItem.Text = "Logoff";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Fechar";
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
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolFuncionarios, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, toolClientes, pedidosToolStripMenuItem1 });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 18);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // tlHomeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 513);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(lblHora);
            Controls.Add(pictureBox1);
            Controls.Add(btnExport);
            Controls.Add(dgvRegistros);
            Controls.Add(btnVisualizar);
            Controls.Add(btnEditar);
            Controls.Add(menuStrip1);
            Name = "tlHomeProduto";
            Text = "ERP Básico";
            ((System.ComponentModel.ISupportInitialize)funcionarioCollectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteCollectionBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem toolClientes;
        private ToolStripMenuItem pedidosToolStripMenuItem1;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Button btnExcluir;
        private System.Windows.Forms.Timer timerHora;
        private Label lblHora;
        private BindingSource funcionarioCollectionBindingSource;
        private PictureBox pictureBox1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private Button btnExport;
        private ToolStripMenuItem toolFuncionarios;
        private DataGridView dgvRegistros;
        private BindingSource clienteCollectionBindingSource;
        private Button btnVisualizar;
        private Button btnEditar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem logoofToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoPedidoToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteTelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteCPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteEnderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDatNascDataGridViewTextBoxColumn;
    }
}