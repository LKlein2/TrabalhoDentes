using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Agenda
    {
        private int id;
        private DateTime dataConsulta;
        private Dentista dentista;
        private Paciente paciente;
        private string inicio;
        private string fim;
        private string observacao_1;

        public Agenda()
        {

        }

        public Agenda(int id, DateTime dataConsulta, string inicio, string fim)
        {
            this.Id = id;
            this.DataConsulta = dataConsulta;
            this.Inicio = inicio;
            this.Fim = fim;
        }

        public Agenda(int id, DateTime dataConsulta, Dentista dentista, Paciente paciente, string inicio, string fim, string observacao_1)
        {
            this.Id = id;
            this.DataConsulta = dataConsulta;
            this.Dentista = dentista;
            this.Paciente = paciente;
            this.Inicio = inicio;
            this.Fim = fim;
            this.Observacao_1 = observacao_1;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataConsulta { get => dataConsulta; set => dataConsulta = value; }
        public Dentista Dentista { get => dentista; set => dentista = value; }
        public Paciente Paciente { get => paciente; set => paciente = value; }
        public string Inicio { get => inicio; set => inicio = value; }
        public string Fim { get => fim; set => fim = value; }
        public string Observacao_1 { get => observacao_1; set => observacao_1 = value; }
    }
}
