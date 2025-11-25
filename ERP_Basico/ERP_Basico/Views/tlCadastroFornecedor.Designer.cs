namespace ERP_Basico.Views
{
    partial class tlCadastroFornecedor
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
            labelId = new Label();
            btnAlterar = new Button();
            radioFun = new RadioButton();
            radioAdm = new RadioButton();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            label9 = new Label();
            button2 = new Button();
            btnCadastrar = new Button();
            labelEmail = new Label();
            txtEmailCad = new TextBox();
            datetimepickerDatNasc = new DateTimePicker();
            label7 = new Label();
            labelCNPJ = new Label();
            txtCNPJCad = new TextBox();
            label5 = new Label();
            labelCPF = new Label();
            txtEnderecoCad = new TextBox();
            txtCPFCad = new TextBox();
            label3 = new Label();
            txtTelCad = new TextBox();
            labelSetor = new Label();
            txtSetorCad = new TextBox();
            label1 = new Label();
            txtNomeCad = new TextBox();
            menuStrip1 = new MenuStrip();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(293, 32);
            labelId.Name = "labelId";
            labelId.Size = new Size(43, 15);
            labelId.TabIndex = 55;
            labelId.Text = "Nome:";
            labelId.Visible = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(424, 395);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 22);
            btnAlterar.TabIndex = 54;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // radioFun
            // 
            radioFun.AutoSize = true;
            radioFun.Location = new Point(531, 270);
            radioFun.Name = "radioFun";
            radioFun.Size = new Size(88, 19);
            radioFun.TabIndex = 53;
            radioFun.TabStop = true;
            radioFun.Text = "Funcionário";
            radioFun.UseVisualStyleBackColor = true;
            // 
            // radioAdm
            // 
            radioAdm.AutoSize = true;
            radioAdm.Location = new Point(352, 270);
            radioAdm.Name = "radioAdm";
            radioAdm.Size = new Size(124, 19);
            radioAdm.TabIndex = 52;
            radioAdm.TabStop = true;
            radioAdm.Text = "Prv. Administrador";
            radioAdm.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(352, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 23);
            txtPassword.TabIndex = 51;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(352, 181);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(267, 23);
            txtUser.TabIndex = 50;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(286, 231);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(42, 15);
            labelPassword.TabIndex = 49;
            labelPassword.Text = "Senha:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(286, 184);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(50, 15);
            labelUser.TabIndex = 48;
            labelUser.Text = "Usuário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 32);
            label9.Name = "label9";
            label9.Size = new Size(16, 15);
            label9.TabIndex = 47;
            label9.Text = "...";
            // 
            // button2
            // 
            button2.Location = new Point(512, 395);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 46;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(608, 395);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 22);
            btnCadastrar.TabIndex = 45;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(13, 98);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 43;
            labelEmail.Text = "Email:";
            // 
            // txtEmailCad
            // 
            txtEmailCad.Location = new Point(108, 96);
            txtEmailCad.Margin = new Padding(3, 2, 3, 2);
            txtEmailCad.Name = "txtEmailCad";
            txtEmailCad.PlaceholderText = "Insira um Email";
            txtEmailCad.Size = new Size(574, 23);
            txtEmailCad.TabIndex = 42;
            // 
            // datetimepickerDatNasc
            // 
            datetimepickerDatNasc.Format = DateTimePickerFormat.Short;
            datetimepickerDatNasc.Location = new Point(166, 380);
            datetimepickerDatNasc.Margin = new Padding(3, 2, 3, 2);
            datetimepickerDatNasc.MaxDate = new DateTime(2500, 12, 31, 0, 0, 0, 0);
            datetimepickerDatNasc.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            datetimepickerDatNasc.Name = "datetimepickerDatNasc";
            datetimepickerDatNasc.Size = new Size(111, 23);
            datetimepickerDatNasc.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 383);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 40;
            label7.Text = "Data de Nascimento:";
            // 
            // labelCNPJ
            // 
            labelCNPJ.AutoSize = true;
            labelCNPJ.Location = new Point(13, 282);
            labelCNPJ.Name = "labelCNPJ";
            labelCNPJ.Size = new Size(37, 15);
            labelCNPJ.TabIndex = 39;
            labelCNPJ.Text = "CNPJ:";
            // 
            // txtCNPJCad
            // 
            txtCNPJCad.Location = new Point(108, 280);
            txtCNPJCad.Margin = new Padding(3, 2, 3, 2);
            txtCNPJCad.Name = "txtCNPJCad";
            txtCNPJCad.PlaceholderText = "__.___.___/____-__";
            txtCNPJCad.Size = new Size(119, 23);
            txtCNPJCad.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 332);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 37;
            label5.Text = "Endereço:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(13, 234);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 15);
            labelCPF.TabIndex = 36;
            labelCPF.Text = "CPF:";
            // 
            // txtEnderecoCad
            // 
            txtEnderecoCad.Location = new Point(108, 330);
            txtEnderecoCad.Margin = new Padding(3, 2, 3, 2);
            txtEnderecoCad.Name = "txtEnderecoCad";
            txtEnderecoCad.PlaceholderText = "Insira um Endereço";
            txtEnderecoCad.Size = new Size(574, 23);
            txtEnderecoCad.TabIndex = 35;
            // 
            // txtCPFCad
            // 
            txtCPFCad.Location = new Point(108, 231);
            txtCPFCad.Margin = new Padding(3, 2, 3, 2);
            txtCPFCad.Name = "txtCPFCad";
            txtCPFCad.PlaceholderText = "___.___.___-__";
            txtCPFCad.Size = new Size(107, 23);
            txtCPFCad.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 186);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 33;
            label3.Text = "Telefone:";
            // 
            // txtTelCad
            // 
            txtTelCad.Location = new Point(108, 184);
            txtTelCad.Margin = new Padding(3, 2, 3, 2);
            txtTelCad.Name = "txtTelCad";
            txtTelCad.PlaceholderText = "(__) _____-____";
            txtTelCad.Size = new Size(107, 23);
            txtTelCad.TabIndex = 32;
            // 
            // labelSetor
            // 
            labelSetor.AutoSize = true;
            labelSetor.Location = new Point(13, 140);
            labelSetor.Name = "labelSetor";
            labelSetor.Size = new Size(37, 15);
            labelSetor.TabIndex = 31;
            labelSetor.Text = "Setor:";
            // 
            // txtSetorCad
            // 
            txtSetorCad.Location = new Point(108, 137);
            txtSetorCad.Margin = new Padding(3, 2, 3, 2);
            txtSetorCad.Name = "txtSetorCad";
            txtSetorCad.PlaceholderText = "Insira um Setor";
            txtSetorCad.Size = new Size(574, 23);
            txtSetorCad.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 29;
            label1.Text = "Nome:";
            // 
            // txtNomeCad
            // 
            txtNomeCad.Location = new Point(108, 57);
            txtNomeCad.Margin = new Padding(3, 2, 3, 2);
            txtNomeCad.Name = "txtNomeCad";
            txtNomeCad.PlaceholderText = "Insira um Nome";
            txtNomeCad.Size = new Size(574, 23);
            txtNomeCad.TabIndex = 28;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(711, 24);
            menuStrip1.TabIndex = 44;
            menuStrip1.Text = "menuStrip1";
            // 
            // tlCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 440);
            ControlBox = false;
            Controls.Add(labelId);
            Controls.Add(btnAlterar);
            Controls.Add(radioFun);
            Controls.Add(radioAdm);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(btnCadastrar);
            Controls.Add(labelEmail);
            Controls.Add(txtEmailCad);
            Controls.Add(datetimepickerDatNasc);
            Controls.Add(label7);
            Controls.Add(labelCNPJ);
            Controls.Add(txtCNPJCad);
            Controls.Add(label5);
            Controls.Add(labelCPF);
            Controls.Add(txtEnderecoCad);
            Controls.Add(txtCPFCad);
            Controls.Add(label3);
            Controls.Add(txtTelCad);
            Controls.Add(labelSetor);
            Controls.Add(txtSetorCad);
            Controls.Add(label1);
            Controls.Add(txtNomeCad);
            Controls.Add(menuStrip1);
            Name = "tlCadastroFornecedor";
            Text = "Novo Cadastro de Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Button btnAlterar;
        private RadioButton radioFun;
        private RadioButton radioAdm;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label labelPassword;
        private Label labelUser;
        public Label label9;
        private Button button2;
        private Button btnCadastrar;
        private Label labelEmail;
        private TextBox txtEmailCad;
        private DateTimePicker datetimepickerDatNasc;
        private Label label7;
        private Label labelCNPJ;
        private TextBox txtCNPJCad;
        private Label label5;
        private Label labelCPF;
        private TextBox txtEnderecoCad;
        private TextBox txtCPFCad;
        private Label label3;
        private TextBox txtTelCad;
        private Label labelSetor;
        private TextBox txtSetorCad;
        private Label label1;
        private TextBox txtNomeCad;
        private MenuStrip menuStrip1;
    }
}