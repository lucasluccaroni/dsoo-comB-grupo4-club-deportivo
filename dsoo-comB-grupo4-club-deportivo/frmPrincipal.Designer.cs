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
            btnListadoVencimiento = new Button();
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
            lblNoSocio = new Label();
            pnlSocios.SuspendLayout();
            SuspendLayout();
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackColor = Color.FromArgb(255, 224, 192);
            btnCobrarCuota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCobrarCuota.ForeColor = SystemColors.ControlText;
            btnCobrarCuota.Location = new Point(130, 218);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(133, 70);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = false;
            btnCobrarCuota.Click += btnCobrarCuota_Click;
            // 
            // btnInscribirActividadNoSocio
            // 
            btnInscribirActividadNoSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnInscribirActividadNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInscribirActividadNoSocio.ForeColor = SystemColors.ControlText;
            btnInscribirActividadNoSocio.Location = new Point(583, 102);
            btnInscribirActividadNoSocio.Name = "btnInscribirActividadNoSocio";
            btnInscribirActividadNoSocio.Size = new Size(133, 70);
            btnInscribirActividadNoSocio.TabIndex = 2;
            btnInscribirActividadNoSocio.Text = "Inscribir a Actividad";
            btnInscribirActividadNoSocio.UseVisualStyleBackColor = false;
            btnInscribirActividadNoSocio.Click += btnInscribirActividadNoSocio_Click;
            // 
            // btnListadoVencimiento
            // 
            btnListadoVencimiento.BackColor = Color.FromArgb(255, 224, 192);
            btnListadoVencimiento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListadoVencimiento.ForeColor = SystemColors.ControlText;
            btnListadoVencimiento.Location = new Point(916, 172);
            btnListadoVencimiento.Name = "btnListadoVencimiento";
            btnListadoVencimiento.Size = new Size(133, 95);
            btnListadoVencimiento.TabIndex = 7;
            btnListadoVencimiento.Text = "Listado Socios vencen hoy";
            btnListadoVencimiento.UseVisualStyleBackColor = false;
            btnListadoVencimiento.Click += btnListadoVencimiento_Click;
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
            lblDate.Size = new Size(13, 17);
            lblDate.TabIndex = 11;
            lblDate.Text = "-";
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
            lblSocio.Location = new Point(210, 136);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(99, 37);
            lblSocio.TabIndex = 6;
            lblSocio.Text = "Socios";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnRegistrarSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarSocio.Location = new Point(32, 52);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(133, 70);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.FromArgb(255, 224, 192);
            btnEmitirCarnet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEmitirCarnet.ForeColor = SystemColors.ControlText;
            btnEmitirCarnet.Location = new Point(916, 32);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(133, 70);
            btnEmitirCarnet.TabIndex = 6;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(255, 224, 192);
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegistrarNoSocio.ForeColor = SystemColors.ControlText;
            btnRegistrarNoSocio.Location = new Point(474, 17);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(133, 70);
            btnRegistrarNoSocio.TabIndex = 5;
            btnRegistrarNoSocio.Text = "Registrar \r\nNo Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // pnlDivisor
            // 
            pnlDivisor.BackColor = Color.Black;
            pnlDivisor.ForeColor = SystemColors.ActiveCaptionText;
            pnlDivisor.Location = new Point(424, 0);
            pnlDivisor.Name = "pnlDivisor";
            pnlDivisor.Size = new Size(2, 323);
            pnlDivisor.TabIndex = 13;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.FromArgb(255, 224, 192);
            btnListarSocios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnListarSocios.Location = new Point(232, 52);
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
            btnListarNoSocios.Location = new Point(699, 17);
            btnListarNoSocios.Name = "btnListarNoSocios";
            btnListarNoSocios.Size = new Size(133, 70);
            btnListarNoSocios.TabIndex = 15;
            btnListarNoSocios.Text = "Listar No Socios";
            btnListarNoSocios.UseVisualStyleBackColor = false;
            btnListarNoSocios.Click += btnListarNoSocios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(888, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 323);
            panel1.TabIndex = 16;
            // 
            // pnlSocios
            // 
            pnlSocios.BackColor = Color.FromArgb(224, 224, 224);
            pnlSocios.Controls.Add(btnPagarActividad);
            pnlSocios.Controls.Add(panel2);
            pnlSocios.Controls.Add(btnListadoVencimiento);
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
            pnlSocios.Location = new Point(54, 188);
            pnlSocios.Name = "pnlSocios";
            pnlSocios.Size = new Size(1076, 322);
            pnlSocios.TabIndex = 12;
            // 
            // btnPagarActividad
            // 
            btnPagarActividad.BackColor = Color.FromArgb(255, 224, 192);
            btnPagarActividad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarActividad.Location = new Point(583, 218);
            btnPagarActividad.Margin = new Padding(3, 2, 3, 2);
            btnPagarActividad.Name = "btnPagarActividad";
            btnPagarActividad.Size = new Size(133, 70);
            btnPagarActividad.TabIndex = 18;
            btnPagarActividad.Text = "Pagar Actividad";
            btnPagarActividad.UseVisualStyleBackColor = false;
            btnPagarActividad.Click += btnPagarActividad_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 2);
            panel2.TabIndex = 17;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFacturacion.Location = new Point(354, 194);
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(126, 30);
            lblFacturacion.TabIndex = 14;
            lblFacturacion.Text = "Facturación";
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNoSocio.Location = new Point(648, 136);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(144, 37);
            lblNoSocio.TabIndex = 17;
            lblNoSocio.Text = "No Socios";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1212, 589);
            Controls.Add(lblNoSocio);
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
            pnlSocios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCobrarCuota;
        private Button btnInscribirActividadNoSocio;
        private Button btnListadoVencimiento;
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
        private Panel panel2;
        private Label lblNoSocio;
        private Button btnPagarActividad;
    }
}