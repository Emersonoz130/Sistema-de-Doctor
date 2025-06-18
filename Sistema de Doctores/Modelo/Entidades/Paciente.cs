using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Paciente
    {
        private int idPaciente;
        private string numISSS;
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private string sexo;
        private double costoTratamiento;


        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NumISSS { get => numISSS; set => numISSS = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double CostoTratamiento { get => costoTratamiento; set => costoTratamiento = value; }
    }
}
