namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmFacturaCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaCuota));
            pnlComprobante = new Panel();
            lblComprobante = new Label();
            pnlClub = new Panel();
            lblClub = new Label();
            picLogo = new PictureBox();
            panel2 = new Panel();
            lblPagoId = new Label();
            lblPagoIDRef = new Label();
            lblFechaHoy = new Label();
            lblFechaPagoRef = new Label();
            panel1 = new Panel();
            lblTipoPago = new Label();
            lblMonto = new Label();
            lblTipoPagoRef = new Label();
            lblMontoRef = new Label();
            lblNroCuota = new Label();
            lblNroCuotaRef = new Label();
            lblFechaVenc = new Label();
            lblFechaVencRef = new Label();
            lblSocioId = new Label();
            lblSocioIdRef = new Label();
            btnImprimir = new Button();
            lblNombreCompletoRef = new Label();
            lblNombreCompleto = new Label();
            pnlComprobante.SuspendLayout();
            pnlClub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlComprobante
            // 
            pnlComprobante.BorderStyle = BorderStyle.FixedSingle;
            pnlComprobante.Controls.Add(lblComprobante);
            pnlComprobante.Location = new Point(12, 12);
            pnlComprobante.Name = "pnlComprobante";
            pnlComprobante.Size = new Size(692, 62);
            pnlComprobante.TabIndex = 0;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComprobante.Location = new Point(202, 11);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(258, 30);
            lblComprobante.TabIndex = 0;
            lblComprobante.Text = "COMPROBANTE DE PAGO";
            // 
            // pnlClub
            // 
            pnlClub.BorderStyle = BorderStyle.FixedSingle;
            pnlClub.Controls.Add(lblClub);
            pnlClub.Controls.Add(picLogo);
            pnlClub.Location = new Point(12, 80);
            pnlClub.Name = "pnlClub";
            pnlClub.Size = new Size(321, 124);
            pnlClub.TabIndex = 1;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Location = new Point(178, 51);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(110, 15);
            lblClub.TabIndex = 1;
            lblClub.Text = "Club Deportivo S.A.";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(18, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(142, 95);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblPagoId);
            panel2.Controls.Add(lblPagoIDRef);
            panel2.Controls.Add(lblFechaHoy);
            panel2.Controls.Add(lblFechaPagoRef);
            panel2.Location = new Point(350, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 124);
            panel2.TabIndex = 2;
            // 
            // lblPagoId
            // 
            lblPagoId.AutoSize = true;
            lblPagoId.Location = new Point(202, 79);
            lblPagoId.Name = "lblPagoId";
            lblPagoId.Size = new Size(18, 15);
            lblPagoId.TabIndex = 2;
            lblPagoId.Text = "ID";
            // 
            // lblPagoIDRef
            // 
            lblPagoIDRef.AutoSize = true;
            lblPagoIDRef.Location = new Point(65, 79);
            lblPagoIDRef.Name = "lblPagoIDRef";
            lblPagoIDRef.Size = new Size(57, 15);
            lblPagoIDRef.TabIndex = 0;
            lblPagoIDRef.Text = "Pago N°: ";
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.Location = new Point(202, 37);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(65, 15);
            lblFechaHoy.TabIndex = 1;
            lblFechaHoy.Text = "FechaPago";
            // 
            // lblFechaPagoRef
            // 
            lblFechaPagoRef.AutoSize = true;
            lblFechaPagoRef.Location = new Point(78, 37);
            lblFechaPagoRef.Name = "lblFechaPagoRef";
            lblFechaPagoRef.Size = new Size(38, 15);
            lblFechaPagoRef.TabIndex = 0;
            lblFechaPagoRef.Text = "Fecha";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNombreCompleto);
            panel1.Controls.Add(lblNombreCompletoRef);
            panel1.Controls.Add(lblTipoPago);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lblTipoPagoRef);
            panel1.Controls.Add(lblMontoRef);
            panel1.Controls.Add(lblNroCuota);
            panel1.Controls.Add(lblNroCuotaRef);
            panel1.Controls.Add(lblFechaVenc);
            panel1.Controls.Add(lblFechaVencRef);
            panel1.Controls.Add(lblSocioId);
            panel1.Controls.Add(lblSocioIdRef);
            panel1.Location = new Point(12, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 205);
            panel1.TabIndex = 3;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(578, 169);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(28, 15);
            lblTipoPago.TabIndex = 10;
            lblTipoPago.Text = "tipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(575, 127);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "monto";
            // 
            // lblTipoPagoRef
            // 
            lblTipoPagoRef.AutoSize = true;
            lblTipoPagoRef.Location = new Point(457, 169);
            lblTipoPagoRef.Name = "lblTipoPagoRef";
            lblTipoPagoRef.Size = new Size(79, 15);
            lblTipoPagoRef.TabIndex = 8;
            lblTipoPagoRef.Text = "Tipo de Pago:";
            // 
            // lblMontoRef
            // 
            lblMontoRef.AutoSize = true;
            lblMontoRef.Location = new Point(490, 127);
            lblMontoRef.Name = "lblMontoRef";
            lblMontoRef.Size = new Size(46, 15);
            lblMontoRef.TabIndex = 7;
            lblMontoRef.Text = "Monto:";
            // 
            // lblNroCuota
            // 
            lblNroCuota.AutoSize = true;
            lblNroCuota.Location = new Point(278, 86);
            lblNroCuota.Name = "lblNroCuota";
            lblNroCuota.Size = new Size(37, 15);
            lblNroCuota.TabIndex = 5;
            lblNroCuota.Text = "cuota";
            // 
            // lblNroCuotaRef
            // 
            lblNroCuotaRef.AutoSize = true;
            lblNroCuotaRef.Location = new Point(150, 86);
            lblNroCuotaRef.Name = "lblNroCuotaRef";
            lblNroCuotaRef.Size = new Size(59, 15);
            lblNroCuotaRef.TabIndex = 4;
            lblNroCuotaRef.Text = "Cuota N°:";
            // 
            // lblFechaVenc
            // 
            lblFechaVenc.AutoSize = true;
            lblFechaVenc.Location = new Point(283, 114);
            lblFechaVenc.Name = "lblFechaVenc";
            lblFechaVenc.Size = new Size(64, 15);
            lblFechaVenc.TabIndex = 3;
            lblFechaVenc.Text = "fecha venc";
            // 
            // lblFechaVencRef
            // 
            lblFechaVencRef.AutoSize = true;
            lblFechaVencRef.Location = new Point(92, 114);
            lblFechaVencRef.Name = "lblFechaVencRef";
            lblFechaVencRef.Size = new Size(126, 15);
            lblFechaVencRef.TabIndex = 2;
            lblFechaVencRef.Text = "Fecha de vencimiento:";
            // 
            // lblSocioId
            // 
            lblSocioId.AutoSize = true;
            lblSocioId.Location = new Point(278, 32);
            lblSocioId.Name = "lblSocioId";
            lblSocioId.Size = new Size(18, 15);
            lblSocioId.TabIndex = 1;
            lblSocioId.Text = "ID";
            // 
            // lblSocioIdRef
            // 
            lblSocioIdRef.AutoSize = true;
            lblSocioIdRef.Location = new Point(156, 32);
            lblSocioIdRef.Name = "lblSocioIdRef";
            lblSocioIdRef.Size = new Size(53, 15);
            lblSocioIdRef.TabIndex = 0;
            lblSocioIdRef.Text = "Socio ID:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(622, 421);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(82, 28);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNombreCompletoRef
            // 
            lblNombreCompletoRef.AutoSize = true;
            lblNombreCompletoRef.Location = new Point(101, 57);
            lblNombreCompletoRef.Name = "lblNombreCompletoRef";
            lblNombreCompletoRef.Size = new Size(108, 15);
            lblNombreCompletoRef.TabIndex = 11;
            lblNombreCompletoRef.Text = "Nombre completo:";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(283, 57);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(32, 15);
            lblNombreCompleto.TabIndex = 12;
            lblNombreCompleto.Text = "nom";
            // 
            // frmFacturaCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 455);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlClub);
            Controls.Add(pnlComprobante);
            Name = "frmFacturaCuota";
            Text = "frmFacturaCuota";
            Load += frmFacturaCuota_Load;
            pnlComprobante.ResumeLayout(false);
            pnlComprobante.PerformLayout();
            pnlClub.ResumeLayout(false);
            pnlClub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlComprobante;
        private Label lblComprobante;
        private Panel pnlClub;
        private PictureBox picLogo;
        private Panel panel2;
        private Label lblClub;
        private Label lblPagoId;
        private Label lblPagoIDRef;
        private Label lblFechaHoy;
        private Label lblFechaPagoRef;
        private Panel panel1;
        private Label lblTipoPago;
        private Label lblMonto;
        private Label lblTipoPagoRef;
        private Label lblMontoRef;
        private Label lblNroCuota;
        private Label lblNroCuotaRef;
        private Label lblFechaVenc;
        private Label lblFechaVencRef;
        private Label lblSocioId;
        private Label lblSocioIdRef;
        private Button btnImprimir;
        private Label lblNombreCompleto;
        private Label lblNombreCompletoRef;
    }
}