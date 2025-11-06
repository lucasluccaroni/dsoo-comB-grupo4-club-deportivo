namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmListadoSocios
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
            dtgvSocios = new DataGridView();
            idSocio = new DataGridViewTextBoxColumn();
            NombreSocio = new DataGridViewTextBoxColumn();
            ApellidoSocio = new DataGridViewTextBoxColumn();
            EmailSocio = new DataGridViewTextBoxColumn();
            DniSocio = new DataGridViewTextBoxColumn();
            DireccionSocio = new DataGridViewTextBoxColumn();
            FechaNacSocio = new DataGridViewTextBoxColumn();
            TelefonoSocio = new DataGridViewTextBoxColumn();
            FichaMedSocio = new DataGridViewTextBoxColumn();
            FechaInscripcionSocio = new DataGridViewTextBoxColumn();
            FechaVencimientoSocio = new DataGridViewTextBoxColumn();
            ActivoSocio = new DataGridViewTextBoxColumn();
            lblListadoSocios = new Label();
            btnInactivarSocio = new Button();
            chkMostrarInactivos = new CheckBox();
            btnReactivarSocio = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(14, 16);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 43);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvSocios
            // 
            dtgvSocios.AllowUserToAddRows = false;
            dtgvSocios.AllowUserToDeleteRows = false;
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Columns.AddRange(new DataGridViewColumn[] { idSocio, NombreSocio, ApellidoSocio, EmailSocio, DniSocio, DireccionSocio, FechaNacSocio, TelefonoSocio, FichaMedSocio, FechaInscripcionSocio, FechaVencimientoSocio, ActivoSocio });
            dtgvSocios.Location = new Point(14, 189);
            dtgvSocios.Margin = new Padding(3, 4, 3, 4);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.ReadOnly = true;
            dtgvSocios.RowHeadersWidth = 51;
            dtgvSocios.Size = new Size(1437, 444);
            dtgvSocios.TabIndex = 2;
            dtgvSocios.CellClick += dtgvSocios_CellClick;
            // 
            // idSocio
            // 
            idSocio.HeaderText = "ID-SOCIO";
            idSocio.MinimumWidth = 6;
            idSocio.Name = "idSocio";
            idSocio.ReadOnly = true;
            idSocio.Width = 125;
            // 
            // NombreSocio
            // 
            NombreSocio.HeaderText = "NOMBRE";
            NombreSocio.MinimumWidth = 6;
            NombreSocio.Name = "NombreSocio";
            NombreSocio.ReadOnly = true;
            NombreSocio.Width = 125;
            // 
            // ApellidoSocio
            // 
            ApellidoSocio.HeaderText = "APELLIDO";
            ApellidoSocio.MinimumWidth = 6;
            ApellidoSocio.Name = "ApellidoSocio";
            ApellidoSocio.ReadOnly = true;
            ApellidoSocio.Width = 125;
            // 
            // EmailSocio
            // 
            EmailSocio.HeaderText = "EMAIL";
            EmailSocio.MinimumWidth = 6;
            EmailSocio.Name = "EmailSocio";
            EmailSocio.ReadOnly = true;
            EmailSocio.Width = 125;
            // 
            // DniSocio
            // 
            DniSocio.HeaderText = "DNI";
            DniSocio.MinimumWidth = 6;
            DniSocio.Name = "DniSocio";
            DniSocio.ReadOnly = true;
            DniSocio.Width = 125;
            // 
            // DireccionSocio
            // 
            DireccionSocio.HeaderText = "DIRECCION";
            DireccionSocio.MinimumWidth = 6;
            DireccionSocio.Name = "DireccionSocio";
            DireccionSocio.ReadOnly = true;
            DireccionSocio.Width = 125;
            // 
            // FechaNacSocio
            // 
            FechaNacSocio.HeaderText = "FECHA-NAC";
            FechaNacSocio.MinimumWidth = 6;
            FechaNacSocio.Name = "FechaNacSocio";
            FechaNacSocio.ReadOnly = true;
            FechaNacSocio.Width = 125;
            // 
            // TelefonoSocio
            // 
            TelefonoSocio.HeaderText = "TELEFONO";
            TelefonoSocio.MinimumWidth = 6;
            TelefonoSocio.Name = "TelefonoSocio";
            TelefonoSocio.ReadOnly = true;
            TelefonoSocio.Width = 125;
            // 
            // FichaMedSocio
            // 
            FichaMedSocio.HeaderText = "FICHA-MED";
            FichaMedSocio.MinimumWidth = 6;
            FichaMedSocio.Name = "FichaMedSocio";
            FichaMedSocio.ReadOnly = true;
            FichaMedSocio.Width = 125;
            // 
            // FechaInscripcionSocio
            // 
            FechaInscripcionSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FechaInscripcionSocio.HeaderText = "FECHA-INSCRIPCION";
            FechaInscripcionSocio.MinimumWidth = 6;
            FechaInscripcionSocio.Name = "FechaInscripcionSocio";
            FechaInscripcionSocio.ReadOnly = true;
            FechaInscripcionSocio.Width = 177;
            // 
            // FechaVencimientoSocio
            // 
            FechaVencimientoSocio.HeaderText = "FECHA-VENCIMIENTO";
            FechaVencimientoSocio.MinimumWidth = 6;
            FechaVencimientoSocio.Name = "FechaVencimientoSocio";
            FechaVencimientoSocio.ReadOnly = true;
            FechaVencimientoSocio.Width = 125;
            // 
            // ActivoSocio
            // 
            ActivoSocio.HeaderText = "ACTIVO";
            ActivoSocio.MinimumWidth = 6;
            ActivoSocio.Name = "ActivoSocio";
            ActivoSocio.ReadOnly = true;
            ActivoSocio.Width = 125;
            // 
            // lblListadoSocios
            // 
            lblListadoSocios.AutoSize = true;
            lblListadoSocios.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblListadoSocios.Location = new Point(469, 71);
            lblListadoSocios.Name = "lblListadoSocios";
            lblListadoSocios.Size = new Size(376, 60);
            lblListadoSocios.TabIndex = 3;
            lblListadoSocios.Text = "Listado de socios";
            // 
            // btnInactivarSocio
            // 
            btnInactivarSocio.BackColor = Color.FromArgb(255, 128, 128);
            btnInactivarSocio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInactivarSocio.Font = new Font("Segoe UI", 11.25F);
            btnInactivarSocio.Location = new Point(1163, 660);
            btnInactivarSocio.Margin = new Padding(3, 4, 3, 4);
            btnInactivarSocio.Name = "btnInactivarSocio";
            btnInactivarSocio.Size = new Size(123, 70);
            btnInactivarSocio.TabIndex = 5;
            btnInactivarSocio.Text = "Inactivar Socio";
            btnInactivarSocio.UseVisualStyleBackColor = false;
            btnInactivarSocio.Click += btnInactivarSocio_Click;
            // 
            // chkMostrarInactivos
            // 
            chkMostrarInactivos.AutoSize = true;
            chkMostrarInactivos.Location = new Point(71, 686);
            chkMostrarInactivos.Name = "chkMostrarInactivos";
            chkMostrarInactivos.Size = new Size(144, 24);
            chkMostrarInactivos.TabIndex = 6;
            chkMostrarInactivos.Text = "Mostrar Inactivos";
            chkMostrarInactivos.UseVisualStyleBackColor = true;
            chkMostrarInactivos.CheckedChanged += chkMostrarInactivos_CheckedChanged;
            // 
            // btnReactivarSocio
            // 
            btnReactivarSocio.BackColor = Color.FromArgb(192, 255, 192);
            btnReactivarSocio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReactivarSocio.Location = new Point(1033, 663);
            btnReactivarSocio.Name = "btnReactivarSocio";
            btnReactivarSocio.Size = new Size(104, 67);
            btnReactivarSocio.TabIndex = 7;
            btnReactivarSocio.Text = "Reactivar Socio";
            btnReactivarSocio.UseVisualStyleBackColor = false;
            btnReactivarSocio.Enabled = false;
            btnReactivarSocio.Click += btnReactivarSocio_Click;
            // 
            // frmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 760);
            Controls.Add(btnReactivarSocio);
            Controls.Add(chkMostrarInactivos);
            Controls.Add(btnInactivarSocio);
            Controls.Add(lblListadoSocios);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListadoSocios";
            Text = "Listado -> Socios";
            Load += frmListadoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvSocios;
        private Label lblListadoSocios;
        private Button btnInactivarSocio;
        private CheckBox chkMostrarInactivos;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn NombreSocio;
        private DataGridViewTextBoxColumn ApellidoSocio;
        private DataGridViewTextBoxColumn EmailSocio;
        private DataGridViewTextBoxColumn DniSocio;
        private DataGridViewTextBoxColumn DireccionSocio;
        private DataGridViewTextBoxColumn FechaNacSocio;
        private DataGridViewTextBoxColumn TelefonoSocio;
        private DataGridViewTextBoxColumn FichaMedSocio;
        private DataGridViewTextBoxColumn FechaInscripcionSocio;
        private DataGridViewTextBoxColumn FechaVencimientoSocio;
        private DataGridViewTextBoxColumn ActivoSocio;
        private Button btnReactivarSocio;
    }
}