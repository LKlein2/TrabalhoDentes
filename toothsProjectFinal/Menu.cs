using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toothsProjectFinal
{
    public partial class Menu : Form
    {
        public Menu(IAutenticavel autenticavel)
        {
            if (autenticavel != null)
                this.Text = autenticavel.Autenticacao();
            InitializeComponent();
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cadastroUsuario = new frmCadastro();
            cadastroUsuario.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
            // o que fazer para fechar o frmLogin ?
        }
    }
}
