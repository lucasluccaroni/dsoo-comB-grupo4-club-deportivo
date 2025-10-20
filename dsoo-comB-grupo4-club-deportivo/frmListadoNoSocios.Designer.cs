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
            dtgvNoSocios.Columns.AddRange(new DataGridViewColumn[] { IdNoSocio, NombreNoSocio, ApellidoNoSocio, EmailNoSocio, DniNoSocio, DireccionNoSocio, FechaNacNoSocio, TelefonoNoSocio, FichaMedNoSocio });
            dtgvNoSocios.Location = new Point(110, 143);
            dtgvNoSocios.Name = "dtgvNoSocios";
            dtgvNoSocios.ReadOnly = true;
            dtgvNoSocios.Size = new Size(945, 333);
            dtgvNoSocios.TabIndex = 5;
            // 
            // IdNoSocio
            // 
            IdNoSocio.HeaderText = "ID-NO.SOCIO";
            IdNoSocio.Name = "IdNoSocio";
            IdNoSocio.ReadOnly = true;
            // 
            // NombreNoSocio
            // 
            NombreNoSocio.HeaderText = "NOMBRE";
            NombreNoSocio.Name = "NombreNoSocio";
            NombreNoSocio.ReadOnly = true;
            // 
            // ApellidoNoSocio
            // 
            ApellidoNoSocio.HeaderText = "APELLIDO";
            ApellidoNoSocio.Name = "ApellidoNoSocio";
            ApellidoNoSocio.ReadOnly = true;
            // 
            // EmailNoSocio
            // 
            EmailNoSocio.HeaderText = "EMAIL";
            EmailNoSocio.Name = "EmailNoSocio";
            EmailNoSocio.ReadOnly = true;
            // 
            // DniNoSocio
            // 
            DniNoSocio.HeaderText = "DNI";
            DniNoSocio.Name = "DniNoSocio";
            DniNoSocio.ReadOnly = true;
            // 
            // DireccionNoSocio
            // 
            DireccionNoSocio.HeaderText = "DIRECCION";
            DireccionNoSocio.Name = "DireccionNoSocio";
            DireccionNoSocio.ReadOnly = true;
            // 
            // FechaNacNoSocio
            // 
            FechaNacNoSocio.HeaderText = "FECHA NAC";
            FechaNacNoSocio.Name = "FechaNacNoSocio";
            FechaNacNoSocio.ReadOnly = true;
            // 
            // TelefonoNoSocio
            // 
            TelefonoNoSocio.HeaderText = "TELEFONO";
            TelefonoNoSocio.Name = "TelefonoNoSocio";
            TelefonoNoSocio.ReadOnly = true;
            // 
            // FichaMedNoSocio
            // 
            FichaMedNoSocio.HeaderText = "FICHA-MED";
            FichaMedNoSocio.Name = "FichaMedNoSocio";
            FichaMedNoSocio.ReadOnly = true;
            // 
            // frmListadoNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 570);
            Controls.Add(dtgvNoSocios);
            Controls.Add(lblListadoNoSocios);
            Controls.Add(btnVolver);
            Name = "frmListadoNoSocios";
            Text = "frmListadoNoSocios";
            Load += frmListadoNoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblListadoNoSocios;
        private DataGridView dtgvNoSocios;
        private DataGridViewTextBoxColumn IdNoSocio;
        private DataGridViewTextBoxColumn NombreNoSocio;
        private DataGridViewTextBoxColumn ApellidoNoSocio;
        private DataGridViewTextBoxColumn EmailNoSocio;
        private DataGridViewTextBoxColumn DniNoSocio;
        private DataGridViewTextBoxColumn DireccionNoSocio;
        private DataGridViewTextBoxColumn FechaNacNoSocio;
        private DataGridViewTextBoxColumn TelefonoNoSocio;
        private DataGridViewTextBoxColumn FichaMedNoSocio;
    }
}