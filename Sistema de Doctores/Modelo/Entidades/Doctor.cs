using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Modelo.Entidades
{
    public class Doctor
    {
        private int idDoctor;
        private string nombre;
        private string apellido;
        private string especialidad;
        private string cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int IdDoctor { get => idDoctor; set => idDoctor = value; }


        //Metodo para mostrar la informacion
        public static DataTable CargarDoctores() {
            //Establecemos la conexion
            SqlConnection conexion= Conexion.Conexion.Conectar();
            //Creamos el query
            string consulataQuery = "select Nombre,Apellido,Especialidad,Cargo from Doctores;";
            //Creamos un objeto adapter para obtener el resultado de nuestro select * from o query
            //que para que funcione le pasamos la consulta y una conexion
            SqlDataAdapter add = new SqlDataAdapter(consulataQuery, conexion);
            //Crearemos una tabla virtual en la que guardaremos la informacionq que pedimos
            //para luego mostrarla en dataGridView
            DataTable dataVirtual = new DataTable();
            //El metodo fill rellena todo es decir , del adaptador con el metodo fill (rellenar) le decimos que 
            //Llenaremos la tabla virtural para retornar la tabla rellena de todos los datos que tenga la tabla en la base de datos
            add.Fill(dataVirtual);
            return dataVirtual;
        }

        public bool InsertarDoctores() {
            //siempre traer la conexion
            SqlConnection conexion = Conexion.Conexion.Conectar();
            string consultaQueryInsert = "insert into Doctores(Nombre,Apellido,Especialidad,Cargo) VALUES(@nombre,@apellido,@especialidad,@cargo);";
            SqlCommand insertar = new SqlCommand(consultaQueryInsert,conexion);
            //Vamos a insertar o sustituir los @nombre con los datos que se obtienen en los txt
            insertar.Parameters.AddWithValue("@nombre",nombre);
            insertar.Parameters.AddWithValue("@apellido", apellido);
            insertar.Parameters.AddWithValue("@especialidad", especialidad);
            insertar.Parameters.AddWithValue("@cargo", cargo);

            //Ahora que ya insertamos debemos ejecutar la sentencia
            //utilizaremos el Metodo ExecuteNonQuery();
          
            //debemos verificar si la se inserto el dato para ello validamos con if y else
            if (insertar.ExecuteNonQuery()>0) { 
                //Porque mayor que 0 ? porque son las filas que fueron afectadas
               
                return true;
            
            } 
            else 
            { 
            return false;
            
            }


        }
    
    }

}
