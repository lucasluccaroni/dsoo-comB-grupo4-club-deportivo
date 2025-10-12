namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            btnRegistrarSocio = new Button();
            btnCobrarCuota = new Button();
            btnCobrarActividad = new Button();
            btnRegistrarAsistencia = new Button();
            btnPagarSueldo = new Button();
            btnRegistrarNoSocio = new Button();
            btnEmitirCarnet = new Button();
            btnListadoSocios = new Button();
            btnSalir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblDate = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            SuspendLayout();
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarSocio.Location = new Point(129, 118);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(150, 100);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCobrarCuota.ForeColor = SystemColors.AppWorkspace;
            btnCobrarCuota.Location = new Point(129, 268);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(150, 100);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btnCobrarActividad
            // 
            btnCobrarActividad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCobrarActividad.ForeColor = SystemColors.AppWorkspace;
            btnCobrarActividad.Location = new Point(349, 278);
            btnCobrarActividad.Name = "btnCobrarActividad";
            btnCobrarActividad.Size = new Size(150, 100);
            btnCobrarActividad.TabIndex = 2;
            btnCobrarActividad.Text = "Cobrar Actividad";
            btnCobrarActividad.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAsistencia
            // 
            btnRegistrarAsistencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarAsistencia.ForeColor = SystemColors.AppWorkspace;
            btnRegistrarAsistencia.Location = new Point(129, 425);
            btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            btnRegistrarAsistencia.Size = new Size(150, 100);
            btnRegistrarAsistencia.TabIndex = 3;
            btnRegistrarAsistencia.Text = "Registrar Asistencia (profesor)";
            btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnPagarSueldo
            // 
            btnPagarSueldo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPagarSueldo.ForeColor = SystemColors.AppWorkspace;
            btnPagarSueldo.Location = new Point(349, 425);
            btnPagarSueldo.Name = "btnPagarSueldo";
            btnPagarSueldo.Size = new Size(150, 100);
            btnPagarSueldo.TabIndex = 4;
            btnPagarSueldo.Text = "Pagar sueldo (profesor)";
            btnPagarSueldo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarNoSocio.Location = new Point(349, 118);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(150, 100);
            btnRegistrarNoSocio.TabIndex = 5;
            btnRegistrarNoSocio.Text = "Registrar \r\nNo Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEmitirCarnet.ForeColor = SystemColors.AppWorkspace;
            btnEmitirCarnet.Location = new Point(583, 206);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(150, 100);
            btnEmitirCarnet.TabIndex = 6;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = true;
            // 
            // btnListadoSocios
            // 
            btnListadoSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListadoSocios.ForeColor = SystemColors.AppWorkspace;
            btnListadoSocios.Location = new Point(583, 334);
            btnListadoSocios.Name = "btnListadoSocios";
            btnListadoSocios.Size = new Size(150, 100);
            btnListadoSocios.TabIndex = 7;
            btnListadoSocios.Text = "Listado de Socios";
            btnListadoSocios.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(755, 15);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 45);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Cerrar sesión";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblDate.Location = new Point(12, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 17);
            lblDate.TabIndex = 11;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblUsuario.Location = new Point(12, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(15, 17);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "a";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblRol.Location = new Point(12, 75);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(15, 17);
            lblRol.TabIndex = 9;
            lblRol.Text = "a";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(854, 574);
            Controls.Add(lblDate);
            Controls.Add(btnSalir);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Controls.Add(btnListadoSocios);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnPagarSueldo);
            Controls.Add(btnRegistrarAsistencia);
            Controls.Add(btnCobrarActividad);
            Controls.Add(btnCobrarCuota);
            Controls.Add(btnRegistrarSocio);
            Name = "frmPrincipal";
            Text = "Club deportivo - Home";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarSocio;
        private Button btnCobrarCuota;
        private Button btnCobrarActividad;
        private Button btnRegistrarAsistencia;
        private Button btnPagarSueldo;
        private Button btnRegistrarNoSocio;
        private Button btnEmitirCarnet;
        private Button btnListadoSocios;
        private Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private Label lblDate;
        private Label lblUsuario;
        private Label lblRol;
    }
}