namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmFacturaActividad
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
            Label lblPrecioRef;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaActividad));
            btnImprimir = new Button();
            lblNoSocio = new Label();
            lblActividad = new Label();
            lblFecha = new Label();
            lblPrecio = new Label();
            lblFechaPago = new Label();
            lblClub = new Label();
            lblComprobante = new Label();
            pictureBox1 = new PictureBox();
            pnlComprobante = new Panel();
            pnlClub = new Panel();
            pnlFecha = new Panel();
            lblDatos = new Label();
            lblFechaRef = new Label();
            lblNoSocioRef = new Label();
            lblActRef = new Label();
            lblFechaActRef = new Label();
            panel1 = new Panel();
            lblPrecioRef = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlComprobante.SuspendLayout();
            pnlClub.SuspendLayout();
            pnlFecha.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrecioRef
            // 
            lblPrecioRef.AutoSize = true;
            lblPrecioRef.Font = new Font("Segoe UI", 10.8F);
            lblPrecioRef.Location = new Point(286, 154);
            lblPrecioRef.Name = "lblPrecioRef";
            lblPrecioRef.Size = new Size(70, 25);
            lblPrecioRef.TabIndex = 15;
            lblPrecioRef.Text = "Monto:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(712, 422);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 10.8F);
            lblNoSocio.Location = new Point(416, 34);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(80, 25);
            lblNoSocio.TabIndex = 1;
            lblNoSocio.Text = "NoSocio";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 10.8F);
            lblActividad.Location = new Point(416, 74);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(86, 25);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Actividad";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.8F);
            lblFecha.Location = new Point(416, 114);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.8F);
            lblPrecio.Location = new Point(416, 154);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10.8F);
            lblFechaPago.Location = new Point(211, 22);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(102, 25);
            lblFechaPago.TabIndex = 5;
            lblFechaPago.Text = "Fecha Pago";
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 10.8F);
            lblClub.Location = new Point(180, 47);
            lblClub.Name = "lblClub";
            lblClub.RightToLeft = RightToLeft.No;
            lblClub.Size = new Size(164, 25);
            lblClub.TabIndex = 6;
            lblClub.Text = "Club Deportivo S.A";
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComprobante.Location = new Point(233, 0);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(338, 38);
            lblComprobante.TabIndex = 7;
            lblComprobante.Text = "COMPROBANTE DE PAGO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pnlComprobante
            // 
            pnlComprobante.BorderStyle = BorderStyle.FixedSingle;
            pnlComprobante.Controls.Add(lblComprobante);
            pnlComprobante.Location = new Point(8, 12);
            pnlComprobante.Name = "pnlComprobante";
            pnlComprobante.Size = new Size(798, 51);
            pnlComprobante.TabIndex = 9;
            // 
            // pnlClub
            // 
            pnlClub.BorderStyle = BorderStyle.FixedSingle;
            pnlClub.Controls.Add(pictureBox1);
            pnlClub.Controls.Add(lblClub);
            pnlClub.Location = new Point(8, 69);
            pnlClub.Name = "pnlClub";
            pnlClub.Size = new Size(357, 125);
            pnlClub.TabIndex = 10;
            // 
            // pnlFecha
            // 
            pnlFecha.BorderStyle = BorderStyle.FixedSingle;
            pnlFecha.Controls.Add(lblDatos);
            pnlFecha.Controls.Add(lblFechaRef);
            pnlFecha.Controls.Add(lblFechaPago);
            pnlFecha.Location = new Point(371, 69);
            pnlFecha.Name = "pnlFecha";
            pnlFecha.Size = new Size(435, 125);
            pnlFecha.TabIndex = 11;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(105, 78);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(116, 20);
            lblDatos.TabIndex = 7;
            lblDatos.Text = "Datos generales";
            // 
            // lblFechaRef
            // 
            lblFechaRef.AutoSize = true;
            lblFechaRef.Font = new Font("Segoe UI", 10.8F);
            lblFechaRef.Location = new Point(98, 22);
            lblFechaRef.Name = "lblFechaRef";
            lblFechaRef.Size = new Size(61, 25);
            lblFechaRef.TabIndex = 6;
            lblFechaRef.Text = "Fecha:";
            // 
            // lblNoSocioRef
            // 
            lblNoSocioRef.AutoSize = true;
            lblNoSocioRef.Font = new Font("Segoe UI", 10.8F);
            lblNoSocioRef.Location = new Point(192, 34);
            lblNoSocioRef.Name = "lblNoSocioRef";
            lblNoSocioRef.Size = new Size(164, 25);
            lblNoSocioRef.TabIndex = 12;
            lblNoSocioRef.Text = "Nombre y apellido:";
            // 
            // lblActRef
            // 
            lblActRef.AutoSize = true;
            lblActRef.Font = new Font("Segoe UI", 10.8F);
            lblActRef.Location = new Point(266, 74);
            lblActRef.Name = "lblActRef";
            lblActRef.Size = new Size(90, 25);
            lblActRef.TabIndex = 13;
            lblActRef.Text = "Actividad:";
            // 
            // lblFechaActRef
            // 
            lblFechaActRef.AutoSize = true;
            lblFechaActRef.Font = new Font("Segoe UI", 10.8F);
            lblFechaActRef.Location = new Point(295, 114);
            lblFechaActRef.Name = "lblFechaActRef";
            lblFechaActRef.Size = new Size(61, 25);
            lblFechaActRef.TabIndex = 14;
            lblFechaActRef.Text = "Fecha:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNoSocioRef);
            panel1.Controls.Add(lblPrecioRef);
            panel1.Controls.Add(lblNoSocio);
            panel1.Controls.Add(lblFechaActRef);
            panel1.Controls.Add(lblActividad);
            panel1.Controls.Add(lblActRef);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblPrecio);
            panel1.Location = new Point(8, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 216);
            panel1.TabIndex = 16;
            // 
            // frmFacturaActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 463);
            Controls.Add(panel1);
            Controls.Add(pnlFecha);
            Controls.Add(pnlClub);
            Controls.Add(pnlComprobante);
            Controls.Add(btnImprimir);
            Name = "frmFacturaActividad";
            Text = "Comprobante de pago";
            Load += frmFacturaActividad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlComprobante.ResumeLayout(false);
            pnlComprobante.PerformLayout();
            pnlClub.ResumeLayout(false);
            pnlClub.PerformLayout();
            pnlFecha.ResumeLayout(false);
            pnlFecha.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private Label lblNoSocio;
        private Label lblActividad;
        private Label lblFecha;
        private Label lblPrecio;
        private Label lblFechaPago;
        private Label lblClub;
        private Label lblComprobante;
        private PictureBox pictureBox1;
        private Panel pnlComprobante;
        private Panel pnlClub;
        private Panel pnlFecha;
        private Label lblFechaRef;
        private Label lblNoSocioRef;
        private Label lblActRef;
        private Label lblFechaActRef;
        private Label lblDatos;
        private Panel panel1;
    }
}