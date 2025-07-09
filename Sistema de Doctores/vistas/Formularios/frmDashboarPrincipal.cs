using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas.Formularios
{
    public partial class frmDashboarPrincipal: Form
    {
        public frmDashboarPrincipal()
        {
            InitializeComponent();
        }

        #region Mis variables
        private Form activarform =null;
        #endregion
        #region "Mis metodos"
        private void AbrirForm(Form formulario) {
            if (activarform!=null) {
            //Aqui lo que estamos viendo si esta creado si esta creado se cerrara y crearemos otro form
            activarform.Close();
            }
            activarform=formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlCuerpo.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        
        }
        #endregion

        private void PanelesSubOpciones(bool estado)
        {
            //Le paso los estados segun la opcion que seleccione en el boton
            pnlMantenimientoPaciente.Visible = estado;
            pnlMantenimientoCitas.Visible = estado;
            pnlMantenimientoDoctor.Visible = estado;
        }

        private void frmDashboarPrincipal_Load(object sender, EventArgs e)
        {
            this.PanelesSubOpciones(false);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            this.pnlMantenimientoCitas.Visible = false;
            this.pnlMantenimientoDoctor.Visible = false;
            if (this.pnlMantenimientoPaciente.Visible ==false) {
                this.pnlMantenimientoPaciente.Visible = true;
            } 
            
            else {
                this.PanelesSubOpciones(false);
            }
 
            
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.pnlMantenimientoPaciente.Visible = false;
            this.pnlMantenimientoDoctor.Visible = false;
            if (this.pnlMantenimientoCitas.Visible == false)
            {
                this.pnlMantenimientoCitas.Visible = true;
            }

            else
            {
                this.PanelesSubOpciones(false);
            }
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            this.pnlMantenimientoPaciente.Visible = false;
            this.pnlMantenimientoCitas.Visible = false;
            if (this.pnlMantenimientoDoctor.Visible == false)
            {
                this.pnlMantenimientoDoctor.Visible = true;
            }

            else
            {
                this.PanelesSubOpciones(false);
            }

        }

        private void pnl_MenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarDoctor_Click(object sender, EventArgs e)
        {
            this.lblOpciones.Text = "REGISTRO DE DOCTORES";
            this.lblOpciones.Visible = true;
            AbrirForm(new frmDoctor());
        }

     
    }
}
