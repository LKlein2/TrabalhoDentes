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
            PopularComboBoxHora();
            VerificarDatasAgenda();
        }

        private void PopularComboBoxHora()
        {
            comboHoraInicio.Items.Add("8:00");
            comboHoraInicio.Items.Add("9:00");
            comboHoraInicio.Items.Add("10:00");
            comboHoraInicio.Items.Add("11:00");
            comboHoraInicio.Items.Add("13:00");
            comboHoraInicio.Items.Add("14:00");
            comboHoraInicio.Items.Add("15:00");
            comboHoraInicio.Items.Add("16:00");
            comboHoraInicio.Items.Add("17:00");

            comboHoraFim.Items.Add("9:00");
            comboHoraFim.Items.Add("10:00");
            comboHoraFim.Items.Add("11:00");
            comboHoraFim.Items.Add("12:00");
            comboHoraFim.Items.Add("14:00");
            comboHoraFim.Items.Add("15:00");
            comboHoraFim.Items.Add("16:00");
            comboHoraFim.Items.Add("17:00");
            comboHoraFim.Items.Add("18:00");
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

        private void buttonLancar_Click(object sender, EventArgs e)
        {
            if (agenda == null)
            {
                MessageBox.Show("Consulte a agenda antes de lançar consultas !");
                buttonCarregarAgenda.Focus();
                return;
            }

            AgendaDao agendaDao = RetornaAgendaDao();

            if (paciente != null && dentista != null)
            {
                Agenda novaConsulta = new Agenda(1, dateConsulta.Value, dentista, paciente, comboHoraInicio.Text, comboHoraFim.Text, textBoxObservacao1.Text);
                agendaDao.Inserir(novaConsulta);
                MessageBox.Show("Agendado com sucesso !");
                LimparDadosConsulta();
            }
            else
            {
                MessageBox.Show("Selecione um paciente antes !");
                txtIdPaciente.Focus();
            }           

        }

        private void LimparDadosConsulta()
        {
            dateConsulta.Value = DateTime.Now;
            comboHoraInicio.SelectedIndex = -1;
            comboHoraFim.SelectedIndex = -1;
            textBoxObservacao1.Clear();
        }

        private void VerificarDatasAgenda()
        {
            AgendaDao agendaDao = RetornaAgendaDao();
            DateTime data = new DateTime(DateTime.Now.Year, 1, 1);

            if (agendaDao.IsPopulada(data) == false)
            {
                CriarConsultas();
            }
          
        }

        private void CriarConsultas()
        {
            AgendaDao agendaDao = RetornaAgendaDao();
            Agenda novoHorario = new Agenda();
            DateTime dataInicio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime dataFim = new DateTime(DateTime.Now.Year, 12, 31);

            for (DateTime data = dataInicio; data < dataFim; data = data.AddDays(1))
            {
               if ((int)data.DayOfWeek == 1 || (int)data.DayOfWeek == 2 || (int)data.DayOfWeek == 3 || (int)data.DayOfWeek == 4 || (int)data.DayOfWeek == 5)
                {
                    novoHorario = new Agenda(1, data.Date, null, null, "08:00", "09:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "09:00", "10:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "10:00", "11:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "11:00", "12:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "13:00", "14:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "14:00", "15:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "15:00", "16:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "16:00", "17:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                    novoHorario = new Agenda(1, data.Date, null, null, "17:00", "18:00", "");
                    agendaDao.PopularAgenda(novoHorario);
                }
            }
 
        }

    }
}
