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
            this.groupDentista.SuspendLayout();
            this.groupPaciente.SuspendLayout();
            this.groupData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDentista
            // 
            this.groupDentista.Controls.Add(this.buttonBuscarDentista);
            this.groupDentista.Controls.Add(this.txtNomeDentista);
            this.groupDentista.Controls.Add(this.txtIdDentista);
            this.groupDentista.Location = new System.Drawing.Point(11, 15);
            this.groupDentista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDentista.Name = "groupDentista";
            this.groupDentista.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDentista.Size = new System.Drawing.Size(366, 47);
            this.groupDentista.TabIndex = 1;
            this.groupDentista.TabStop = false;
            this.groupDentista.Text = "Dentista";
            // 
            // buttonBuscarDentista
            // 
            this.buttonBuscarDentista.Location = new System.Drawing.Point(308, 18);
            this.buttonBuscarDentista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarDentista.Name = "buttonBuscarDentista";
            this.buttonBuscarDentista.Size = new System.Drawing.Size(52, 19);
            this.buttonBuscarDentista.TabIndex = 2;
            this.buttonBuscarDentista.Text = "Buscar";
            this.buttonBuscarDentista.UseVisualStyleBackColor = true;
            this.buttonBuscarDentista.Click += new System.EventHandler(this.buttonBuscarDentista_Click);
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(94, 17);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(210, 20);
            this.txtNomeDentista.TabIndex = 1;
            // 
            // txtIdDentista
            // 
            this.txtIdDentista.Location = new System.Drawing.Point(14, 17);
            this.txtIdDentista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdDentista.Name = "txtIdDentista";
            this.txtIdDentista.Size = new System.Drawing.Size(76, 20);
            this.txtIdDentista.TabIndex = 0;
            // 
            // groupPaciente
            // 
            this.groupPaciente.Controls.Add(this.buttonBuscarPaciente);
            this.groupPaciente.Controls.Add(this.txtNomePaciente);
            this.groupPaciente.Controls.Add(this.txtIdPaciente);
            this.groupPaciente.Location = new System.Drawing.Point(381, 15);
            this.groupPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPaciente.Name = "groupPaciente";
            this.groupPaciente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPaciente.Size = new System.Drawing.Size(366, 47);
            this.groupPaciente.TabIndex = 2;
            this.groupPaciente.TabStop = false;
            this.groupPaciente.Text = "Paciente";
            // 
            // buttonBuscarPaciente
            // 
            this.buttonBuscarPaciente.Location = new System.Drawing.Point(307, 17);
            this.buttonBuscarPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarPaciente.Name = "buttonBuscarPaciente";
            this.buttonBuscarPaciente.Size = new System.Drawing.Size(52, 19);
            this.buttonBuscarPaciente.TabIndex = 2;
            this.buttonBuscarPaciente.Text = "Buscar";
            this.buttonBuscarPaciente.UseVisualStyleBackColor = true;
            this.buttonBuscarPaciente.Click += new System.EventHandler(this.buttonBuscarPaciente_Click);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(94, 17);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(210, 20);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(14, 17);
            this.txtIdPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(76, 20);
            this.txtIdPaciente.TabIndex = 0;
            // 
            // buttonCarregarAgenda
            // 
            this.buttonCarregarAgenda.Location = new System.Drawing.Point(616, 66);
            this.buttonCarregarAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCarregarAgenda.Name = "buttonCarregarAgenda";
            this.buttonCarregarAgenda.Size = new System.Drawing.Size(131, 47);
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
            this.listViewAgenda.Location = new System.Drawing.Point(11, 118);
            this.listViewAgenda.Name = "listViewAgenda";
            this.listViewAgenda.Size = new System.Drawing.Size(736, 158);
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
            this.groupData.Location = new System.Drawing.Point(11, 66);
            this.groupData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupData.Name = "groupData";
            this.groupData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupData.Size = new System.Drawing.Size(286, 47);
            this.groupData.TabIndex = 5;
            this.groupData.TabStop = false;
            this.groupData.Text = "Intervalo de data";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(152, 24);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(35, 13);
            this.lblFinal.TabIndex = 8;
            this.lblFinal.Text = "Final: ";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(12, 24);
            this.lblInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(40, 13);
            this.lblInicial.TabIndex = 7;
            this.lblInicial.Text = "Inicial: ";
            // 
            // dateFinal
            // 
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(191, 20);
            this.dateFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFinal.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(86, 20);
            this.dateFinal.TabIndex = 6;
            // 
            // dateInicial
            // 
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.Location = new System.Drawing.Point(55, 20);
            this.dateInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateInicial.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(86, 20);
            this.dateInicial.TabIndex = 0;
            // 
            // AgendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 285);
            this.Controls.Add(this.groupData);
            this.Controls.Add(this.listViewAgenda);
            this.Controls.Add(this.buttonCarregarAgenda);
            this.Controls.Add(this.groupPaciente);
            this.Controls.Add(this.groupDentista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgendaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.groupDentista.ResumeLayout(false);
            this.groupDentista.PerformLayout();
            this.groupPaciente.ResumeLayout(false);
            this.groupPaciente.PerformLayout();
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            this.ResumeLayout(false);

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
    }
}