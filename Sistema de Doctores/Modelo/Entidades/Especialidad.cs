using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Especialidad
    {
        private int  idEspecialidad;
        private string nombre;
        private string descripcion;
        private bool activo;

        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Activo { get => activo; set => activo = value; }

        //Metodo cargar Especialidades

        public static DataTable CargarEspecialidades()
        {
            //Establecemos la conexion
            SqlConnection conexion = Conexion.ConexionDB.Conectar();
            string consultaQueryEspecialidades = "Select Id_Especialidad,Nombre from Especialidades";
            SqlDataAdapter add = new SqlDataAdapter(consultaQueryEspecialidades, conexion);
            DataTable dataVirtual = new DataTable();
            add.Fill(dataVirtual);
            return dataVirtual;
        }

    }
}
