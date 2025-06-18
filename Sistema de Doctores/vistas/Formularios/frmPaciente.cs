using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas.Formularios
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
            //try
            //{
            //    bool conexionExitosa = Conexion.VerificarConexion();

            //    if (conexionExitosa) // No es necesario == true
            //    {
            //        MessageBox.Show("Conexión exitosa con la base de datos",
            //                      "Conexión establecida",
            //                      MessageBoxButtons.OK,
            //                      MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo establecer conexión con la base de datos.\nPor favor verifique la configuración.",
            //                      "Error de conexión",
            //                      MessageBoxButtons.OK,
            //                      MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error inesperado al verificar conexión: {ex.Message}",
            //                  "Error crítico",
            //                  MessageBoxButtons.OK,
            //                  MessageBoxIcon.Stop);
            //}
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            //bool conexionExitosa = Conexion.VerificarConexion();
            //if (conexionExitosa) {
            //    MessageBox.Show("Se pudo conectar");
            //} 
            
            //else {
            //    MessageBox.Show("No se pudo :C");
            //}
        }
    }
}
