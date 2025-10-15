namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmInscripcionNoSocio
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
            lblDireccion = new Label();
            lblMail = new Label();
            lblTelefono = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnLimpiar = new Button();
            lblFechaNac = new Label();
            chkFichaMedica = new CheckBox();
            dtpFechaNac = new DateTimePicker();
            txtDireccion = new TextBox();
            txtMail = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblTituloInscripcion = new Label();
            btnIngresar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(128, 219);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 21);
            lblDireccion.TabIndex = 37;
            lblDireccion.Text = "Dirección";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F);
            lblMail.Location = new Point(337, 147);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(40, 21);
            lblMail.TabIndex = 36;
            lblMail.Text = "Mail";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(128, 147);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 35;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.Location = new Point(531, 76);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 34;
            lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.Location = new Point(337, 76);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 33;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(128, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 32;
            lblNombre.Text = "Nombre";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(573, 402);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 43);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNac.Location = new Point(124, 306);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(152, 21);
            lblFechaNac.TabIndex = 30;
            lblFechaNac.Text = "Fecha de nacimiento";
            lblFechaNac.TextAlign = ContentAlignment.TopCenter;
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFichaMedica.Location = new Point(324, 327);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(119, 25);
            chkFichaMedica.TabIndex = 29;
            chkFichaMedica.Text = "Ficha Médica";
            chkFichaMedica.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(128, 329);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(172, 29);
            dtpFechaNac.TabIndex = 28;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(128, 242);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese su dirección";
            txtDireccion.Size = new Size(377, 29);
            txtDireccion.TabIndex = 27;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F);
            txtMail.Location = new Point(337, 170);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese su mail";
            txtMail.Size = new Size(168, 29);
            txtMail.TabIndex = 26;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(128, 170);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese su teléfono";
            txtTelefono.Size = new Size(168, 29);
            txtTelefono.TabIndex = 25;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 12F);
            txtDni.Location = new Point(531, 99);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su DNI";
            txtDni.Size = new Size(168, 29);
            txtDni.TabIndex = 24;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(337, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese su apellido";
            txtApellido.Size = new Size(168, 29);
            txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(128, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su nombre";
            txtNombre.Size = new Size(168, 29);
            txtNombre.TabIndex = 22;
            // 
            // lblTituloInscripcion
            // 
            lblTituloInscripcion.AutoSize = true;
            lblTituloInscripcion.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTituloInscripcion.Location = new Point(263, 6);
            lblTituloInscripcion.Name = "lblTituloInscripcion";
            lblTituloInscripcion.Size = new Size(306, 32);
            lblTituloInscripcion.TabIndex = 21;
            lblTituloInscripcion.Text = "Registrar nuevo NO socio";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.PaleGreen;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Font = new Font("Segoe UI", 12F);
            btnIngresar.Location = new Point(684, 402);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 43);
            btnIngresar.TabIndex = 20;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(21, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 32);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmInscripcionNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmInscripcionNoSocio";
            Text = "frmInscripcionNoSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDireccion;
        private Label lblMail;
        private Label lblTelefono;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnLimpiar;
        private Label lblFechaNac;
        private CheckBox chkFichaMedica;
        private DateTimePicker dtpFechaNac;
        private TextBox txtDireccion;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblTituloInscripcion;
        private Button btnIngresar;
        private Button btnVolver;
    }
}