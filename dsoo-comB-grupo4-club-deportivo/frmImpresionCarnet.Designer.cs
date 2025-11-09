namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmImpresionCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpresionCarnet));
            pnlDatos = new Panel();
            lblFechaVenc = new Label();
            lblFechaInscrip = new Label();
            lblDni = new Label();
            lblNombre = new Label();
            lblId = new Label();
            lblFechaVencRef = new Label();
            lblFechaInscripRef = new Label();
            lblDniRef = new Label();
            lblNombreRef = new Label();
            lblIdRef = new Label();
            picFoto = new PictureBox();
            picLogo = new PictureBox();
            btnImprimir = new Button();
            btnVolver = new Button();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.OldLace;
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(lblFechaVenc);
            pnlDatos.Controls.Add(lblFechaInscrip);
            pnlDatos.Controls.Add(lblDni);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(lblId);
            pnlDatos.Controls.Add(lblFechaVencRef);
            pnlDatos.Controls.Add(lblFechaInscripRef);
            pnlDatos.Controls.Add(lblDniRef);
            pnlDatos.Controls.Add(lblNombreRef);
            pnlDatos.Controls.Add(lblIdRef);
            pnlDatos.Location = new Point(168, 22);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(456, 238);
            pnlDatos.TabIndex = 0;
            // 
            // lblFechaVenc
            // 
            lblFechaVenc.AutoSize = true;
            lblFechaVenc.Font = new Font("Segoe UI", 11.25F);
            lblFechaVenc.Location = new Point(259, 187);
            lblFechaVenc.Name = "lblFechaVenc";
            lblFechaVenc.Size = new Size(78, 20);
            lblFechaVenc.TabIndex = 9;
            lblFechaVenc.Text = "FechaVenc";
            // 
            // lblFechaInscrip
            // 
            lblFechaInscrip.AutoSize = true;
            lblFechaInscrip.Font = new Font("Segoe UI", 11.25F);
            lblFechaInscrip.Location = new Point(259, 147);
            lblFechaInscrip.Name = "lblFechaInscrip";
            lblFechaInscrip.Size = new Size(90, 20);
            lblFechaInscrip.TabIndex = 8;
            lblFechaInscrip.Text = "FechaInscrip";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11.25F);
            lblDni.Location = new Point(259, 107);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F);
            lblNombre.Location = new Point(259, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nom Y Ap";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F);
            lblId.Location = new Point(259, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // lblFechaVencRef
            // 
            lblFechaVencRef.AutoSize = true;
            lblFechaVencRef.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            lblFechaVencRef.Location = new Point(46, 187);
            lblFechaVencRef.Name = "lblFechaVencRef";
            lblFechaVencRef.Size = new Size(164, 20);
            lblFechaVencRef.TabIndex = 4;
            lblFechaVencRef.Text = "Fecha de Vencimiento:";
            // 
            // lblFechaInscripRef
            // 
            lblFechaInscripRef.AutoSize = true;
            lblFechaInscripRef.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            lblFechaInscripRef.Location = new Point(57, 147);
            lblFechaInscripRef.Name = "lblFechaInscripRef";
            lblFechaInscripRef.Size = new Size(152, 20);
            lblFechaInscripRef.TabIndex = 3;
            lblFechaInscripRef.Text = "Fecha de Inscripcion:";
            // 
            // lblDniRef
            // 
            lblDniRef.AutoSize = true;
            lblDniRef.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            lblDniRef.Location = new Point(165, 107);
            lblDniRef.Name = "lblDniRef";
            lblDniRef.Size = new Size(40, 20);
            lblDniRef.TabIndex = 2;
            lblDniRef.Text = "DNI:";
            // 
            // lblNombreRef
            // 
            lblNombreRef.AutoSize = true;
            lblNombreRef.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            lblNombreRef.Location = new Point(66, 67);
            lblNombreRef.Name = "lblNombreRef";
            lblNombreRef.Size = new Size(140, 20);
            lblNombreRef.TabIndex = 1;
            lblNombreRef.Text = "Nombre y apellido:";
            // 
            // lblIdRef
            // 
            lblIdRef.AutoSize = true;
            lblIdRef.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            lblIdRef.Location = new Point(133, 27);
            lblIdRef.Name = "lblIdRef";
            lblIdRef.Size = new Size(70, 20);
            lblIdRef.TabIndex = 0;
            lblIdRef.Text = "Socio N°:";
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Image = (Image)resources.GetObject("picFoto.Image");
            picFoto.Location = new Point(46, 141);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(116, 119);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 1;
            picFoto.TabStop = false;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(46, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(116, 113);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(543, 279);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(81, 32);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(446, 279);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 32);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmImpresionCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 321);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimir);
            Controls.Add(picLogo);
            Controls.Add(picFoto);
            Controls.Add(pnlDatos);
            Name = "frmImpresionCarnet";
            Text = "Carnet";
            Load += frmImpresionCarnet_Load;
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatos;
        private Label lblFechaInscripRef;
        private Label lblDniRef;
        private Label lblNombreRef;
        private Label lblIdRef;
        private Label lblFechaVencRef;
        private Label lblFechaVenc;
        private Label lblFechaInscrip;
        private Label lblDni;
        private Label lblNombre;
        private Label lblId;
        private PictureBox picFoto;
        private PictureBox picLogo;
        private Button btnImprimir;
        private Button btnVolver;
    }
}