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
            lblListadoSocios = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
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
            dtgvSocios.Columns.AddRange(new DataGridViewColumn[] { idSocio, NombreSocio, ApellidoSocio, EmailSocio, DniSocio, DireccionSocio, FechaNacSocio, TelefonoSocio, FichaMedSocio, FechaInscripcionSocio });
            dtgvSocios.Location = new Point(71, 147);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.ReadOnly = true;
            dtgvSocios.Size = new Size(1089, 333);
            dtgvSocios.TabIndex = 2;
            // 
            // idSocio
            // 
            idSocio.HeaderText = "ID-SOCIO";
            idSocio.Name = "idSocio";
            idSocio.ReadOnly = true;
            // 
            // NombreSocio
            // 
            NombreSocio.HeaderText = "NOMBRE";
            NombreSocio.Name = "NombreSocio";
            NombreSocio.ReadOnly = true;
            // 
            // ApellidoSocio
            // 
            ApellidoSocio.HeaderText = "APELLIDO";
            ApellidoSocio.Name = "ApellidoSocio";
            ApellidoSocio.ReadOnly = true;
            // 
            // EmailSocio
            // 
            EmailSocio.HeaderText = "EMAIL";
            EmailSocio.Name = "EmailSocio";
            EmailSocio.ReadOnly = true;
            // 
            // DniSocio
            // 
            DniSocio.HeaderText = "DNI";
            DniSocio.Name = "DniSocio";
            DniSocio.ReadOnly = true;
            // 
            // DireccionSocio
            // 
            DireccionSocio.HeaderText = "DIRECCION";
            DireccionSocio.Name = "DireccionSocio";
            DireccionSocio.ReadOnly = true;
            // 
            // FechaNacSocio
            // 
            FechaNacSocio.HeaderText = "FECHA-NAC";
            FechaNacSocio.Name = "FechaNacSocio";
            FechaNacSocio.ReadOnly = true;
            // 
            // TelefonoSocio
            // 
            TelefonoSocio.HeaderText = "TELEFONO";
            TelefonoSocio.Name = "TelefonoSocio";
            TelefonoSocio.ReadOnly = true;
            // 
            // FichaMedSocio
            // 
            FichaMedSocio.HeaderText = "FICHA-MED";
            FichaMedSocio.Name = "FichaMedSocio";
            FichaMedSocio.ReadOnly = true;
            // 
            // FechaInscripcionSocio
            // 
            FechaInscripcionSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FechaInscripcionSocio.HeaderText = "FECHA-INSCRIPCION";
            FechaInscripcionSocio.Name = "FechaInscripcionSocio";
            FechaInscripcionSocio.ReadOnly = true;
            FechaInscripcionSocio.Width = 146;
            // 
            // lblListadoSocios
            // 
            lblListadoSocios.AutoSize = true;
            lblListadoSocios.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblListadoSocios.Location = new Point(459, 44);
            lblListadoSocios.Name = "lblListadoSocios";
            lblListadoSocios.Size = new Size(299, 47);
            lblListadoSocios.TabIndex = 3;
            lblListadoSocios.Text = "Listado de socios";
            // 
            // frmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 610);
            Controls.Add(lblListadoSocios);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Name = "frmListadoSocios";
            Text = "frmListadoSocios";
            Load += frmListadoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvSocios;
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
        private Label lblListadoSocios;
    }
}