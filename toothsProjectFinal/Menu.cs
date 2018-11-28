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
    public partial class Menu : Form
    {
        public Menu(IAutenticavel autenticavel)
        {
            if (autenticavel != null)
            {
                Acesso.setaAcesso(autenticavel);
                this.Text += "DentistaApp - " + autenticavel.Autenticacao();
                Console.WriteLine(autenticavel.Autenticacao());
            }
            InitializeComponent();
        }    

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            if (Acesso.TipoUsuario() != 4)
            { 
                Agenda mostraAgenda = new Agenda();
                mostraAgenda.Show();
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastroUsuario = new frmCadastro();
            cadastroUsuario.Show();
        }
    }

    public static class Acesso
    {
        private static int id;
        private static int tipoUsuario;
        private static IAdministrativel administrativel;

        public static void setaAcesso(IAutenticavel a)
        {
            Acesso.id = a.idUsuario();
            Acesso.tipoUsuario = a.tipoUsuario();
            Acesso.administrativel = RetAdm();
        }

        private static IAdministrativel RetAdm()
        {
            IAdministrativel a = null;
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao usuarioDao = new UsuarioDao(conexao);
            Usuario u = usuarioDao.LocalizarPorId(Acesso.id);
            if (u.TipoAcesso == 2)
            {
                Dentista d = new Dentista(u);
                a = d;
                
            }
            else if (u.TipoAcesso == 3)
            {
                Secretaria s = new Secretaria(u);
                a = s;
            }
            return a;
        }

        public static int ID()
        {
            return Acesso.id;
        }

        public static int TipoUsuario()
        {
            return Acesso.tipoUsuario;
        }

        public static IAdministrativel Administrativel()
        {
            return Acesso.administrativel;
        }

    }
}
