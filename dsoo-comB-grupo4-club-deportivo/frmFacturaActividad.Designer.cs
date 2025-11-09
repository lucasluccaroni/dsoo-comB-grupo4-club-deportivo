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
            lblPrecioRef.Location = new Point(250, 108);
            lblPrecioRef.Name = "lblPrecioRef";
            lblPrecioRef.Size = new Size(56, 20);
            lblPrecioRef.TabIndex = 15;
            lblPrecioRef.Text = "Monto:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(621, 294);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(83, 33);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 10.8F);
            lblNoSocio.Location = new Point(364, 18);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(66, 20);
            lblNoSocio.TabIndex = 1;
            lblNoSocio.Text = "NoSocio";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 10.8F);
            lblActividad.Location = new Point(364, 48);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(72, 20);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Actividad";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.8F);
            lblFecha.Location = new Point(364, 78);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.8F);
            lblPrecio.Location = new Point(364, 108);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10.8F);
            lblFechaPago.Location = new Point(179, 35);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 20);
            lblFechaPago.TabIndex = 5;
            lblFechaPago.Text = "Fecha Pago";
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 10.8F);
            lblClub.Location = new Point(158, 35);
            lblClub.Name = "lblClub";
            lblClub.RightToLeft = RightToLeft.No;
            lblClub.Size = new Size(105, 20);
            lblClub.TabIndex = 6;
            lblClub.Text = "Titan GYM S.A.";
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComprobante.Location = new Point(204, 0);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(265, 30);
            lblComprobante.TabIndex = 7;
            lblComprobante.Text = "COMPROBANTE DE PAGO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pnlComprobante
            // 
            pnlComprobante.BorderStyle = BorderStyle.FixedSingle;
            pnlComprobante.Controls.Add(lblComprobante);
            pnlComprobante.Location = new Point(7, 9);
            pnlComprobante.Margin = new Padding(3, 2, 3, 2);
            pnlComprobante.Name = "pnlComprobante";
            pnlComprobante.Size = new Size(698, 39);
            pnlComprobante.TabIndex = 9;
            // 
            // pnlClub
            // 
            pnlClub.BorderStyle = BorderStyle.FixedSingle;
            pnlClub.Controls.Add(pictureBox1);
            pnlClub.Controls.Add(lblClub);
            pnlClub.Location = new Point(7, 52);
            pnlClub.Margin = new Padding(3, 2, 3, 2);
            pnlClub.Name = "pnlClub";
            pnlClub.Size = new Size(313, 85);
            pnlClub.TabIndex = 10;
            // 
            // pnlFecha
            // 
            pnlFecha.BorderStyle = BorderStyle.FixedSingle;
            pnlFecha.Controls.Add(lblFechaRef);
            pnlFecha.Controls.Add(lblFechaPago);
            pnlFecha.Location = new Point(325, 52);
            pnlFecha.Margin = new Padding(3, 2, 3, 2);
            pnlFecha.Name = "pnlFecha";
            pnlFecha.Size = new Size(381, 85);
            pnlFecha.TabIndex = 11;
            // 
            // lblFechaRef
            // 
            lblFechaRef.AutoSize = true;
            lblFechaRef.Font = new Font("Segoe UI", 10.8F);
            lblFechaRef.Location = new Point(80, 35);
            lblFechaRef.Name = "lblFechaRef";
            lblFechaRef.Size = new Size(50, 20);
            lblFechaRef.TabIndex = 6;
            lblFechaRef.Text = "Fecha:";
            // 
            // lblNoSocioRef
            // 
            lblNoSocioRef.AutoSize = true;
            lblNoSocioRef.Font = new Font("Segoe UI", 10.8F);
            lblNoSocioRef.Location = new Point(168, 18);
            lblNoSocioRef.Name = "lblNoSocioRef";
            lblNoSocioRef.Size = new Size(137, 20);
            lblNoSocioRef.TabIndex = 12;
            lblNoSocioRef.Text = "Nombre y apellido:";
            // 
            // lblActRef
            // 
            lblActRef.AutoSize = true;
            lblActRef.Font = new Font("Segoe UI", 10.8F);
            lblActRef.Location = new Point(233, 48);
            lblActRef.Name = "lblActRef";
            lblActRef.Size = new Size(75, 20);
            lblActRef.TabIndex = 13;
            lblActRef.Text = "Actividad:";
            // 
            // lblFechaActRef
            // 
            lblFechaActRef.AutoSize = true;
            lblFechaActRef.Font = new Font("Segoe UI", 10.8F);
            lblFechaActRef.Location = new Point(258, 78);
            lblFechaActRef.Name = "lblFechaActRef";
            lblFechaActRef.Size = new Size(50, 20);
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
            panel1.Location = new Point(7, 141);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 149);
            panel1.TabIndex = 16;
            // 
            // frmFacturaActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 336);
            Controls.Add(panel1);
            Controls.Add(pnlFecha);
            Controls.Add(pnlClub);
            Controls.Add(pnlComprobante);
            Controls.Add(btnImprimir);
            Margin = new Padding(3, 2, 3, 2);
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
        private Panel panel1;
    }
}