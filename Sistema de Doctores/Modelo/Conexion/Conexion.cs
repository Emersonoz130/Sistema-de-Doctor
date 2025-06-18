using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modelo.Conexion
{
    public class Conexion
    {
        private static string servidor= "LAB02-DS-EQ02\\SQLEXPRESS";
        private static string baseDeDatos= "dbHospital";

        public static SqlConnection Conectar() {
            string cadena = $"Data source={servidor};Initial Catalog={baseDeDatos};Integrated Security = true;";
            SqlConnection conexion= new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
        //public static bool VerificarConexion()
        //{
        //    try
        //    {
        //        using (SqlConnection conn = Conectar())
        //        {
        //            return conn.State == ConnectionState.Open;
        //        }
        //    }
        //    catch
        //    {
        //        Console.Write("no se pudo conectar");
        //        return false;
        //    }
        //}
    }
}
