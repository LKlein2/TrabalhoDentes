namespace toothsProjectFinal
{
    partial class AgendaView
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
            this.groupDentista = new System.Windows.Forms.GroupBox();
            this.buttonBuscarDentista = new System.Windows.Forms.Button();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtIdDentista = new System.Windows.Forms.TextBox();
            this.groupPaciente = new System.Windows.Forms.GroupBox();
            this.buttonBuscarPaciente = new System.Windows.Forms.Button();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.buttonCarregarAgenda = new System.Windows.Forms.Button();
            this.listViewAgenda = new System.Windows.Forms.ListView();
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDentista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnObs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupData = new System.Windows.Forms.GroupBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBoxLancarConsulta = new System.Windows.Forms.GroupBox();
            this.comboHoraFim = new System.Windows.Forms.ComboBox();
            this.comboHoraInicio = new System.Windows.Forms.ComboBox();
            this.buttonLancarConsulta = new System.Windows.Forms.Button();
            this.textBoxObservacao1 = new System.Windows.Forms.TextBox();
            this.labelObservacao_1 = new System.Windows.Forms.Label();
            this.labelFim = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.dateConsulta = new System.Windows.Forms.DateTimePicker();
            this.checkBranco = new System.Windows.Forms.CheckBox();
            this.groupDentista.SuspendLayout();
            this.groupPaciente.SuspendLayout();
            this.groupData.SuspendLayout();
            this.groupBoxLancarConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDentista
            // 
            this.groupDentista.Controls.Add(this.buttonBuscarDentista);
            this.groupDentista.Controls.Add(this.txtNomeDentista);
            this.groupDentista.Controls.Add(this.txtIdDentista);
            this.groupDentista.Location = new System.Drawing.Point(15, 18);
            this.groupDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupDentista.Name = "groupDentista";
            this.groupDentista.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupDentista.Size = new System.Drawing.Size(488, 58);
            this.groupDentista.TabIndex = 1;
            this.groupDentista.TabStop = false;
            this.groupDentista.Text = "Dentista";
            // 
            // buttonBuscarDentista
            // 
            this.buttonBuscarDentista.Location = new System.Drawing.Point(411, 22);
            this.buttonBuscarDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarDentista.Name = "buttonBuscarDentista";
            this.buttonBuscarDentista.Size = new System.Drawing.Size(69, 23);
            this.buttonBuscarDentista.TabIndex = 2;
            this.buttonBuscarDentista.Text = "Buscar";
            this.buttonBuscarDentista.UseVisualStyleBackColor = true;
            this.buttonBuscarDentista.Click += new System.EventHandler(this.buttonBuscarDentista_Click);
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(125, 21);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(279, 22);
            this.txtNomeDentista.TabIndex = 1;
            // 
            // txtIdDentista
            // 
            this.txtIdDentista.Location = new System.Drawing.Point(19, 21);
            this.txtIdDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDentista.Name = "txtIdDentista";
            this.txtIdDentista.Size = new System.Drawing.Size(100, 22);
            this.txtIdDentista.TabIndex = 0;
            // 
            // groupPaciente
            // 
            this.groupPaciente.Controls.Add(this.buttonBuscarPaciente);
            this.groupPaciente.Controls.Add(this.txtNomePaciente);
            this.groupPaciente.Controls.Add(this.txtIdPaciente);
            this.groupPaciente.Location = new System.Drawing.Point(508, 18);
            this.groupPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPaciente.Name = "groupPaciente";
            this.groupPaciente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPaciente.Size = new System.Drawing.Size(488, 58);
            this.groupPaciente.TabIndex = 2;
            this.groupPaciente.TabStop = false;
            this.groupPaciente.Text = "Paciente";
            // 
            // buttonBuscarPaciente
            // 
            this.buttonBuscarPaciente.Location = new System.Drawing.Point(409, 21);
            this.buttonBuscarPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarPaciente.Name = "buttonBuscarPaciente";
            this.buttonBuscarPaciente.Size = new System.Drawing.Size(69, 23);
            this.buttonBuscarPaciente.TabIndex = 2;
            this.buttonBuscarPaciente.Text = "Buscar";
            this.buttonBuscarPaciente.UseVisualStyleBackColor = true;
            this.buttonBuscarPaciente.Click += new System.EventHandler(this.buttonBuscarPaciente_Click);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(125, 21);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(279, 22);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(19, 21);
            this.txtIdPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtIdPaciente.TabIndex = 0;
            // 
            // buttonCarregarAgenda
            // 
            this.buttonCarregarAgenda.Location = new System.Drawing.Point(821, 81);
            this.buttonCarregarAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCarregarAgenda.Name = "buttonCarregarAgenda";
            this.buttonCarregarAgenda.Size = new System.Drawing.Size(175, 58);
            this.buttonCarregarAgenda.TabIndex = 3;
            this.buttonCarregarAgenda.Text = "CARREGAR AGENDA";
            this.buttonCarregarAgenda.UseVisualStyleBackColor = true;
            this.buttonCarregarAgenda.Click += new System.EventHandler(this.buttonCarregarAgenda_Click);
            // 
            // listViewAgenda
            // 
            this.listViewAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnData,
            this.columnDentista,
            this.columnPaciente,
            this.columnInicio,
            this.columnFim,
            this.columnObs});
            this.listViewAgenda.Location = new System.Drawing.Point(15, 256);
            this.listViewAgenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewAgenda.Name = "listViewAgenda";
            this.listViewAgenda.Size = new System.Drawing.Size(980, 194);
            this.listViewAgenda.TabIndex = 4;
            this.listViewAgenda.UseCompatibleStateImageBehavior = false;
            this.listViewAgenda.View = System.Windows.Forms.View.Details;
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            this.columnData.Width = 86;
            // 
            // columnDentista
            // 
            this.columnDentista.Text = "Dentista";
            this.columnDentista.Width = 123;
            // 
            // columnPaciente
            // 
            this.columnPaciente.Text = "Paciente";
            this.columnPaciente.Width = 121;
            // 
            // columnInicio
            // 
            this.columnInicio.Text = "Inicio";
            // 
            // columnFim
            // 
            this.columnFim.Text = "Fim";
            // 
            // columnObs
            // 
            this.columnObs.Text = "Observações";
            this.columnObs.Width = 233;
            // 
            // groupData
            // 
            this.groupData.Controls.Add(this.lblFinal);
            this.groupData.Controls.Add(this.lblInicial);
            this.groupData.Controls.Add(this.dateFinal);
            this.groupData.Controls.Add(this.dateInicial);
            this.groupData.Location = new System.Drawing.Point(15, 81);
            this.groupData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupData.Name = "groupData";
            this.groupData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupData.Size = new System.Drawing.Size(385, 58);
            this.groupData.TabIndex = 5;
            this.groupData.TabStop = false;
            this.groupData.Text = "Intervalo de data";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(203, 30);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(46, 17);
            this.lblFinal.TabIndex = 8;
            this.lblFinal.Text = "Final: ";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(16, 30);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(51, 17);
            this.lblInicial.TabIndex = 7;
            this.lblInicial.Text = "Inicial: ";
            // 
            // dateFinal
            // 
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(255, 25);
            this.dateFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFinal.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(113, 22);
            this.dateFinal.TabIndex = 6;
            // 
            // dateInicial
            // 
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.Location = new System.Drawing.Point(73, 25);
            this.dateInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateInicial.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(113, 22);
            this.dateInicial.TabIndex = 0;
            // 
            // groupBoxLancarConsulta
            // 
            this.groupBoxLancarConsulta.Controls.Add(this.comboHoraFim);
            this.groupBoxLancarConsulta.Controls.Add(this.comboHoraInicio);
            this.groupBoxLancarConsulta.Controls.Add(this.buttonLancarConsulta);
            this.groupBoxLancarConsulta.Controls.Add(this.textBoxObservacao1);
            this.groupBoxLancarConsulta.Controls.Add(this.labelObservacao_1);
            this.groupBoxLancarConsulta.Controls.Add(this.labelFim);
            this.groupBoxLancarConsulta.Controls.Add(this.labelInicio);
            this.groupBoxLancarConsulta.Controls.Add(this.labelConsulta);
            this.groupBoxLancarConsulta.Controls.Add(this.dateConsulta);
            this.groupBoxLancarConsulta.Location = new System.Drawing.Point(15, 145);
            this.groupBoxLancarConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLancarConsulta.Name = "groupBoxLancarConsulta";
            this.groupBoxLancarConsulta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLancarConsulta.Size = new System.Drawing.Size(979, 96);
            this.groupBoxLancarConsulta.TabIndex = 12;
            this.groupBoxLancarConsulta.TabStop = false;
            this.groupBoxLancarConsulta.Text = "Lançamento de consulta";
            // 
            // comboHoraFim
            // 
            this.comboHoraFim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHoraFim.FormattingEnabled = true;
            this.comboHoraFim.Location = new System.Drawing.Point(464, 55);
            this.comboHoraFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboHoraFim.Name = "comboHoraFim";
            this.comboHoraFim.Size = new System.Drawing.Size(121, 24);
            this.comboHoraFim.TabIndex = 15;
            // 
            // comboHoraInicio
            // 
            this.comboHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHoraInicio.FormattingEnabled = true;
            this.comboHoraInicio.Location = new System.Drawing.Point(180, 55);
            this.comboHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboHoraInicio.Name = "comboHoraInicio";
            this.comboHoraInicio.Size = new System.Drawing.Size(121, 24);
            this.comboHoraInicio.TabIndex = 14;
            // 
            // buttonLancarConsulta
            // 
            this.buttonLancarConsulta.Location = new System.Drawing.Point(789, 58);
            this.buttonLancarConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLancarConsulta.Name = "buttonLancarConsulta";
            this.buttonLancarConsulta.Size = new System.Drawing.Size(175, 26);
            this.buttonLancarConsulta.TabIndex = 12;
            this.buttonLancarConsulta.Text = "Lançar consulta";
            this.buttonLancarConsulta.UseVisualStyleBackColor = true;
            this.buttonLancarConsulta.Click += new System.EventHandler(this.buttonLancar_Click);
            // 
            // textBoxObservacao1
            // 
            this.textBoxObservacao1.Location = new System.Drawing.Point(464, 22);
            this.textBoxObservacao1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxObservacao1.Name = "textBoxObservacao1";
            this.textBoxObservacao1.Size = new System.Drawing.Size(499, 22);
            this.textBoxObservacao1.TabIndex = 3;
            // 
            // labelObservacao_1
            // 
            this.labelObservacao_1.AutoSize = true;
            this.labelObservacao_1.Location = new System.Drawing.Point(347, 27);
            this.labelObservacao_1.Name = "labelObservacao_1";
            this.labelObservacao_1.Size = new System.Drawing.Size(89, 17);
            this.labelObservacao_1.TabIndex = 13;
            this.labelObservacao_1.Text = "Observacao:";
            // 
            // labelFim
            // 
            this.labelFim.AutoSize = true;
            this.labelFim.Location = new System.Drawing.Point(347, 58);
            this.labelFim.Name = "labelFim";
            this.labelFim.Size = new System.Drawing.Size(65, 17);
            this.labelFim.TabIndex = 12;
            this.labelFim.Text = "Hora fim:";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(13, 57);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(79, 17);
            this.labelInicio.TabIndex = 11;
            this.labelInicio.Text = "Hora inicio:";
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Location = new System.Drawing.Point(13, 27);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(99, 17);
            this.labelConsulta.TabIndex = 10;
            this.labelConsulta.Text = "Data consulta:";
            // 
            // dateConsulta
            // 
            this.dateConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateConsulta.Location = new System.Drawing.Point(180, 22);
            this.dateConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateConsulta.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateConsulta.Name = "dateConsulta";
            this.dateConsulta.Size = new System.Drawing.Size(121, 22);
            this.dateConsulta.TabIndex = 9;
            // 
            // checkBranco
            // 
            this.checkBranco.AutoSize = true;
            this.checkBranco.Location = new System.Drawing.Point(426, 107);
            this.checkBranco.Name = "checkBranco";
            this.checkBranco.Size = new System.Drawing.Size(208, 21);
            this.checkBranco.TabIndex = 13;
            this.checkBranco.Text = "Mostrar registros em branco";
            this.checkBranco.UseVisualStyleBackColor = true;
            // 
            // AgendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 466);
            this.Controls.Add(this.checkBranco);
            this.Controls.Add(this.groupBoxLancarConsulta);
            this.Controls.Add(this.groupData);
            this.Controls.Add(this.listViewAgenda);
            this.Controls.Add(this.buttonCarregarAgenda);
            this.Controls.Add(this.groupPaciente);
            this.Controls.Add(this.groupDentista);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AgendaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.groupDentista.ResumeLayout(false);
            this.groupDentista.PerformLayout();
            this.groupPaciente.ResumeLayout(false);
            this.groupPaciente.PerformLayout();
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            this.groupBoxLancarConsulta.ResumeLayout(false);
            this.groupBoxLancarConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupDentista;
        private System.Windows.Forms.Button buttonBuscarDentista;
        private System.Windows.Forms.TextBox txtNomeDentista;
        private System.Windows.Forms.TextBox txtIdDentista;
        private System.Windows.Forms.GroupBox groupPaciente;
        private System.Windows.Forms.Button buttonBuscarPaciente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Button buttonCarregarAgenda;
        private System.Windows.Forms.ListView listViewAgenda;
        private System.Windows.Forms.ColumnHeader columnDentista;
        private System.Windows.Forms.ColumnHeader columnPaciente;
        private System.Windows.Forms.ColumnHeader columnInicio;
        private System.Windows.Forms.ColumnHeader columnFim;
        private System.Windows.Forms.ColumnHeader columnObs;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.GroupBox groupBoxLancarConsulta;
        private System.Windows.Forms.Button buttonLancarConsulta;
        private System.Windows.Forms.TextBox textBoxObservacao1;
        private System.Windows.Forms.Label labelObservacao_1;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.DateTimePicker dateConsulta;
        private System.Windows.Forms.ComboBox comboHoraFim;
        private System.Windows.Forms.ComboBox comboHoraInicio;
        private System.Windows.Forms.Label labelFim;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.CheckBox checkBranco;
    }
}