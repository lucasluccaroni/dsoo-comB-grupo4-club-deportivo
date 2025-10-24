namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmActividadNoSocio
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
            lblNoSocio = new Label();
            lblCodigoActividad = new Label();
            txtIdNoSocio = new TextBox();
            txtIdActividad = new TextBox();
            lblActividades = new Label();
            btnVolver = new Button();
            btnPagar = new Button();
            lblVerificarSocio = new Label();
            lblVerificarActividad = new Label();
            btnVerificarNoSocio = new Button();
            btnVerificarActividad = new Button();
            SuspendLayout();
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 11.25F);
            lblNoSocio.Location = new Point(103, 126);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(162, 20);
            lblNoSocio.TabIndex = 0;
            lblNoSocio.Text = "Ingrese ID del NoSocio";
            // 
            // lblCodigoActividad
            // 
            lblCodigoActividad.AutoSize = true;
            lblCodigoActividad.Font = new Font("Segoe UI", 11.25F);
            lblCodigoActividad.Location = new Point(374, 126);
            lblCodigoActividad.Name = "lblCodigoActividad";
            lblCodigoActividad.Size = new Size(194, 20);
            lblCodigoActividad.TabIndex = 1;
            lblCodigoActividad.Text = "Ingrese código de actividad";
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.Font = new Font("Segoe UI", 11.25F);
            txtIdNoSocio.Location = new Point(103, 161);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.Size = new Size(162, 27);
            txtIdNoSocio.TabIndex = 2;
            // 
            // txtIdActividad
            // 
            txtIdActividad.Font = new Font("Segoe UI", 11.25F);
            txtIdActividad.Location = new Point(374, 161);
            txtIdActividad.Name = "txtIdActividad";
            txtIdActividad.Size = new Size(194, 27);
            txtIdActividad.TabIndex = 3;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.BackColor = Color.FromArgb(255, 224, 192);
            lblActividades.BorderStyle = BorderStyle.FixedSingle;
            lblActividades.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActividades.Location = new Point(688, 95);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(143, 142);
            lblActividades.TabIndex = 4;
            lblActividades.Text = "Actividades:\r\n\r\n8900 ---  Zumba\r\n8901 ---  Spinning\r\n8902 --- Pilates\r\n8903 --- Elongacion\r\n8904 --- HIT\r\n";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 35);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(280, 313);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(106, 43);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // lblVerificarSocio
            // 
            lblVerificarSocio.AutoSize = true;
            lblVerificarSocio.Location = new Point(195, 207);
            lblVerificarSocio.Name = "lblVerificarSocio";
            lblVerificarSocio.Size = new Size(38, 15);
            lblVerificarSocio.TabIndex = 7;
            lblVerificarSocio.Text = " ";
            // 
            // lblVerificarActividad
            // 
            lblVerificarActividad.AutoSize = true;
            lblVerificarActividad.Location = new Point(514, 207);
            lblVerificarActividad.Name = "lblVerificarActividad";
            lblVerificarActividad.Size = new Size(38, 15);
            lblVerificarActividad.TabIndex = 8;
            lblVerificarActividad.Text = " ";
            btnVerificarActividad.Click += btnVerificarActividad_Click;
            // 
            // btnVerificarNoSocio
            // 
            btnVerificarNoSocio.Location = new Point(103, 203);
            btnVerificarNoSocio.Name = "btnVerificarNoSocio";
            btnVerificarNoSocio.Size = new Size(75, 23);
            btnVerificarNoSocio.TabIndex = 9;
            btnVerificarNoSocio.Text = "Verificar";
            btnVerificarNoSocio.UseVisualStyleBackColor = true;
            btnVerificarNoSocio.Click += btnVerificarNoSocio_Click;
            // 
            // btnVerificarActividad
            // 
            btnVerificarActividad.Location = new Point(385, 203);
            btnVerificarActividad.Name = "btnVerificarActividad";
            btnVerificarActividad.Size = new Size(75, 23);
            btnVerificarActividad.TabIndex = 10;
            btnVerificarActividad.Text = "Verificar";
            btnVerificarActividad.UseVisualStyleBackColor = true;
            // 
            // frmActividadNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 607);
            Controls.Add(btnVerificarActividad);
            Controls.Add(btnVerificarNoSocio);
            Controls.Add(lblVerificarActividad);
            Controls.Add(lblVerificarSocio);
            Controls.Add(btnPagar);
            Controls.Add(btnVolver);
            Controls.Add(lblActividades);
            Controls.Add(txtIdActividad);
            Controls.Add(txtIdNoSocio);
            Controls.Add(lblCodigoActividad);
            Controls.Add(lblNoSocio);
            Name = "frmActividadNoSocio";
            Text = "No Socio -> Inscripción a Actividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoSocio;
        private Label lblCodigoActividad;
        private TextBox txtIdNoSocio;
        private TextBox txtIdActividad;
        private Label lblActividades;
        private Button btnVolver;
        private Button btnPagar;
        private Label lblVerificarSocio;
        private Label lblVerificarActividad;
        private Button btnVerificarNoSocio;
        private Button btnVerificarActividad;
    }
}