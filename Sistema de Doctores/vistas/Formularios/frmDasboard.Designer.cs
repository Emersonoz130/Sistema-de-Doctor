namespace vistas.Formularios
{
    partial class frmDasboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDasboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBarraEstado = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.btnGestionarPacientes = new FontAwesome.Sharp.IconButton();
            this.btnBuscarExpedientes = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSistema = new FontAwesome.Sharp.IconButton();
            this.btnGestionUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelDatos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 1061);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1135, 80);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelBarraEstado
            // 
            this.panelBarraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBarraEstado.Location = new System.Drawing.Point(200, 961);
            this.panelBarraEstado.Name = "panelBarraEstado";
            this.panelBarraEstado.Size = new System.Drawing.Size(1135, 100);
            this.panelBarraEstado.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 162);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.btnReportes);
            this.panelDatos.Controls.Add(this.btnBuscarExpedientes);
            this.panelDatos.Controls.Add(this.btnGestionarPacientes);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(0, 162);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(200, 667);
            this.panelDatos.TabIndex = 1;
            // 
            // btnGestionarPacientes
            // 
            this.btnGestionarPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnGestionarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarPacientes.FlatAppearance.BorderSize = 0;
            this.btnGestionarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPacientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGestionarPacientes.IconColor = System.Drawing.Color.DarkRed;
            this.btnGestionarPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarPacientes.Name = "btnGestionarPacientes";
            this.btnGestionarPacientes.Size = new System.Drawing.Size(200, 92);
            this.btnGestionarPacientes.TabIndex = 0;
            this.btnGestionarPacientes.Text = "Gestionar Pacientes";
            this.btnGestionarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionarPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarPacientes.UseVisualStyleBackColor = false;
            // 
            // btnBuscarExpedientes
            // 
            this.btnBuscarExpedientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.btnBuscarExpedientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarExpedientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarExpedientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscarExpedientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarExpedientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarExpedientes.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnBuscarExpedientes.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscarExpedientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarExpedientes.Location = new System.Drawing.Point(0, 92);
            this.btnBuscarExpedientes.Name = "btnBuscarExpedientes";
            this.btnBuscarExpedientes.Size = new System.Drawing.Size(200, 72);
            this.btnBuscarExpedientes.TabIndex = 1;
            this.btnBuscarExpedientes.Text = "Buscar Expedientes";
            this.btnBuscarExpedientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarExpedientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarExpedientes.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnReportes.IconColor = System.Drawing.Color.DarkRed;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.Location = new System.Drawing.Point(0, 164);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 72);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnGestionUsuarios);
            this.panel1.Controls.Add(this.btnSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 829);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 540);
            this.panel1.TabIndex = 1;
            // 
            // btnSistema
            // 
            this.btnSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnSistema.IconColor = System.Drawing.Color.DarkRed;
            this.btnSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSistema.Location = new System.Drawing.Point(0, 0);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(200, 75);
            this.btnSistema.TabIndex = 0;
            this.btnSistema.Text = "Sistemas";
            this.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSistema.UseVisualStyleBackColor = false;
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.btnGestionUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnGestionUsuarios.IconColor = System.Drawing.Color.DarkRed;
            this.btnGestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(0, 75);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(200, 82);
            this.btnGestionUsuarios.TabIndex = 2;
            this.btnGestionUsuarios.Text = "Usuarios de Sistemas";
            this.btnGestionUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.DarkRed;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 157);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 72);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // frmDasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 1061);
            this.Controls.Add(this.panelBarraEstado);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmDasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDasboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelBarraEstado;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDatos;
        private FontAwesome.Sharp.IconButton btnGestionarPacientes;
        private FontAwesome.Sharp.IconButton btnBuscarExpedientes;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSistema;
        private FontAwesome.Sharp.IconButton btnGestionUsuarios;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}