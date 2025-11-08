namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmListadoNoSocios
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
            lblListadoNoSocios = new Label();
            dtgvNoSocios = new DataGridView();
            IdNoSocio = new DataGridViewTextBoxColumn();
            NombreNoSocio = new DataGridViewTextBoxColumn();
            ApellidoNoSocio = new DataGridViewTextBoxColumn();
            EmailNoSocio = new DataGridViewTextBoxColumn();
            DniNoSocio = new DataGridViewTextBoxColumn();
            DireccionNoSocio = new DataGridViewTextBoxColumn();
            FechaNacNoSocio = new DataGridViewTextBoxColumn();
            TelefonoNoSocio = new DataGridViewTextBoxColumn();
            FichaMedNoSocio = new DataGridViewTextBoxColumn();
            ActivoNoSocio = new DataGridViewTextBoxColumn();
            btnInactivarNoSocio = new Button();
            chkMostrarInactivos = new CheckBox();
            btnReactivarNoSocio = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).BeginInit();
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
            // lblListadoNoSocios
            // 
            lblListadoNoSocios.AutoSize = true;
            lblListadoNoSocios.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblListadoNoSocios.Location = new Point(385, 46);
            lblListadoNoSocios.Name = "lblListadoNoSocios";
            lblListadoNoSocios.Size = new Size(364, 47);
            lblListadoNoSocios.TabIndex = 4;
            lblListadoNoSocios.Text = "Listado de NO socios";
            // 
            // dtgvNoSocios
            // 
            dtgvNoSocios.AllowUserToAddRows = false;
            dtgvNoSocios.AllowUserToDeleteRows = false;
            dtgvNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNoSocios.Columns.AddRange(new DataGridViewColumn[] { IdNoSocio, NombreNoSocio, ApellidoNoSocio, EmailNoSocio, DniNoSocio, DireccionNoSocio, FechaNacNoSocio, TelefonoNoSocio, FichaMedNoSocio, ActivoNoSocio });
            dtgvNoSocios.Location = new Point(32, 143);
            dtgvNoSocios.Name = "dtgvNoSocios";
            dtgvNoSocios.ReadOnly = true;
            dtgvNoSocios.RowHeadersWidth = 51;
            dtgvNoSocios.Size = new Size(1150, 333);
            dtgvNoSocios.TabIndex = 5;
            dtgvNoSocios.CellClick += dtgvNoSocios_CellClick;
            // 
            // IdNoSocio
            // 
            IdNoSocio.HeaderText = "ID-NO.SOCIO";
            IdNoSocio.MinimumWidth = 6;
            IdNoSocio.Name = "IdNoSocio";
            IdNoSocio.ReadOnly = true;
            IdNoSocio.Width = 125;
            // 
            // NombreNoSocio
            // 
            NombreNoSocio.HeaderText = "NOMBRE";
            NombreNoSocio.MinimumWidth = 6;
            NombreNoSocio.Name = "NombreNoSocio";
            NombreNoSocio.ReadOnly = true;
            NombreNoSocio.Width = 125;
            // 
            // ApellidoNoSocio
            // 
            ApellidoNoSocio.HeaderText = "APELLIDO";
            ApellidoNoSocio.MinimumWidth = 6;
            ApellidoNoSocio.Name = "ApellidoNoSocio";
            ApellidoNoSocio.ReadOnly = true;
            ApellidoNoSocio.Width = 125;
            // 
            // EmailNoSocio
            // 
            EmailNoSocio.HeaderText = "EMAIL";
            EmailNoSocio.MinimumWidth = 6;
            EmailNoSocio.Name = "EmailNoSocio";
            EmailNoSocio.ReadOnly = true;
            EmailNoSocio.Width = 125;
            // 
            // DniNoSocio
            // 
            DniNoSocio.HeaderText = "DNI";
            DniNoSocio.MinimumWidth = 6;
            DniNoSocio.Name = "DniNoSocio";
            DniNoSocio.ReadOnly = true;
            DniNoSocio.Width = 125;
            // 
            // DireccionNoSocio
            // 
            DireccionNoSocio.HeaderText = "DIRECCION";
            DireccionNoSocio.MinimumWidth = 6;
            DireccionNoSocio.Name = "DireccionNoSocio";
            DireccionNoSocio.ReadOnly = true;
            DireccionNoSocio.Width = 125;
            // 
            // FechaNacNoSocio
            // 
            FechaNacNoSocio.HeaderText = "FECHA NAC";
            FechaNacNoSocio.MinimumWidth = 6;
            FechaNacNoSocio.Name = "FechaNacNoSocio";
            FechaNacNoSocio.ReadOnly = true;
            FechaNacNoSocio.Width = 125;
            // 
            // TelefonoNoSocio
            // 
            TelefonoNoSocio.HeaderText = "TELEFONO";
            TelefonoNoSocio.MinimumWidth = 6;
            TelefonoNoSocio.Name = "TelefonoNoSocio";
            TelefonoNoSocio.ReadOnly = true;
            TelefonoNoSocio.Width = 125;
            // 
            // FichaMedNoSocio
            // 
            FichaMedNoSocio.HeaderText = "FICHA-MED";
            FichaMedNoSocio.MinimumWidth = 6;
            FichaMedNoSocio.Name = "FichaMedNoSocio";
            FichaMedNoSocio.ReadOnly = true;
            FichaMedNoSocio.Width = 125;
            // 
            // ActivoNoSocio
            // 
            ActivoNoSocio.HeaderText = "ACTIVO";
            ActivoNoSocio.MinimumWidth = 6;
            ActivoNoSocio.Name = "ActivoNoSocio";
            ActivoNoSocio.ReadOnly = true;
            ActivoNoSocio.Width = 125;
            // 
            // btnInactivarNoSocio
            // 
            btnInactivarNoSocio.BackColor = Color.FromArgb(255, 128, 128);
            btnInactivarNoSocio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInactivarNoSocio.Font = new Font("Segoe UI", 11.25F);
            btnInactivarNoSocio.Location = new Point(990, 500);
            btnInactivarNoSocio.Name = "btnInactivarNoSocio";
            btnInactivarNoSocio.Size = new Size(140, 51);
            btnInactivarNoSocio.TabIndex = 7;
            btnInactivarNoSocio.Text = "Inactivar";
            btnInactivarNoSocio.UseVisualStyleBackColor = false;
            btnInactivarNoSocio.Click += btnInactivarNoSocio_Click;
            // 
            // chkMostrarInactivos
            // 
            chkMostrarInactivos.AutoSize = true;
            chkMostrarInactivos.Location = new Point(32, 500);
            chkMostrarInactivos.Margin = new Padding(3, 2, 3, 2);
            chkMostrarInactivos.Name = "chkMostrarInactivos";
            chkMostrarInactivos.Size = new Size(117, 19);
            chkMostrarInactivos.TabIndex = 8;
            chkMostrarInactivos.Text = "Mostrar Inactivos";
            chkMostrarInactivos.UseVisualStyleBackColor = true;
            chkMostrarInactivos.CheckedChanged += chkMostrarInactivos_CheckedChanged;
            // 
            // btnReactivarNoSocio
            // 
            btnReactivarNoSocio.BackColor = Color.FromArgb(192, 255, 192);
            btnReactivarNoSocio.Enabled = false;
            btnReactivarNoSocio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReactivarNoSocio.Location = new Point(844, 502);
            btnReactivarNoSocio.Margin = new Padding(3, 2, 3, 2);
            btnReactivarNoSocio.Name = "btnReactivarNoSocio";
            btnReactivarNoSocio.Size = new Size(140, 51);
            btnReactivarNoSocio.TabIndex = 9;
            btnReactivarNoSocio.Text = "Reactivar";
            btnReactivarNoSocio.UseVisualStyleBackColor = false;
            btnReactivarNoSocio.Click += btnReactivarSocio_Click;
            // 
            // frmListadoNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 570);
            Controls.Add(btnReactivarNoSocio);
            Controls.Add(chkMostrarInactivos);
            Controls.Add(btnInactivarNoSocio);
            Controls.Add(dtgvNoSocios);
            Controls.Add(lblListadoNoSocios);
            Controls.Add(btnVolver);
            Name = "frmListadoNoSocios";
            Text = "Listado -> No Socios";
            Load += frmListadoNoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblListadoNoSocios;
        private DataGridView dtgvNoSocios;
        private Button btnInactivarNoSocio;
        private DataGridViewTextBoxColumn IdNoSocio;
        private DataGridViewTextBoxColumn NombreNoSocio;
        private DataGridViewTextBoxColumn ApellidoNoSocio;
        private DataGridViewTextBoxColumn EmailNoSocio;
        private DataGridViewTextBoxColumn DniNoSocio;
        private DataGridViewTextBoxColumn DireccionNoSocio;
        private DataGridViewTextBoxColumn FechaNacNoSocio;
        private DataGridViewTextBoxColumn TelefonoNoSocio;
        private DataGridViewTextBoxColumn FichaMedNoSocio;
        private DataGridViewTextBoxColumn ActivoNoSocio;
        private CheckBox chkMostrarInactivos;
        private Button btnReactivarNoSocio;
    }
}