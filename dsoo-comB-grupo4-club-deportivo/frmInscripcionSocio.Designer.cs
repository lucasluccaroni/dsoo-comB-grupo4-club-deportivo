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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            lblMail = new Label();
            lblDireccion = new Label();
            btnCobrarCuota = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
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
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Font = new Font("Segoe UI", 12F);
            btnIngresar.Location = new Point(675, 408);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 43);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblTituloInscripcion
            // 
            lblTituloInscripcion.AutoSize = true;
            lblTituloInscripcion.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTituloInscripcion.Location = new Point(254, 12);
            lblTituloInscripcion.Name = "lblTituloInscripcion";
            lblTituloInscripcion.Size = new Size(262, 32);
            lblTituloInscripcion.TabIndex = 2;
            lblTituloInscripcion.Text = "Registrar nuevo socio";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(119, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su nombre";
            txtNombre.Size = new Size(168, 29);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(328, 105);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese su apellido";
            txtApellido.Size = new Size(168, 29);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 12F);
            txtDni.Location = new Point(522, 105);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su DNI";
            txtDni.Size = new Size(168, 29);
            txtDni.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(119, 176);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese su teléfono";
            txtTelefono.Size = new Size(168, 29);
            txtTelefono.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F);
            txtMail.Location = new Point(328, 176);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese su mail";
            txtMail.Size = new Size(168, 29);
            txtMail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(119, 248);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese su dirección";
            txtDireccion.Size = new Size(377, 29);
            txtDireccion.TabIndex = 8;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(119, 335);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(172, 29);
            dtpFechaNac.TabIndex = 10;
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFichaMedica.Location = new Point(315, 333);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(119, 25);
            chkFichaMedica.TabIndex = 10;
            chkFichaMedica.Text = "Ficha Médica";
            chkFichaMedica.UseVisualStyleBackColor = true;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNac.Location = new Point(115, 312);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(152, 21);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha de nacimiento";
            lblFechaNac.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(564, 408);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 43);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(119, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.Location = new Point(328, 82);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.Location = new Point(522, 82);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 15;
            lblDni.Text = "DNI";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(119, 153);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Teléfono";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F);
            lblMail.Location = new Point(328, 153);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(40, 21);
            lblMail.TabIndex = 17;
            lblMail.Text = "Mail";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(119, 225);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 21);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección";
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackColor = Color.FromArgb(128, 255, 255);
            btnCobrarCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCobrarCuota.Location = new Point(675, 312);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(96, 71);
            btnCobrarCuota.TabIndex = 19;
            btnCobrarCuota.Text = "Cobrar cuota";
            btnCobrarCuota.UseVisualStyleBackColor = false;
            btnCobrarCuota.Click += btnCobrarCuota_Click;
            // 
            // frmInscripcionSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(btnCobrarCuota);
            Controls.Add(lblDireccion);
            Controls.Add(lblMail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
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
            Load += frmInscripcionSocio_Load;
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
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblTelefono;
        private Label lblMail;
        private Label lblDireccion;
        private Button btnCobrarCuota;
    }
}