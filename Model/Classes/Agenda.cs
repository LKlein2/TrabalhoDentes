using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Agenda
    {
        private DateTime data;
        private DateTime horaInicial;
        private DateTime horaFinal;

        public Agenda () { }

        public Agenda (DateTime data, DateTime horaInicial, DateTime horaFinal)
        {
            this.data = data;
            this.horaInicial = horaInicial;
            this.horaFinal = horaFinal;
        }

        public DateTime Data { get => data; set => data = value; }
        public DateTime HoraInicial { get => horaInicial; set => horaInicial = value; }
        public DateTime HoraFinal { get => horaFinal; set => horaFinal = value; }

    }
}
