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
    public partial class ConsultaView : Form
    {
        private Dentista dentista;
        private Paciente paciente;
        private List<Agenda> agenda;

        public ConsultaView()
        {
            InitializeComponent();
            PrepararTela();
        }

        private void PrepararTela()
        {
            if (Acesso.TipoUsuario() == 2) //Dentista
            {
                //CarregaDentista(Acesso.ID());
                groupDentista.Enabled = false;
            }
            else if (Acesso.TipoUsuario() == 4) //Paciente
            {
               // CarregaPaciente(Acesso.ID());
                groupPaciente.Enabled = false;
            }

        }




    }
}
