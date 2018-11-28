namespace toothsProjectFinal
{
    partial class frmCadastro
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxComplemento = new System.Windows.Forms.GroupBox();
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonCadastrarAtualizar = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxComplemento.SuspendLayout();
            this.groupBoxAcesso.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxLogin.Controls.Add(this.textBoxLogin);
            this.groupBoxLogin.Controls.Add(this.labelSenha);
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Location = new System.Drawing.Point(22, 23);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(241, 100);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Dados Login";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(116, 60);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(114, 20);
            this.textBoxSenha.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(116, 23);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(11, 67);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(11, 26);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // groupBoxComplemento
            // 
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
            this.groupBoxComplemento.Location = new System.Drawing.Point(22, 142);
            this.groupBoxComplemento.Name = "groupBoxComplemento";
            this.groupBoxComplemento.Size = new System.Drawing.Size(424, 264);
            this.groupBoxComplemento.TabIndex = 1;
            this.groupBoxComplemento.TabStop = false;
            this.groupBoxComplemento.Text = "Dados Complementares";
            // 
            // groupBoxAcesso
            // 
            this.groupBoxAcesso.Controls.Add(this.radioButtonSecretaria);
            this.groupBoxAcesso.Controls.Add(this.radioButtonOdontologista);
            this.groupBoxAcesso.Controls.Add(this.radioButtonPaciente);
            this.groupBoxAcesso.Location = new System.Drawing.Point(14, 193);
            this.groupBoxAcesso.Name = "groupBoxAcesso";
            this.groupBoxAcesso.Size = new System.Drawing.Size(283, 45);
            this.groupBoxAcesso.TabIndex = 5;
            this.groupBoxAcesso.TabStop = false;
            this.groupBoxAcesso.Text = "Acesso";
            // 
            // radioButtonSecretaria
            // 
            this.radioButtonSecretaria.AutoSize = true;
            this.radioButtonSecretaria.Location = new System.Drawing.Point(13, 19);
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
            this.radioButtonOdontologista.Location = new System.Drawing.Point(102, 19);
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
            this.radioButtonPaciente.Location = new System.Drawing.Point(210, 19);
            this.radioButtonPaciente.Name = "radioButtonPaciente";
            this.radioButtonPaciente.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPaciente.TabIndex = 11;
            this.radioButtonPaciente.TabStop = true;
            this.radioButtonPaciente.Text = "Paciente";
            this.radioButtonPaciente.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(116, 19);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(114, 20);
            this.textBoxCodigo.TabIndex = 19;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(11, 25);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 18;
            this.labelCodigo.Text = "Codigo";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(116, 158);
            this.dateTimePickerNascimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerNascimento.TabIndex = 17;
            this.dateTimePickerNascimento.TabStop = false;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(11, 161);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.labelDataNascimento.TabIndex = 16;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(116, 131);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(269, 20);
            this.textBoxTelefone.TabIndex = 15;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(11, 136);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 14;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(116, 104);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(269, 20);
            this.textBoxEndereco.TabIndex = 13;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(11, 109);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 12;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(116, 74);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(269, 20);
            this.textBoxDocumento.TabIndex = 7;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(11, 80);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(62, 13);
            this.labelDocumento.TabIndex = 6;
            this.labelDocumento.Text = "Documento";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(116, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 52);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(232, 418);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 23);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonCadastrarAtualizar
            // 
            this.buttonCadastrarAtualizar.Location = new System.Drawing.Point(88, 418);
            this.buttonCadastrarAtualizar.Name = "buttonCadastrarAtualizar";
            this.buttonCadastrarAtualizar.Size = new System.Drawing.Size(120, 23);
            this.buttonCadastrarAtualizar.TabIndex = 3;
            this.buttonCadastrarAtualizar.Text = "Cadastrar";
            this.buttonCadastrarAtualizar.UseVisualStyleBackColor = true;
            this.buttonCadastrarAtualizar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.Location = new System.Drawing.Point(6, 46);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(165, 13);
            this.labelMensagem.TabIndex = 4;
            this.labelMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelMensagem);
            this.groupBoxInfo.Location = new System.Drawing.Point(269, 23);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(177, 100);
            this.groupBoxInfo.TabIndex = 4;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Mensagem Sistema";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 452);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonCadastrarAtualizar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBoxComplemento);
            this.Controls.Add(this.groupBoxLogin);
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.Text = "Dentista App - Cadastro Paciente";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxComplemento.ResumeLayout(false);
            this.groupBoxComplemento.PerformLayout();
            this.groupBoxAcesso.ResumeLayout(false);
            this.groupBoxAcesso.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox groupBoxComplemento;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.RadioButton radioButtonPaciente;
        private System.Windows.Forms.RadioButton radioButtonOdontologista;
        private System.Windows.Forms.RadioButton radioButtonSecretaria;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonCadastrarAtualizar;
        private System.Windows.Forms.GroupBox groupBoxAcesso;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.GroupBox groupBoxInfo;
    }
}