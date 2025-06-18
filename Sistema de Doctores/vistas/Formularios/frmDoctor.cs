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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            MostrarDoctores();
        }
        private void MostrarDoctores() {
            dgvDoctores.DataSource = null;
            dgvDoctores.DataSource = Doctor.CargarDoctores();
        }

      
    }
}
