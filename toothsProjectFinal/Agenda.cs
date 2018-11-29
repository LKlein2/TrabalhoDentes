using DAO;
using DAO.Classes;
using DAO.Interfaces;
using Model;
using Model.Excessões;
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
    public partial class Agenda : Form
    {
        private Dentista dentista;
        private Paciente paciente;

        public Agenda()
        {
            InitializeComponent();
            PrepararTela();
        }

        private void PrepararTela()
        {
            if (Acesso.TipoUsuario() == 2) //Dentista
            {
                CarregaDentista(Acesso.ID());
                groupDentista.Enabled = false;
            }
            else if (Acesso.TipoUsuario() == 4) //Paciente
            {
                CarregaPaciente(Acesso.ID());
                groupPaciente.Enabled = false;
            }

        }

        private UsuarioDao RetornaUsuarioDAO()
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao usuarioDao = new UsuarioDao(conexao);
            return usuarioDao;
        }

        private void CarregaDentista(int id)
        {
            UsuarioDao usuarioDao = RetornaUsuarioDAO();
            try
            {
                dentista = new Dentista(usuarioDao.LocalizarPorId(id));
                telaDentista();
            } catch (TipoInvalidoException e)
            {
                MessageBox.Show(e.Message);
                telaDentista(true);
            }
        }

        private void CarregaPaciente(int id)
        {
            UsuarioDao usuarioDao = RetornaUsuarioDAO();
            try
            {
                paciente = new Paciente(usuarioDao.LocalizarPorId(id));
                telaPaciente();
            } catch (TipoInvalidoException e)
            {
                MessageBox.Show(e.Message);
                telaPaciente(true);
            }
        }
        
        private void telaDentista(bool apaga = false)
        {
            if (apaga)
            {
                txtIdDentista.Text = "";
                txtNomeDentista.Text = "";
            } else
            {
                txtIdDentista.Text = dentista.Usuario.ID.ToString();
                txtNomeDentista.Text = dentista.Usuario.Nome;
            }
        }
        
        private void telaPaciente(bool apaga = false)
        {
            if (apaga)
            {
                txtIdPaciente.Text = "";
                txtNomePaciente.Text = "";
            }
            else
            {
                txtIdPaciente.Text = paciente.Usuario.ID.ToString();
                txtNomePaciente.Text = paciente.Usuario.Nome;
            }
        }

        private void buttonBuscarDentista_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = int.Parse(txtIdDentista.Text);
                CarregaDentista(id);
            } catch (FormatException a)
            {
                MessageBox.Show("Formato inválido, verifique o codigo do dentista!");
            }
            
        }

        private void buttonBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = int.Parse(txtIdPaciente.Text);
                CarregaPaciente(id);
            }
            catch (FormatException a)
            {
                MessageBox.Show("Formato inválido, verifique o codigo do paciente!");
            }
        }


    }
}
