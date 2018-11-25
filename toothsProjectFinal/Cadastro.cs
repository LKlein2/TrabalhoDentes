using DAO;
using DAO.Classes;
using DAO.Interfaces;
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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao usuarioDao = new UsuarioDao(conexao);

            Usuario newUser = new Usuario(textBoxLogin.Text, textBoxSenha.Text, textBoxNome.Text);

            if (newUser != null)
            {
                usuarioDao.Inserir(newUser);
                labelMensagem.Text = "Inserido com Sucesso !";
                labelMensagem.ForeColor = Color.Green;
            }
            else
            {
                labelMensagem.Text = "Não foi possível inserir!";
                labelMensagem.ForeColor = Color.Red;
            }
        }

       
    }
}
