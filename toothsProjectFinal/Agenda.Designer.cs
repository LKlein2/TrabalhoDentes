namespace toothsProjectFinal
{
    partial class Agenda
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            this.columnDentista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnObs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupDentista.SuspendLayout();
            this.groupPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(385, 15);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // groupDentista
            // 
            this.groupDentista.Controls.Add(this.buttonBuscarDentista);
            this.groupDentista.Controls.Add(this.txtNomeDentista);
            this.groupDentista.Controls.Add(this.txtIdDentista);
            this.groupDentista.Location = new System.Drawing.Point(10, 15);
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
            this.buttonBuscarDentista.Location = new System.Drawing.Point(307, 17);
            this.buttonBuscarDentista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarDentista.Name = "buttonBuscarDentista";
            this.buttonBuscarDentista.Size = new System.Drawing.Size(52, 19);
            this.buttonBuscarDentista.TabIndex = 2;
            this.buttonBuscarDentista.Text = "Buscar";
            this.buttonBuscarDentista.UseVisualStyleBackColor = true;
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
            this.groupPaciente.Location = new System.Drawing.Point(10, 76);
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
            this.buttonCarregarAgenda.Location = new System.Drawing.Point(245, 151);
            this.buttonCarregarAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCarregarAgenda.Name = "buttonCarregarAgenda";
            this.buttonCarregarAgenda.Size = new System.Drawing.Size(131, 26);
            this.buttonCarregarAgenda.TabIndex = 3;
            this.buttonCarregarAgenda.Text = "CARREGAR AGENDA";
            this.buttonCarregarAgenda.UseVisualStyleBackColor = true;
            // 
            // listViewAgenda
            // 
            this.listViewAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDentista,
            this.columnPaciente,
            this.columnInicio,
            this.columnFim,
            this.columnObs});
            this.listViewAgenda.Location = new System.Drawing.Point(10, 196);
            this.listViewAgenda.Name = "listViewAgenda";
            this.listViewAgenda.Size = new System.Drawing.Size(602, 158);
            this.listViewAgenda.TabIndex = 4;
            this.listViewAgenda.UseCompatibleStateImageBehavior = false;
            this.listViewAgenda.View = System.Windows.Forms.View.Details;
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
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 366);
            this.Controls.Add(this.listViewAgenda);
            this.Controls.Add(this.buttonCarregarAgenda);
            this.Controls.Add(this.groupPaciente);
            this.Controls.Add(this.groupDentista);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.groupDentista.ResumeLayout(false);
            this.groupDentista.PerformLayout();
            this.groupPaciente.ResumeLayout(false);
            this.groupPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
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
    }
}