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
            btnInscribirActividadNoSocio = new Button();
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
            btnPagarActividad = new Button();
            panel2 = new Panel();
            lblFacturacion = new Label();
            panel3 = new Panel();
            lblProfesores = new Label();
            lblNoSocio = new Label();
            pnlSocios.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCobrarCuota.ForeColor = SystemColors.AppWorkspace;
            btnCobrarCuota.Location = new Point(148, 291);
            btnCobrarCuota.Margin = new Padding(3, 4, 3, 4);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(152, 93);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btnInscribirActividadNoSocio
            // 
            btnInscribirActividadNoSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnInscribirActividadNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInscribirActividadNoSocio.ForeColor = SystemColors.ControlText;
            btnInscribirActividadNoSocio.Location = new Point(666, 136);
            btnInscribirActividadNoSocio.Margin = new Padding(3, 4, 3, 4);
            btnInscribirActividadNoSocio.Name = "btnInscribirActividadNoSocio";
            btnInscribirActividadNoSocio.Size = new Size(152, 93);
            btnInscribirActividadNoSocio.TabIndex = 2;
            btnInscribirActividadNoSocio.Text = "Inscribir a Actividad";
            btnInscribirActividadNoSocio.UseVisualStyleBackColor = false;
            btnInscribirActividadNoSocio.Click += btnInscribirActividadNoSocio_Click;
            // 
            // btnRegistrarAsistencia
            // 
            btnRegistrarAsistencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarAsistencia.ForeColor = SystemColors.AppWorkspace;
            btnRegistrarAsistencia.Location = new Point(46, 31);
            btnRegistrarAsistencia.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            btnRegistrarAsistencia.Size = new Size(152, 93);
            btnRegistrarAsistencia.TabIndex = 3;
            btnRegistrarAsistencia.Text = "Registrar Asistencia (profesor)";
            btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnPagarSueldo
            // 
            btnPagarSueldo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPagarSueldo.ForeColor = SystemColors.AppWorkspace;
            btnPagarSueldo.Location = new Point(265, 15);
            btnPagarSueldo.Margin = new Padding(3, 4, 3, 4);
            btnPagarSueldo.Name = "btnPagarSueldo";
            btnPagarSueldo.Size = new Size(139, 127);
            btnPagarSueldo.TabIndex = 4;
            btnPagarSueldo.Text = "Pagar sueldo (profesor)";
            btnPagarSueldo.UseVisualStyleBackColor = true;
            // 
            // btnListadoSocios
            // 
            btnListadoSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListadoSocios.ForeColor = SystemColors.AppWorkspace;
            btnListadoSocios.Location = new Point(1047, 230);
            btnListadoSocios.Margin = new Padding(3, 4, 3, 4);
            btnListadoSocios.Name = "btnListadoSocios";
            btnListadoSocios.Size = new Size(152, 127);
            btnListadoSocios.TabIndex = 7;
            btnListadoSocios.Text = "Listado de Socios a vencer";
            btnListadoSocios.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 192);
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1214, 12);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 67);
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
            lblDate.Location = new Point(14, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(17, 23);
            lblDate.TabIndex = 11;
            lblDate.Text = "-";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblUsuario.Location = new Point(14, 53);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(20, 23);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "a";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblRol.Location = new Point(14, 100);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(20, 23);
            lblRol.TabIndex = 9;
            lblRol.Text = "a";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(240, 181);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(122, 46);
            lblSocio.TabIndex = 6;
            lblSocio.Text = "Socios";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnRegistrarSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarSocio.Location = new Point(37, 69);
            btnRegistrarSocio.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(152, 93);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEmitirCarnet.ForeColor = SystemColors.AppWorkspace;
            btnEmitirCarnet.Location = new Point(1047, 43);
            btnEmitirCarnet.Margin = new Padding(3, 4, 3, 4);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(152, 93);
            btnEmitirCarnet.TabIndex = 6;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarNoSocio.ForeColor = SystemColors.ControlText;
            btnRegistrarNoSocio.Location = new Point(542, 23);
            btnRegistrarNoSocio.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(152, 93);
            btnRegistrarNoSocio.TabIndex = 5;
            btnRegistrarNoSocio.Text = "Registrar \r\nNo Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // pnlDivisor
            // 
            pnlDivisor.BackColor = Color.Black;
            pnlDivisor.ForeColor = SystemColors.ActiveCaptionText;
            pnlDivisor.Location = new Point(485, 0);
            pnlDivisor.Margin = new Padding(3, 4, 3, 4);
            pnlDivisor.Name = "pnlDivisor";
            pnlDivisor.Size = new Size(2, 431);
            pnlDivisor.TabIndex = 13;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.FromArgb(255, 224, 192);
            btnListarSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListarSocios.Location = new Point(265, 69);
            btnListarSocios.Margin = new Padding(3, 4, 3, 4);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(152, 93);
            btnListarSocios.TabIndex = 14;
            btnListarSocios.Text = "Listar Socios";
            btnListarSocios.UseVisualStyleBackColor = false;
            btnListarSocios.Click += btnListarSocios_Click;
            // 
            // btnListarNoSocios
            // 
            btnListarNoSocios.BackColor = Color.FromArgb(255, 224, 192);
            btnListarNoSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListarNoSocios.Location = new Point(799, 23);
            btnListarNoSocios.Margin = new Padding(3, 4, 3, 4);
            btnListarNoSocios.Name = "btnListarNoSocios";
            btnListarNoSocios.Size = new Size(152, 93);
            btnListarNoSocios.TabIndex = 15;
            btnListarNoSocios.Text = "Listar No Socios";
            btnListarNoSocios.UseVisualStyleBackColor = false;
            btnListarNoSocios.Click += btnListarNoSocios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(1015, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 431);
            panel1.TabIndex = 16;
            // 
            // pnlSocios
            // 
            pnlSocios.BackColor = Color.FromArgb(224, 224, 224);
            pnlSocios.Controls.Add(btnPagarActividad);
            pnlSocios.Controls.Add(panel2);
            pnlSocios.Controls.Add(btnListadoSocios);
            pnlSocios.Controls.Add(btnInscribirActividadNoSocio);
            pnlSocios.Controls.Add(lblFacturacion);
            pnlSocios.Controls.Add(btnCobrarCuota);
            pnlSocios.Controls.Add(panel1);
            pnlSocios.Controls.Add(btnListarNoSocios);
            pnlSocios.Controls.Add(btnListarSocios);
            pnlSocios.Controls.Add(pnlDivisor);
            pnlSocios.Controls.Add(btnRegistrarNoSocio);
            pnlSocios.Controls.Add(btnEmitirCarnet);
            pnlSocios.Controls.Add(btnRegistrarSocio);
            pnlSocios.Location = new Point(62, 251);
            pnlSocios.Margin = new Padding(3, 4, 3, 4);
            pnlSocios.Name = "pnlSocios";
            pnlSocios.Size = new Size(1230, 429);
            pnlSocios.TabIndex = 12;
            // 
            // btnPagarActividad
            // 
            btnPagarActividad.BackColor = Color.FromArgb(255, 224, 192);
            btnPagarActividad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarActividad.Location = new Point(666, 291);
            btnPagarActividad.Name = "btnPagarActividad";
            btnPagarActividad.Size = new Size(152, 93);
            btnPagarActividad.TabIndex = 18;
            btnPagarActividad.Text = "Pagar Actividad";
            btnPagarActividad.UseVisualStyleBackColor = false;
            btnPagarActividad.Click += btnPagarActividad_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 258);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 3);
            panel2.TabIndex = 17;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFacturacion.Location = new Point(404, 258);
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
            panel3.Location = new Point(62, 792);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 167);
            panel3.TabIndex = 15;
            // 
            // lblProfesores
            // 
            lblProfesores.AutoSize = true;
            lblProfesores.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblProfesores.Location = new Point(62, 739);
            lblProfesores.Name = "lblProfesores";
            lblProfesores.Size = new Size(189, 46);
            lblProfesores.TabIndex = 16;
            lblProfesores.Text = "Profesores";
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNoSocio.Location = new Point(741, 181);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(179, 46);
            lblNoSocio.TabIndex = 17;
            lblNoSocio.Text = "No Socios";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1385, 1043);
            Controls.Add(lblNoSocio);
            Controls.Add(lblProfesores);
            Controls.Add(panel3);
            Controls.Add(pnlSocios);
            Controls.Add(lblDate);
            Controls.Add(btnSalir);
            Controls.Add(lblRol);
            Controls.Add(lblSocio);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "Club deportivo - Home";
            Load += frmPrincipal_Load;
            pnlSocios.ResumeLayout(false);
            pnlSocios.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCobrarCuota;
        private Button btnInscribirActividadNoSocio;
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
        private Label lblFacturacion;
        private Panel panel3;
        private Label lblProfesores;
        private Panel panel2;
        private Label lblNoSocio;
        private Button btnPagarActividad;
    }
}