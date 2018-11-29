using Classes.DAO;
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
    public partial class AgendaView : Form
    {
        private Dentista dentista;
        private Paciente paciente;
        private List<Agenda> agenda;

        public AgendaView()
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

        private AgendaDao RetornaAgendaDao()
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            AgendaDao agendaDao = new AgendaDao(conexao);
            return agendaDao;
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

        private void buttonCarregarAgenda_Click(object sender, EventArgs e)
        {
            ValidaDentistaPaciente();
            DateTime dataInicial, dataFinal;
            dataInicial = DateTime.Parse(dateInicial.Text);
            dataFinal = DateTime.Parse(dateFinal.Text);

            if (dataInicial <= dataFinal)
            {
                CarregaList(dataInicial, dataFinal);
            }
            else
            {
                MessageBox.Show("Datas inválidas, verifique!");
                dateInicial.Focus();
            }
        }

        private void ValidaDentistaPaciente()
        {
            if (txtIdDentista.Text.Length == 0)
            {
                dentista = null;
                telaDentista(true);
            }
            if (txtIdPaciente.Text.Length == 0)
            {
                dentista = null;
                telaDentista(true);
            }
        }

        private void CarregaList(DateTime dataInicial, DateTime dataFinal)
        {
            AgendaDao agendaDao = RetornaAgendaDao();
            agenda = null;

            agenda = agendaDao.BuscaListaAgendas(dataInicial, dataFinal, paciente, dentista);

            listViewAgenda.Items.Clear();
            foreach (var a in agenda)
            {
                if (dentista != null && a.Dentista.Id1 == dentista.Id1)
                {
                    a.Dentista = dentista;
                } else
                {
                    //Fazer aqui
                }

                if (paciente != null && a.Paciente.Id == paciente.Id)
                {
                    a.Paciente = paciente;
                } else
                {
                    // fazer aqui tb
                }
                
                ListViewItem li = new ListViewItem(
                new string[] { (a.DataConsulta.ToShortDateString()),
                               (a.Dentista.Id1.ToString() + " - " + a.Dentista.Usuario.Nome),
                               (a.Paciente.Id.ToString() + " - " + a.Paciente.Usuario.Nome),
                               (a.Inicio), (a.Fim), a.Observacao_1}
                );
                listViewAgenda.Items.Add(li);

            }
        }
    }
}
