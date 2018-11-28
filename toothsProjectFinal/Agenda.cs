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
    public partial class Agenda : Form
    {
        private Dentista dentista;
        private Paciente paciente;

        public Agenda()
        {
            if (Acesso.TipoUsuario() == 2)
            {
                
            }
            else if (Acesso.TipoUsuario() == 4)
            {

            }
            InitializeComponent();
        }
    }
}
