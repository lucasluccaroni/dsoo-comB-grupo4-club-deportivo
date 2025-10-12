namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmInscripcionSocio
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
            btnVolver = new Button();
            btnIngresar = new Button();
            lblTituloInscripcion = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            txtDireccion = new TextBox();
            dtpFechaNac = new DateTimePicker();
            chkFichaMedica = new CheckBox();
            lblFechaNac = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(688, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 32);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.PaleGreen;
            btnIngresar.Location = new Point(688, 397);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(83, 32);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblTituloInscripcion
            // 
            lblTituloInscripcion.AutoSize = true;
            lblTituloInscripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTituloInscripcion.Location = new Point(125, 23);
            lblTituloInscripcion.Name = "lblTituloInscripcion";
            lblTituloInscripcion.Size = new Size(224, 30);
            lblTituloInscripcion.TabIndex = 2;
            lblTituloInscripcion.Text = "Registrar nuevo socio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(192, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(350, 101);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(33, 160);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(192, 160);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Mail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(33, 221);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(259, 23);
            txtDireccion.TabIndex = 8;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(33, 291);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(117, 23);
            dtpFechaNac.TabIndex = 9;
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Location = new Point(196, 282);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(96, 19);
            chkFichaMedica.TabIndex = 10;
            chkFichaMedica.Text = "Ficha Médica";
            chkFichaMedica.UseVisualStyleBackColor = true;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(33, 273);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(117, 15);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha de nacimiento";
            lblFechaNac.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.Location = new Point(688, 330);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 32);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripcionSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(lblFechaNac);
            Controls.Add(chkFichaMedica);
            Controls.Add(dtpFechaNac);
            Controls.Add(txtDireccion);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTituloInscripcion);
            Controls.Add(btnIngresar);
            Controls.Add(btnVolver);
            Name = "frmInscripcionSocio";
            Text = "Inscripcion -> Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnIngresar;
        private Label lblTituloInscripcion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private TextBox txtDireccion;
        private DateTimePicker dtpFechaNac;
        private CheckBox chkFichaMedica;
        private Label lblFechaNac;
        private Button btnLimpiar;
    }
}