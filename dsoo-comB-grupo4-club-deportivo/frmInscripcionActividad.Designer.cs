namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmInscripcionActividad
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
            btnVerificarNoSocio = new Button();
            txtIdNoSocio = new TextBox();
            lblNoSocio = new Label();
            lblVerificarSocio = new Label();
            lblNombreAct = new Label();
            lblFechaAct = new Label();
            lblProfAct = new Label();
            lbl = new Label();
            lblNombre = new Label();
            lblFecha = new Label();
            lblProf = new Label();
            panel1 = new Panel();
            btnConfirmarInscripcion = new Button();
            btnPagar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 11);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(93, 33);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerificarNoSocio
            // 
            btnVerificarNoSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificarNoSocio.Location = new Point(39, 163);
            btnVerificarNoSocio.Name = "btnVerificarNoSocio";
            btnVerificarNoSocio.Size = new Size(75, 33);
            btnVerificarNoSocio.TabIndex = 12;
            btnVerificarNoSocio.Text = "Verificar";
            btnVerificarNoSocio.UseVisualStyleBackColor = true;
            btnVerificarNoSocio.Click += btnVerificarNoSocio_Click;
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.Font = new Font("Segoe UI", 11.25F);
            txtIdNoSocio.Location = new Point(39, 121);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.PlaceholderText = "Id NoSocio";
            txtIdNoSocio.Size = new Size(162, 27);
            txtIdNoSocio.TabIndex = 11;
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 11.25F);
            lblNoSocio.Location = new Point(39, 86);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(162, 20);
            lblNoSocio.TabIndex = 10;
            lblNoSocio.Text = "Ingrese ID del NoSocio";
            // 
            // lblVerificarSocio
            // 
            lblVerificarSocio.AutoSize = true;
            lblVerificarSocio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVerificarSocio.Location = new Point(120, 166);
            lblVerificarSocio.Name = "lblVerificarSocio";
            lblVerificarSocio.Size = new Size(13, 19);
            lblVerificarSocio.TabIndex = 13;
            lblVerificarSocio.Text = " ";
            // 
            // lblNombreAct
            // 
            lblNombreAct.AutoSize = true;
            lblNombreAct.Font = new Font("Segoe UI", 10.2F);
            lblNombreAct.Location = new Point(138, 22);
            lblNombreAct.Name = "lblNombreAct";
            lblNombreAct.Size = new Size(15, 19);
            lblNombreAct.TabIndex = 14;
            lblNombreAct.Text = "-";
            // 
            // lblFechaAct
            // 
            lblFechaAct.AutoSize = true;
            lblFechaAct.Font = new Font("Segoe UI", 10.2F);
            lblFechaAct.Location = new Point(138, 58);
            lblFechaAct.Name = "lblFechaAct";
            lblFechaAct.Size = new Size(15, 19);
            lblFechaAct.TabIndex = 15;
            lblFechaAct.Text = "-";
            // 
            // lblProfAct
            // 
            lblProfAct.AutoSize = true;
            lblProfAct.Font = new Font("Segoe UI", 10.2F);
            lblProfAct.Location = new Point(138, 96);
            lblProfAct.Name = "lblProfAct";
            lblProfAct.Size = new Size(15, 19);
            lblProfAct.TabIndex = 16;
            lblProfAct.Text = "-";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl.Location = new Point(354, 33);
            lbl.Name = "lbl";
            lbl.Size = new Size(94, 21);
            lbl.TabIndex = 17;
            lbl.Text = "Inscripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 15);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Actividad:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(50, 58);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 19;
            lblFecha.Text = "Fecha:";
            // 
            // lblProf
            // 
            lblProf.AutoSize = true;
            lblProf.Location = new Point(23, 96);
            lblProf.Name = "lblProf";
            lblProf.Size = new Size(65, 15);
            lblProf.TabIndex = 20;
            lblProf.Text = "Profesor/a:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lblNombreAct);
            panel1.Controls.Add(lblProf);
            panel1.Controls.Add(lblFechaAct);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblProfAct);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(304, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 145);
            panel1.TabIndex = 21;
            // 
            // btnConfirmarInscripcion
            // 
            btnConfirmarInscripcion.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirmarInscripcion.Font = new Font("Segoe UI", 11.25F);
            btnConfirmarInscripcion.ForeColor = SystemColors.ControlText;
            btnConfirmarInscripcion.Location = new Point(246, 262);
            btnConfirmarInscripcion.Margin = new Padding(3, 2, 3, 2);
            btnConfirmarInscripcion.Name = "btnConfirmarInscripcion";
            btnConfirmarInscripcion.Size = new Size(157, 48);
            btnConfirmarInscripcion.TabIndex = 22;
            btnConfirmarInscripcion.Text = "Confirmar";
            btnConfirmarInscripcion.UseVisualStyleBackColor = false;
            btnConfirmarInscripcion.Click += btnConfirmarInscripcion_Click;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 11.25F);
            btnPagar.Location = new Point(585, 280);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(91, 47);
            btnPagar.TabIndex = 23;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // frmInscripcionActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnPagar);
            Controls.Add(btnConfirmarInscripcion);
            Controls.Add(panel1);
            Controls.Add(lbl);
            Controls.Add(lblVerificarSocio);
            Controls.Add(btnVerificarNoSocio);
            Controls.Add(txtIdNoSocio);
            Controls.Add(lblNoSocio);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInscripcionActividad";
            Text = "Inscripcion a Actividad";
            Load += frmInscripcionActividad_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnVerificarNoSocio;
        private TextBox txtIdNoSocio;
        private Label lblNoSocio;
        private Label lblVerificarSocio;
        private Label lblNombreAct;
        private Label lblFechaAct;
        private Label lblProfAct;
        private Label lbl;
        private Label lblNombre;
        private Label lblFecha;
        private Label lblProf;
        private Panel panel1;
        private Button btnConfirmarInscripcion;
        private Button btnPagar;
    }
}