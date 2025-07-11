﻿namespace vistas.Formularios
{
    partial class frmDashboarPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboarPrincipal));
            this.pnl_MenuPrincipal = new System.Windows.Forms.Panel();
            this.pnlMantenimientoDoctor = new System.Windows.Forms.Panel();
            this.btnVerDoctores = new FontAwesome.Sharp.IconButton();
            this.btnAgregarDoctor = new FontAwesome.Sharp.IconButton();
            this.btnDoctores = new FontAwesome.Sharp.IconButton();
            this.pnlMantenimientoCitas = new System.Windows.Forms.Panel();
            this.btnCrearCita = new FontAwesome.Sharp.IconButton();
            this.btnVerCitas = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.pnlMantenimientoPaciente = new System.Windows.Forms.Panel();
            this.btnBuscarPaciente = new FontAwesome.Sharp.IconButton();
            this.btnAgregarPaciente = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pickLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarraEstado = new System.Windows.Forms.Panel();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnl_MenuPrincipal.SuspendLayout();
            this.pnlMantenimientoDoctor.SuspendLayout();
            this.pnlMantenimientoCitas.SuspendLayout();
            this.pnlMantenimientoPaciente.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickLogo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MenuPrincipal
            // 
            this.pnl_MenuPrincipal.AutoScroll = true;
            this.pnl_MenuPrincipal.BackColor = System.Drawing.Color.Black;
            this.pnl_MenuPrincipal.Controls.Add(this.pnlMantenimientoDoctor);
            this.pnl_MenuPrincipal.Controls.Add(this.btnDoctores);
            this.pnl_MenuPrincipal.Controls.Add(this.pnlMantenimientoCitas);
            this.pnl_MenuPrincipal.Controls.Add(this.btnCitas);
            this.pnl_MenuPrincipal.Controls.Add(this.pnlMantenimientoPaciente);
            this.pnl_MenuPrincipal.Controls.Add(this.btnPacientes);
            this.pnl_MenuPrincipal.Controls.Add(this.pnlLogo);
            this.pnl_MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuPrincipal.Name = "pnl_MenuPrincipal";
            this.pnl_MenuPrincipal.Size = new System.Drawing.Size(316, 897);
            this.pnl_MenuPrincipal.TabIndex = 0;
            this.pnl_MenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_MenuPrincipal_Paint);
            // 
            // pnlMantenimientoDoctor
            // 
            this.pnlMantenimientoDoctor.Controls.Add(this.btnVerDoctores);
            this.pnlMantenimientoDoctor.Controls.Add(this.btnAgregarDoctor);
            this.pnlMantenimientoDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMantenimientoDoctor.Location = new System.Drawing.Point(0, 580);
            this.pnlMantenimientoDoctor.Name = "pnlMantenimientoDoctor";
            this.pnlMantenimientoDoctor.Size = new System.Drawing.Size(316, 82);
            this.pnlMantenimientoDoctor.TabIndex = 9;
            // 
            // btnVerDoctores
            // 
            this.btnVerDoctores.BackColor = System.Drawing.Color.Black;
            this.btnVerDoctores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerDoctores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVerDoctores.FlatAppearance.BorderSize = 0;
            this.btnVerDoctores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnVerDoctores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnVerDoctores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVerDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDoctores.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDoctores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerDoctores.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnVerDoctores.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnVerDoctores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerDoctores.IconSize = 40;
            this.btnVerDoctores.Location = new System.Drawing.Point(0, 40);
            this.btnVerDoctores.Name = "btnVerDoctores";
            this.btnVerDoctores.Size = new System.Drawing.Size(316, 40);
            this.btnVerDoctores.TabIndex = 1;
            this.btnVerDoctores.Text = "Buscar Doctores";
            this.btnVerDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerDoctores.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.BackColor = System.Drawing.Color.Black;
            this.btnAgregarDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDoctor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregarDoctor.FlatAppearance.BorderSize = 0;
            this.btnAgregarDoctor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnAgregarDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnAgregarDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoctor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarDoctor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregarDoctor.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnAgregarDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarDoctor.IconSize = 40;
            this.btnAgregarDoctor.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(316, 40);
            this.btnAgregarDoctor.TabIndex = 0;
            this.btnAgregarDoctor.Text = "Agregar Doctores";
            this.btnAgregarDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDoctor.UseVisualStyleBackColor = false;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.btnAgregarDoctor_Click);
            // 
            // btnDoctores
            // 
            this.btnDoctores.BackColor = System.Drawing.Color.Black;
            this.btnDoctores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDoctores.FlatAppearance.BorderSize = 0;
            this.btnDoctores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnDoctores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnDoctores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctores.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoctores.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnDoctores.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnDoctores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctores.Location = new System.Drawing.Point(0, 500);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Size = new System.Drawing.Size(316, 80);
            this.btnDoctores.TabIndex = 5;
            this.btnDoctores.Text = "Gestion de Doctores";
            this.btnDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctores.UseVisualStyleBackColor = false;
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // pnlMantenimientoCitas
            // 
            this.pnlMantenimientoCitas.Controls.Add(this.btnCrearCita);
            this.pnlMantenimientoCitas.Controls.Add(this.btnVerCitas);
            this.pnlMantenimientoCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMantenimientoCitas.Location = new System.Drawing.Point(0, 413);
            this.pnlMantenimientoCitas.Name = "pnlMantenimientoCitas";
            this.pnlMantenimientoCitas.Size = new System.Drawing.Size(316, 87);
            this.pnlMantenimientoCitas.TabIndex = 8;
            // 
            // btnCrearCita
            // 
            this.btnCrearCita.BackColor = System.Drawing.Color.Black;
            this.btnCrearCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCrearCita.FlatAppearance.BorderSize = 0;
            this.btnCrearCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnCrearCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnCrearCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCrearCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCita.ForeColor = System.Drawing.Color.White;
            this.btnCrearCita.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCrearCita.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnCrearCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearCita.IconSize = 40;
            this.btnCrearCita.Location = new System.Drawing.Point(0, 40);
            this.btnCrearCita.Name = "btnCrearCita";
            this.btnCrearCita.Size = new System.Drawing.Size(316, 40);
            this.btnCrearCita.TabIndex = 1;
            this.btnCrearCita.Text = "Crear cita";
            this.btnCrearCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCita.UseVisualStyleBackColor = false;
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.BackColor = System.Drawing.Color.Black;
            this.btnVerCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVerCitas.FlatAppearance.BorderSize = 0;
            this.btnVerCitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnVerCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnVerCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVerCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCitas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCitas.ForeColor = System.Drawing.Color.White;
            this.btnVerCitas.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerCitas.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnVerCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerCitas.IconSize = 40;
            this.btnVerCitas.Location = new System.Drawing.Point(0, 0);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(316, 40);
            this.btnVerCitas.TabIndex = 0;
            this.btnVerCitas.Text = "Ver citas";
            this.btnVerCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerCitas.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.Black;
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.btnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCitas.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 333);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(316, 80);
            this.btnCitas.TabIndex = 4;
            this.btnCitas.Text = "Gestion de Citas Medicas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // pnlMantenimientoPaciente
            // 
            this.pnlMantenimientoPaciente.Controls.Add(this.btnBuscarPaciente);
            this.pnlMantenimientoPaciente.Controls.Add(this.btnAgregarPaciente);
            this.pnlMantenimientoPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMantenimientoPaciente.Location = new System.Drawing.Point(0, 244);
            this.pnlMantenimientoPaciente.Name = "pnlMantenimientoPaciente";
            this.pnlMantenimientoPaciente.Size = new System.Drawing.Size(316, 89);
            this.pnlMantenimientoPaciente.TabIndex = 7;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarPaciente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarPaciente.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnBuscarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPaciente.IconSize = 40;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(0, 40);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(316, 43);
            this.btnBuscarPaciente.TabIndex = 1;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.Black;
            this.btnAgregarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnAgregarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPaciente.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btnAgregarPaciente.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnAgregarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPaciente.IconSize = 40;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(316, 40);
            this.btnAgregarPaciente.TabIndex = 0;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            this.btnAgregarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.Black;
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPacientes.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 164);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(316, 80);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Gestion de Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pickLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(316, 164);
            this.pnlLogo.TabIndex = 0;
            // 
            // pickLogo
            // 
            this.pickLogo.Image = ((System.Drawing.Image)(resources.GetObject("pickLogo.Image")));
            this.pickLogo.Location = new System.Drawing.Point(45, 18);
            this.pickLogo.Name = "pickLogo";
            this.pickLogo.Size = new System.Drawing.Size(144, 140);
            this.pickLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickLogo.TabIndex = 0;
            this.pickLogo.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Black;
            this.pnlTitulo.Controls.Add(this.lblOpciones);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(316, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1131, 85);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.BackColor = System.Drawing.Color.Black;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblOpciones.Location = new System.Drawing.Point(3, 56);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(118, 26);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "suopciones";
            this.lblOpciones.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(417, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(594, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA ADMINISTRATIVO DE DOCTORES V.01";
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Black;
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(316, 797);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(1131, 100);
            this.pnlBarraEstado.TabIndex = 2;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(316, 85);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1131, 712);
            this.pnlCuerpo.TabIndex = 3;
            // 
            // frmDashboarPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 897);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnl_MenuPrincipal);
            this.Name = "frmDashboarPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboarPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboarPrincipal_Load);
            this.pnl_MenuPrincipal.ResumeLayout(false);
            this.pnlMantenimientoDoctor.ResumeLayout(false);
            this.pnlMantenimientoCitas.ResumeLayout(false);
            this.pnlMantenimientoPaciente.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pickLogo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MenuPrincipal;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlBarraEstado;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pickLogo;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnCitas;
        private FontAwesome.Sharp.IconButton btnDoctores;
        private System.Windows.Forms.Panel pnlMantenimientoPaciente;
        private FontAwesome.Sharp.IconButton btnBuscarPaciente;
        private FontAwesome.Sharp.IconButton btnAgregarPaciente;
        private System.Windows.Forms.Panel pnlMantenimientoCitas;
        private FontAwesome.Sharp.IconButton btnCrearCita;
        private FontAwesome.Sharp.IconButton btnVerCitas;
        private System.Windows.Forms.Panel pnlMantenimientoDoctor;
        private FontAwesome.Sharp.IconButton btnVerDoctores;
        private FontAwesome.Sharp.IconButton btnAgregarDoctor;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOpciones;
    }
}