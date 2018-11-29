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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao usuarioDao = new UsuarioDao(conexao);
            Usuario u = usuarioDao.LocalizarPorLogin(txtUsuario.Text, txtSenha.Text);
            if (u != null)
            {
                AbreMenu(u);
            } else
            {
                FalhaAutenticacao();
            }
        }

        private void AbreMenu(Usuario usuario)
        {
            IAutenticavel a = null;
            if (usuario.TipoAcesso == 2)
            {
                a = new Dentista(usuario);
            } else if (usuario.TipoAcesso == 3)
            {
                a = new Secretaria(usuario);
            } else if (usuario.TipoAcesso == 4)
            {
                a = new Paciente(usuario);
            }
            MenuView menu = new MenuView(a);
            menu.Show();
            this.Hide();
        }

        private void FalhaAutenticacao()
        {
            labelMsg.Text = "Login ou senha inválidos!";
            labelMsg.ForeColor = Color.Red;
        }

    }
}
