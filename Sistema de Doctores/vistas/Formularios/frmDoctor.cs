using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Modelo.Entidades;
namespace vistas.Formularios
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }


        private void frmDoctor_Load(object sender, EventArgs e)
        {
            MostrarDoctores();
        }
        private void MostrarDoctores() {
            dgvDoctores.DataSource = null;
            dgvDoctores.DataSource = Doctor.CargarDoctores();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Aqui debemos crear el objeto Doctor
            Doctor doc = new Doctor();
            doc.Nombre = txtNombre.Text;
            doc.Apellido = txtApellido.Text;
            doc.Especialidad = txtEspecialidad.Text;
            doc.Cargo = txtCargo.Text;
            doc.InsertarDoctores();
            limiarCamposRegistrados();
            //Traemos el metodos MostrarDoctores() para verificar si se inserta y se actualiza el dataGridView
            MostrarDoctores();
        }
        private void limiarCamposRegistrados(){
            MessageBox.Show("Registro exitoso");
            txtNombre.Clear();
            txtApellido.Clear();
            txtEspecialidad.Clear();
            txtCargo.Clear();

        }

       
    }
}
