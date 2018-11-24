using System.Drawing;

namespace toothsProjectFinal
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDentistaApp = new System.Windows.Forms.Label();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.pacienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarAgendaToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // visualizarAgendaToolStripMenuItem
            // 
            this.visualizarAgendaToolStripMenuItem.Name = "visualizarAgendaToolStripMenuItem";
            this.visualizarAgendaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.visualizarAgendaToolStripMenuItem.Text = "Visualizar Agenda";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancarConsultaToolStripMenuItem,
            this.editarConsultaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // lancarConsultaToolStripMenuItem
            // 
            this.lancarConsultaToolStripMenuItem.Name = "lancarConsultaToolStripMenuItem";
            this.lancarConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lancarConsultaToolStripMenuItem.Text = "Paciente";
            // 
            // editarConsultaToolStripMenuItem
            // 
            this.editarConsultaToolStripMenuItem.Name = "editarConsultaToolStripMenuItem";
            this.editarConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarConsultaToolStripMenuItem.Text = "Editar Consulta";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarEditarToolStripMenuItem,
            this.secretariaToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.pacienteToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Paciente";
            // 
            // consultarEditarToolStripMenuItem
            // 
            this.consultarEditarToolStripMenuItem.Name = "consultarEditarToolStripMenuItem";
            this.consultarEditarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarEditarToolStripMenuItem.Text = "Odontologista";
            // 
            // labelDentistaApp
            // 
            this.labelDentistaApp.AutoSize = true;
            this.labelDentistaApp.BackColor = System.Drawing.Color.Transparent;
            this.labelDentistaApp.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDentistaApp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDentistaApp.Location = new System.Drawing.Point(346, 188);
            this.labelDentistaApp.Name = "labelDentistaApp";
            this.labelDentistaApp.Size = new System.Drawing.Size(216, 42);
            this.labelDentistaApp.TabIndex = 1;
            this.labelDentistaApp.Text = "Dentista App";
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secretariaToolStripMenuItem.Text = "Secretaria";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::toothsProjectFinal.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDentistaApp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentistaApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lancarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEditarToolStripMenuItem;
        private System.Windows.Forms.Label labelDentistaApp;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
    }
}