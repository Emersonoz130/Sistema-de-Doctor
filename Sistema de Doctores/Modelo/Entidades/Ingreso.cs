using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Ingreso
    {
        private int idIngreso;
        private int idPaciente;
        private DateTime fechaIngreso;
        private int idDoctor;
        private string diagnostico;

        public int IdIngreso { get => idIngreso; set => idIngreso = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
    }
}
