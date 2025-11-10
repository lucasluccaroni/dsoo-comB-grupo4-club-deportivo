namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmPagarCuota
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
            lblSocio = new Label();
            txtSocio = new TextBox();
            grpTipoPago = new GroupBox();
            rbtTarjeta6 = new RadioButton();
            rbtTarjeta3 = new RadioButton();
            rbtTarjeta1 = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnPagar = new Button();
            btnComprobante = new Button();
            grpTipoPago.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(132, 58);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(182, 20);
            lblSocio.TabIndex = 1;
            lblSocio.Text = "Ingrese número de Socio";
            // 
            // txtSocio
            // 
            txtSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSocio.Location = new Point(132, 89);
            txtSocio.Name = "txtSocio";
            txtSocio.PlaceholderText = "Id Socio";
            txtSocio.Size = new Size(182, 27);
            txtSocio.TabIndex = 2;
            // 
            // grpTipoPago
            // 
            grpTipoPago.Controls.Add(rbtTarjeta6);
            grpTipoPago.Controls.Add(rbtTarjeta3);
            grpTipoPago.Controls.Add(rbtTarjeta1);
            grpTipoPago.Controls.Add(rbtEfectivo);
            grpTipoPago.Font = new Font("Segoe UI", 11.25F);
            grpTipoPago.Location = new Point(380, 58);
            grpTipoPago.Name = "grpTipoPago";
            grpTipoPago.Size = new Size(200, 166);
            grpTipoPago.TabIndex = 3;
            grpTipoPago.TabStop = false;
            grpTipoPago.Text = "Tipo de pago";
            // 
            // rbtTarjeta6
            // 
            rbtTarjeta6.AutoSize = true;
            rbtTarjeta6.Font = new Font("Segoe UI", 11.25F);
            rbtTarjeta6.Location = new Point(29, 114);
            rbtTarjeta6.Name = "rbtTarjeta6";
            rbtTarjeta6.Size = new Size(130, 24);
            rbtTarjeta6.TabIndex = 3;
            rbtTarjeta6.TabStop = true;
            rbtTarjeta6.Text = "Tarjeta 6 cuotas";
            rbtTarjeta6.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta3
            // 
            rbtTarjeta3.AutoSize = true;
            rbtTarjeta3.Font = new Font("Segoe UI", 11.25F);
            rbtTarjeta3.Location = new Point(29, 85);
            rbtTarjeta3.Name = "rbtTarjeta3";
            rbtTarjeta3.Size = new Size(130, 24);
            rbtTarjeta3.TabIndex = 2;
            rbtTarjeta3.TabStop = true;
            rbtTarjeta3.Text = "Tarjeta 3 cuotas";
            rbtTarjeta3.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta1
            // 
            rbtTarjeta1.AutoSize = true;
            rbtTarjeta1.Font = new Font("Segoe UI", 11.25F);
            rbtTarjeta1.Location = new Point(29, 58);
            rbtTarjeta1.Name = "rbtTarjeta1";
            rbtTarjeta1.Size = new Size(122, 24);
            rbtTarjeta1.TabIndex = 1;
            rbtTarjeta1.TabStop = true;
            rbtTarjeta1.Text = "Tarjeta 1 pago";
            rbtTarjeta1.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Font = new Font("Segoe UI", 11.25F);
            rbtEfectivo.Location = new Point(29, 31);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(80, 24);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(116, 164);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(218, 38);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComprobante.Location = new Point(116, 231);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(218, 38);
            btnComprobante.TabIndex = 5;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 316);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(grpTipoPago);
            Controls.Add(txtSocio);
            Controls.Add(lblSocio);
            Controls.Add(btnVolver);
            Name = "frmPagarCuota";
            Text = "Pagar una cuota";
            Load += frmPagarCuota_Load;
            grpTipoPago.ResumeLayout(false);
            grpTipoPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblSocio;
        private TextBox txtSocio;
        private GroupBox grpTipoPago;
        private RadioButton rbtTarjeta6;
        private RadioButton rbtTarjeta3;
        private RadioButton rbtTarjeta1;
        private RadioButton rbtEfectivo;
        private Button btnPagar;
        private Button btnComprobante;
    }
}