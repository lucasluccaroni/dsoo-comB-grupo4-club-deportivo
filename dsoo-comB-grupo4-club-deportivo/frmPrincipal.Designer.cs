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
            btnCobrarCuota = new Button();
            btnCobrarActividad = new Button();
            btnRegistrarAsistencia = new Button();
            btnPagarSueldo = new Button();
            btnListadoSocios = new Button();
            btnSalir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblDate = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            lblSocio = new Label();
            btnRegistrarSocio = new Button();
            btnEmitirCarnet = new Button();
            btnRegistrarNoSocio = new Button();
            pnlDivisor = new Panel();
            btnListarSocios = new Button();
            btnListarNoSocios = new Button();
            panel1 = new Panel();
            pnlSocios = new Panel();
            panel2 = new Panel();
            lblFacturacion = new Label();
            panel3 = new Panel();
            lblProfesores = new Label();
            pnlSocios.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCobrarCuota.ForeColor = SystemColors.AppWorkspace;
            btnCobrarCuota.Location = new Point(25, 23);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(133, 70);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btnCobrarActividad
            // 
            btnCobrarActividad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCobrarActividad.ForeColor = SystemColors.AppWorkspace;
            btnCobrarActividad.Location = new Point(239, 23);
            btnCobrarActividad.Name = "btnCobrarActividad";
            btnCobrarActividad.Size = new Size(133, 70);
            btnCobrarActividad.TabIndex = 2;
            btnCobrarActividad.Text = "Cobrar Actividad";
            btnCobrarActividad.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAsistencia
            // 
            btnRegistrarAsistencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarAsistencia.ForeColor = SystemColors.AppWorkspace;
            btnRegistrarAsistencia.Location = new Point(40, 23);
            btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            btnRegistrarAsistencia.Size = new Size(133, 70);
            btnRegistrarAsistencia.TabIndex = 3;
            btnRegistrarAsistencia.Text = "Registrar Asistencia (profesor)";
            btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnPagarSueldo
            // 
            btnPagarSueldo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPagarSueldo.ForeColor = SystemColors.AppWorkspace;
            btnPagarSueldo.Location = new Point(232, 11);
            btnPagarSueldo.Name = "btnPagarSueldo";
            btnPagarSueldo.Size = new Size(122, 95);
            btnPagarSueldo.TabIndex = 4;
            btnPagarSueldo.Text = "Pagar sueldo (profesor)";
            btnPagarSueldo.UseVisualStyleBackColor = true;
            // 
            // btnListadoSocios
            // 
            btnListadoSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListadoSocios.ForeColor = SystemColors.AppWorkspace;
            btnListadoSocios.Location = new Point(462, 11);
            btnListadoSocios.Name = "btnListadoSocios";
            btnListadoSocios.Size = new Size(122, 95);
            btnListadoSocios.TabIndex = 7;
            btnListadoSocios.Text = "Listado de Socios a vencer";
            btnListadoSocios.UseVisualStyleBackColor = true;
            
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 192);
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1062, 9);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 50);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Cerrar sesión";
            btnSalir.UseVisualStyleBackColor = false;
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
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(36, 157);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(255, 37);
            lblSocio.TabIndex = 6;
            lblSocio.Text = "Socios y No Socios";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnRegistrarSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarSocio.Location = new Point(32, 32);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(133, 70);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEmitirCarnet.ForeColor = SystemColors.AppWorkspace;
            btnEmitirCarnet.Location = new Point(916, 32);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(133, 70);
            btnEmitirCarnet.TabIndex = 6;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarNoSocio.ForeColor = SystemColors.ControlText;
            btnRegistrarNoSocio.Location = new Point(479, 32);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(133, 70);
            btnRegistrarNoSocio.TabIndex = 5;
            btnRegistrarNoSocio.Text = "Registrar \r\nNo Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // pnlDivisor
            // 
            pnlDivisor.BackColor = Color.Gainsboro;
            pnlDivisor.ForeColor = SystemColors.ActiveCaptionText;
            pnlDivisor.Location = new Point(432, 3);
            pnlDivisor.Name = "pnlDivisor";
            pnlDivisor.Size = new Size(2, 257);
            pnlDivisor.TabIndex = 13;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.FromArgb(255, 224, 192);
            btnListarSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListarSocios.Location = new Point(246, 32);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(133, 70);
            btnListarSocios.TabIndex = 14;
            btnListarSocios.Text = "Listar Socios";
            btnListarSocios.UseVisualStyleBackColor = false;
            btnListarSocios.Click += btnListarSocios_Click;
            // 
            // btnListarNoSocios
            // 
            btnListarNoSocios.BackColor = Color.FromArgb(255, 224, 192);
            btnListarNoSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListarNoSocios.Location = new Point(686, 32);
            btnListarNoSocios.Name = "btnListarNoSocios";
            btnListarNoSocios.Size = new Size(133, 70);
            btnListarNoSocios.TabIndex = 15;
            btnListarNoSocios.Text = "Listar No Socios";
            btnListarNoSocios.UseVisualStyleBackColor = false;
            btnListarNoSocios.Click += btnListarNoSocios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(888, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 257);
            panel1.TabIndex = 16;
            // 
            // pnlSocios
            // 
            pnlSocios.BackColor = Color.FromArgb(224, 224, 224);
            pnlSocios.Controls.Add(panel1);
            pnlSocios.Controls.Add(btnListarNoSocios);
            pnlSocios.Controls.Add(btnListarSocios);
            pnlSocios.Controls.Add(pnlDivisor);
            pnlSocios.Controls.Add(btnRegistrarNoSocio);
            pnlSocios.Controls.Add(btnEmitirCarnet);
            pnlSocios.Controls.Add(btnRegistrarSocio);
            pnlSocios.Location = new Point(36, 200);
            pnlSocios.Name = "pnlSocios";
            pnlSocios.Size = new Size(1076, 125);
            pnlSocios.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnCobrarCuota);
            panel2.Controls.Add(btnCobrarActividad);
            panel2.Controls.Add(btnListadoSocios);
            panel2.Location = new Point(36, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 125);
            panel2.TabIndex = 13;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFacturacion.Location = new Point(36, 350);
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(165, 37);
            lblFacturacion.TabIndex = 14;
            lblFacturacion.Text = "Facturación";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(btnRegistrarAsistencia);
            panel3.Controls.Add(btnPagarSueldo);
            panel3.Location = new Point(36, 597);
            panel3.Name = "panel3";
            panel3.Size = new Size(463, 125);
            panel3.TabIndex = 15;
            // 
            // lblProfesores
            // 
            lblProfesores.AutoSize = true;
            lblProfesores.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblProfesores.Location = new Point(36, 557);
            lblProfesores.Name = "lblProfesores";
            lblProfesores.Size = new Size(154, 37);
            lblProfesores.TabIndex = 16;
            lblProfesores.Text = "Profesores";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1212, 782);
            Controls.Add(lblProfesores);
            Controls.Add(panel3);
            Controls.Add(lblFacturacion);
            Controls.Add(panel2);
            Controls.Add(pnlSocios);
            Controls.Add(lblDate);
            Controls.Add(btnSalir);
            Controls.Add(lblRol);
            Controls.Add(lblSocio);
            Controls.Add(lblUsuario);
            Name = "frmPrincipal";
            Text = "Club deportivo - Home";
            Load += frmPrincipal_Load;
            pnlSocios.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCobrarCuota;
        private Button btnCobrarActividad;
        private Button btnRegistrarAsistencia;
        private Button btnPagarSueldo;
        private Button btnListadoSocios;
        private Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private Label lblDate;
        private Label lblUsuario;
        private Label lblRol;
        private Label lblSocio;
        private Button btnRegistrarSocio;
        private Button btnEmitirCarnet;
        private Button btnRegistrarNoSocio;
        private Panel pnlDivisor;
        private Button btnListarSocios;
        private Button btnListarNoSocios;
        private Panel panel1;
        private Panel pnlSocios;
        private Panel panel2;
        private Label lblFacturacion;
        private Panel panel3;
        private Label lblProfesores;
    }
}