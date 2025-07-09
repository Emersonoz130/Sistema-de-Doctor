namespace vistas.Formularios
{
    partial class frmDoctor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDoctor = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDoctores = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.gbDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDoctor
            // 
            this.gbDoctor.Controls.Add(this.cmbEspecialidad);
            this.gbDoctor.Controls.Add(this.btnEliminar);
            this.gbDoctor.Controls.Add(this.btnInsertar);
            this.gbDoctor.Controls.Add(this.btnActualizar);
            this.gbDoctor.Controls.Add(this.txtCargo);
            this.gbDoctor.Controls.Add(this.txtApellido);
            this.gbDoctor.Controls.Add(this.lblCargo);
            this.gbDoctor.Controls.Add(this.lblEspecialidad);
            this.gbDoctor.Controls.Add(this.txtNombre);
            this.gbDoctor.Controls.Add(this.lblapellido);
            this.gbDoctor.Controls.Add(this.lblNombre);
            this.gbDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDoctor.Location = new System.Drawing.Point(187, 37);
            this.gbDoctor.Name = "gbDoctor";
            this.gbDoctor.Size = new System.Drawing.Size(1070, 223);
            this.gbDoctor.TabIndex = 0;
            this.gbDoctor.TabStop = false;
            this.gbDoctor.Text = "Datos del Doctor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(858, 135);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Black;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertar.Location = new System.Drawing.Point(858, 83);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(101, 40);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(858, 33);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 40);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(154, 149);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(657, 26);
            this.txtCargo.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(657, 26);
            this.txtApellido.TabIndex = 1;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(6, 148);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(62, 20);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(6, 113);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(116, 20);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(657, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(6, 69);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(78, 20);
            this.lblapellido.TabIndex = 0;
            this.lblapellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // dgvDoctores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctores.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDoctores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoctores.EnableHeadersVisualStyles = false;
            this.dgvDoctores.GridColor = System.Drawing.Color.Black;
            this.dgvDoctores.Location = new System.Drawing.Point(187, 317);
            this.dgvDoctores.Name = "dgvDoctores";
            this.dgvDoctores.ReadOnly = true;
            this.dgvDoctores.RowHeadersVisible = false;
            this.dgvDoctores.Size = new System.Drawing.Size(1070, 481);
            this.dgvDoctores.TabIndex = 1;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(154, 110);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(657, 28);
            this.cmbEspecialidad.TabIndex = 3;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1284, 823);
            this.Controls.Add(this.dgvDoctores);
            this.Controls.Add(this.gbDoctor);
            this.Name = "frmDoctor";
            this.Text = "frmDoctor";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.gbDoctor.ResumeLayout(false);
            this.gbDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoctor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvDoctores;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}