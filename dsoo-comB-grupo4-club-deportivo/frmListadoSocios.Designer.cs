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
            btnReactivarSocio = new Button();
            btnImprimir = new Button();
            rbtActivos = new RadioButton();
            rbtInactivos = new RadioButton();
            rbtVencenHoy = new RadioButton();
            pnlListas = new Panel();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            pnlListas.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 32);
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
            dtgvSocios.Location = new Point(12, 142);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.ReadOnly = true;
            dtgvSocios.RowHeadersWidth = 51;
            dtgvSocios.Size = new Size(1257, 333);
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
            FechaInscripcionSocio.Width = 146;
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
            lblListadoSocios.Location = new Point(410, 53);
            lblListadoSocios.Name = "lblListadoSocios";
            lblListadoSocios.Size = new Size(299, 47);
            lblListadoSocios.TabIndex = 3;
            lblListadoSocios.Text = "Listado de socios";
            // 
            // btnInactivarSocio
            // 
            btnInactivarSocio.BackColor = Color.FromArgb(255, 128, 128);
            btnInactivarSocio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInactivarSocio.Font = new Font("Segoe UI", 11.25F);
            btnInactivarSocio.Location = new Point(1017, 497);
            btnInactivarSocio.Name = "btnInactivarSocio";
            btnInactivarSocio.Size = new Size(108, 52);
            btnInactivarSocio.TabIndex = 5;
            btnInactivarSocio.Text = "Inactivar";
            btnInactivarSocio.UseVisualStyleBackColor = false;
            btnInactivarSocio.Click += btnInactivarSocio_Click;
            // 
            // btnReactivarSocio
            // 
            btnReactivarSocio.BackColor = Color.FromArgb(192, 255, 192);
            btnReactivarSocio.Enabled = false;
            btnReactivarSocio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReactivarSocio.Location = new Point(904, 497);
            btnReactivarSocio.Margin = new Padding(3, 2, 3, 2);
            btnReactivarSocio.Name = "btnReactivarSocio";
            btnReactivarSocio.Size = new Size(108, 52);
            btnReactivarSocio.TabIndex = 7;
            btnReactivarSocio.Text = "Reactivar";
            btnReactivarSocio.UseVisualStyleBackColor = false;
            btnReactivarSocio.Click += btnReactivarSocio_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Enabled = false;
            btnImprimir.Location = new Point(270, 529);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(126, 33);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // rbtActivos
            // 
            rbtActivos.AutoSize = true;
            rbtActivos.Location = new Point(22, 5);
            rbtActivos.Margin = new Padding(3, 2, 3, 2);
            rbtActivos.Name = "rbtActivos";
            rbtActivos.Size = new Size(101, 19);
            rbtActivos.TabIndex = 10;
            rbtActivos.TabStop = true;
            rbtActivos.Text = "Socios Activos";
            rbtActivos.UseVisualStyleBackColor = true;
            // 
            // rbtInactivos
            // 
            rbtInactivos.AutoSize = true;
            rbtInactivos.Location = new Point(22, 28);
            rbtInactivos.Margin = new Padding(3, 2, 3, 2);
            rbtInactivos.Name = "rbtInactivos";
            rbtInactivos.Size = new Size(109, 19);
            rbtInactivos.TabIndex = 11;
            rbtInactivos.TabStop = true;
            rbtInactivos.Text = "Socios Inactivos";
            rbtInactivos.UseVisualStyleBackColor = true;
            // 
            // rbtVencenHoy
            // 
            rbtVencenHoy.AutoSize = true;
            rbtVencenHoy.Location = new Point(22, 50);
            rbtVencenHoy.Margin = new Padding(3, 2, 3, 2);
            rbtVencenHoy.Name = "rbtVencenHoy";
            rbtVencenHoy.Size = new Size(146, 19);
            rbtVencenHoy.TabIndex = 12;
            rbtVencenHoy.TabStop = true;
            rbtVencenHoy.Text = "Socios que vencen hoy";
            rbtVencenHoy.UseVisualStyleBackColor = true;
            // 
            // pnlListas
            // 
            pnlListas.BorderStyle = BorderStyle.FixedSingle;
            pnlListas.Controls.Add(rbtInactivos);
            pnlListas.Controls.Add(rbtVencenHoy);
            pnlListas.Controls.Add(rbtActivos);
            pnlListas.Location = new Point(24, 488);
            pnlListas.Margin = new Padding(3, 2, 3, 2);
            pnlListas.Name = "pnlListas";
            pnlListas.Size = new Size(242, 71);
            pnlListas.TabIndex = 13;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(270, 488);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(126, 37);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // frmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 570);
            Controls.Add(btnMostrar);
            Controls.Add(pnlListas);
            Controls.Add(btnImprimir);
            Controls.Add(btnReactivarSocio);
            Controls.Add(btnInactivarSocio);
            Controls.Add(lblListadoSocios);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Name = "frmListadoSocios";
            Text = "Listado -> Socios";
            Load += frmListadoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            pnlListas.ResumeLayout(false);
            pnlListas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvSocios;
        private Label lblListadoSocios;
        private Button btnInactivarSocio;
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
        private Button btnImprimir;
        private RadioButton rbtActivos;
        private RadioButton rbtInactivos;
        private RadioButton rbtVencenHoy;
        private Panel pnlListas;
        private Button btnMostrar;
    }
}