namespace toothsProjectFinal
{
    partial class frmEdicaoCadastro
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.groupBoxComplemento = new System.Windows.Forms.GroupBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.groupBoxAcesso = new System.Windows.Forms.GroupBox();
            this.radioButtonSecretaria = new System.Windows.Forms.RadioButton();
            this.radioButtonOdontologista = new System.Windows.Forms.RadioButton();
            this.radioButtonPaciente = new System.Windows.Forms.RadioButton();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxComplemento.SuspendLayout();
            this.groupBoxAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelMensagem);
            this.groupBoxInfo.Location = new System.Drawing.Point(22, 23);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(424, 56);
            this.groupBoxInfo.TabIndex = 7;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Mensagem Sistema";
            // 
            // labelMensagem
            // 
            this.labelMensagem.Location = new System.Drawing.Point(6, 22);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(412, 23);
            this.labelMensagem.TabIndex = 4;
            this.labelMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxComplemento
            // 
            this.groupBoxComplemento.Controls.Add(this.textBoxLogin);
            this.groupBoxComplemento.Controls.Add(this.labelLogin);
            this.groupBoxComplemento.Controls.Add(this.textBoxSenha);
            this.groupBoxComplemento.Controls.Add(this.buttonPesquisar);
            this.groupBoxComplemento.Controls.Add(this.labelSenha);
            this.groupBoxComplemento.Controls.Add(this.groupBoxAcesso);
            this.groupBoxComplemento.Controls.Add(this.textBoxCodigo);
            this.groupBoxComplemento.Controls.Add(this.labelCodigo);
            this.groupBoxComplemento.Controls.Add(this.dateTimePickerNascimento);
            this.groupBoxComplemento.Controls.Add(this.labelDataNascimento);
            this.groupBoxComplemento.Controls.Add(this.textBoxTelefone);
            this.groupBoxComplemento.Controls.Add(this.labelTelefone);
            this.groupBoxComplemento.Controls.Add(this.textBoxEndereco);
            this.groupBoxComplemento.Controls.Add(this.labelEndereco);
            this.groupBoxComplemento.Controls.Add(this.textBoxDocumento);
            this.groupBoxComplemento.Controls.Add(this.labelDocumento);
            this.groupBoxComplemento.Controls.Add(this.textBoxNome);
            this.groupBoxComplemento.Controls.Add(this.labelNome);
            this.groupBoxComplemento.Location = new System.Drawing.Point(22, 85);
            this.groupBoxComplemento.Name = "groupBoxComplemento";
            this.groupBoxComplemento.Size = new System.Drawing.Size(424, 321);
            this.groupBoxComplemento.TabIndex = 6;
            this.groupBoxComplemento.TabStop = false;
            this.groupBoxComplemento.Text = "Dados do Usuario";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(116, 57);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(11, 60);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(116, 87);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(114, 20);
            this.textBoxSenha.TabIndex = 3;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(265, 28);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(120, 23);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(11, 94);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // groupBoxAcesso
            // 
            this.groupBoxAcesso.Controls.Add(this.radioButtonSecretaria);
            this.groupBoxAcesso.Controls.Add(this.radioButtonOdontologista);
            this.groupBoxAcesso.Controls.Add(this.radioButtonPaciente);
            this.groupBoxAcesso.Location = new System.Drawing.Point(14, 263);
            this.groupBoxAcesso.Name = "groupBoxAcesso";
            this.groupBoxAcesso.Size = new System.Drawing.Size(389, 45);
            this.groupBoxAcesso.TabIndex = 5;
            this.groupBoxAcesso.TabStop = false;
            this.groupBoxAcesso.Text = "Acesso";
            // 
            // radioButtonSecretaria
            // 
            this.radioButtonSecretaria.AutoSize = true;
            this.radioButtonSecretaria.Location = new System.Drawing.Point(66, 19);
            this.radioButtonSecretaria.Name = "radioButtonSecretaria";
            this.radioButtonSecretaria.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSecretaria.TabIndex = 9;
            this.radioButtonSecretaria.TabStop = true;
            this.radioButtonSecretaria.Text = "Secretaria";
            this.radioButtonSecretaria.UseVisualStyleBackColor = true;
            // 
            // radioButtonOdontologista
            // 
            this.radioButtonOdontologista.AutoSize = true;
            this.radioButtonOdontologista.Location = new System.Drawing.Point(155, 19);
            this.radioButtonOdontologista.Name = "radioButtonOdontologista";
            this.radioButtonOdontologista.Size = new System.Drawing.Size(90, 17);
            this.radioButtonOdontologista.TabIndex = 10;
            this.radioButtonOdontologista.TabStop = true;
            this.radioButtonOdontologista.Text = "Odontologista";
            this.radioButtonOdontologista.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaciente
            // 
            this.radioButtonPaciente.AutoSize = true;
            this.radioButtonPaciente.Location = new System.Drawing.Point(263, 19);
            this.radioButtonPaciente.Name = "radioButtonPaciente";
            this.radioButtonPaciente.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPaciente.TabIndex = 11;
            this.radioButtonPaciente.TabStop = true;
            this.radioButtonPaciente.Text = "Paciente";
            this.radioButtonPaciente.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(116, 28);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(114, 20);
            this.textBoxCodigo.TabIndex = 19;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(11, 34);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 18;
            this.labelCodigo.Text = "Codigo";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(116, 228);
            this.dateTimePickerNascimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(90, 20);
            this.dateTimePickerNascimento.TabIndex = 17;
            this.dateTimePickerNascimento.TabStop = false;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(11, 231);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.labelDataNascimento.TabIndex = 16;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(116, 201);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(269, 20);
            this.textBoxTelefone.TabIndex = 15;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(11, 206);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 14;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(116, 174);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(269, 20);
            this.textBoxEndereco.TabIndex = 13;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(11, 179);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 12;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(116, 144);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(269, 20);
            this.textBoxDocumento.TabIndex = 7;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(11, 150);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(62, 13);
            this.labelDocumento.TabIndex = 6;
            this.labelDocumento.Text = "Documento";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(116, 115);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 122);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(102, 412);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(120, 23);
            this.buttonAtualizar.TabIndex = 9;
            this.buttonAtualizar.Text = "Atualizar Cadastro";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(246, 412);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 23);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // frmEdicaoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxComplemento);
            this.MaximizeBox = false;
            this.Name = "frmEdicaoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dentista App - Alteração e Consulta de Cadastro";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxComplemento.ResumeLayout(false);
            this.groupBoxComplemento.PerformLayout();
            this.groupBoxAcesso.ResumeLayout(false);
            this.groupBoxAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.GroupBox groupBoxComplemento;
        private System.Windows.Forms.GroupBox groupBoxAcesso;
        private System.Windows.Forms.RadioButton radioButtonSecretaria;
        private System.Windows.Forms.RadioButton radioButtonOdontologista;
        private System.Windows.Forms.RadioButton radioButtonPaciente;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}