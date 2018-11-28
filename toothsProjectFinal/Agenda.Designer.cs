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
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupDataIni = new System.Windows.Forms.GroupBox();
            this.txtDataIni = new System.Windows.Forms.TextBox();
            this.groupDataFim = new System.Windows.Forms.GroupBox();
            this.txtDataFim = new System.Windows.Forms.TextBox();
            this.groupDentista.SuspendLayout();
            this.groupPaciente.SuspendLayout();
            this.groupDataIni.SuspendLayout();
            this.groupDataFim.SuspendLayout();
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
            this.buttonCarregarAgenda.Size = new System.Drawing.Size(131, 38);
            this.buttonCarregarAgenda.TabIndex = 3;
            this.buttonCarregarAgenda.Text = "CARREGAR AGENDA";
            this.buttonCarregarAgenda.UseVisualStyleBackColor = true;
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
            // columnDentista
            // 
            this.columnDentista.DisplayIndex = 0;
            this.columnDentista.Text = "Dentista";
            this.columnDentista.Width = 123;
            // 
            // columnPaciente
            // 
            this.columnPaciente.DisplayIndex = 1;
            this.columnPaciente.Text = "Paciente";
            this.columnPaciente.Width = 121;
            // 
            // columnInicio
            // 
            this.columnInicio.DisplayIndex = 2;
            this.columnInicio.Text = "Inicio";
            // 
            // columnFim
            // 
            this.columnFim.DisplayIndex = 3;
            this.columnFim.Text = "Fim";
            // 
            // columnObs
            // 
            this.columnObs.DisplayIndex = 4;
            this.columnObs.Text = "Observações";
            this.columnObs.Width = 233;
            // 
            // columnData
            // 
            this.columnData.DisplayIndex = 5;
            this.columnData.Text = "Data";
            // 
            // groupDataIni
            // 
            this.groupDataIni.Controls.Add(this.txtDataIni);
            this.groupDataIni.Location = new System.Drawing.Point(11, 66);
            this.groupDataIni.Margin = new System.Windows.Forms.Padding(2);
            this.groupDataIni.Name = "groupDataIni";
            this.groupDataIni.Padding = new System.Windows.Forms.Padding(2);
            this.groupDataIni.Size = new System.Drawing.Size(103, 47);
            this.groupDataIni.TabIndex = 5;
            this.groupDataIni.TabStop = false;
            this.groupDataIni.Text = "Data inicial";
            // 
            // txtDataIni
            // 
            this.txtDataIni.Location = new System.Drawing.Point(14, 17);
            this.txtDataIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataIni.Name = "txtDataIni";
            this.txtDataIni.Size = new System.Drawing.Size(76, 20);
            this.txtDataIni.TabIndex = 0;
            // 
            // groupDataFim
            // 
            this.groupDataFim.Controls.Add(this.txtDataFim);
            this.groupDataFim.Location = new System.Drawing.Point(118, 66);
            this.groupDataFim.Margin = new System.Windows.Forms.Padding(2);
            this.groupDataFim.Name = "groupDataFim";
            this.groupDataFim.Padding = new System.Windows.Forms.Padding(2);
            this.groupDataFim.Size = new System.Drawing.Size(103, 47);
            this.groupDataFim.TabIndex = 6;
            this.groupDataFim.TabStop = false;
            this.groupDataFim.Text = "Data final";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Location = new System.Drawing.Point(14, 17);
            this.txtDataFim.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(76, 20);
            this.txtDataFim.TabIndex = 0;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 285);
            this.Controls.Add(this.groupDataFim);
            this.Controls.Add(this.groupDataIni);
            this.Controls.Add(this.listViewAgenda);
            this.Controls.Add(this.buttonCarregarAgenda);
            this.Controls.Add(this.groupPaciente);
            this.Controls.Add(this.groupDentista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.groupDentista.ResumeLayout(false);
            this.groupDentista.PerformLayout();
            this.groupPaciente.ResumeLayout(false);
            this.groupPaciente.PerformLayout();
            this.groupDataIni.ResumeLayout(false);
            this.groupDataIni.PerformLayout();
            this.groupDataFim.ResumeLayout(false);
            this.groupDataFim.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupDataIni;
        private System.Windows.Forms.TextBox txtDataIni;
        private System.Windows.Forms.GroupBox groupDataFim;
        private System.Windows.Forms.TextBox txtDataFim;
    }
}