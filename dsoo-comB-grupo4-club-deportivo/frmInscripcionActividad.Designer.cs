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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(21, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerificarNoSocio
            // 
            btnVerificarNoSocio.Location = new Point(45, 217);
            btnVerificarNoSocio.Margin = new Padding(3, 4, 3, 4);
            btnVerificarNoSocio.Name = "btnVerificarNoSocio";
            btnVerificarNoSocio.Size = new Size(86, 31);
            btnVerificarNoSocio.TabIndex = 12;
            btnVerificarNoSocio.Text = "Verificar";
            btnVerificarNoSocio.UseVisualStyleBackColor = true;
            btnVerificarNoSocio.Click += btnVerificarNoSocio_Click;
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.Font = new Font("Segoe UI", 11.25F);
            txtIdNoSocio.Location = new Point(45, 161);
            txtIdNoSocio.Margin = new Padding(3, 4, 3, 4);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.PlaceholderText = "Id NoSocio";
            txtIdNoSocio.Size = new Size(185, 32);
            txtIdNoSocio.TabIndex = 11;
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 11.25F);
            lblNoSocio.Location = new Point(45, 114);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(204, 25);
            lblNoSocio.TabIndex = 10;
            lblNoSocio.Text = "Ingrese ID del NoSocio";
            // 
            // lblVerificarSocio
            // 
            lblVerificarSocio.AutoSize = true;
            lblVerificarSocio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVerificarSocio.Location = new Point(137, 222);
            lblVerificarSocio.Name = "lblVerificarSocio";
            lblVerificarSocio.Size = new Size(15, 23);
            lblVerificarSocio.TabIndex = 13;
            lblVerificarSocio.Text = " ";
            // 
            // lblNombreAct
            // 
            lblNombreAct.AutoSize = true;
            lblNombreAct.Font = new Font("Segoe UI", 10.2F);
            lblNombreAct.Location = new Point(158, 30);
            lblNombreAct.Name = "lblNombreAct";
            lblNombreAct.Size = new Size(17, 23);
            lblNombreAct.TabIndex = 14;
            lblNombreAct.Text = "-";
            // 
            // lblFechaAct
            // 
            lblFechaAct.AutoSize = true;
            lblFechaAct.Font = new Font("Segoe UI", 10.2F);
            lblFechaAct.Location = new Point(158, 78);
            lblFechaAct.Name = "lblFechaAct";
            lblFechaAct.Size = new Size(17, 23);
            lblFechaAct.TabIndex = 15;
            lblFechaAct.Text = "-";
            // 
            // lblProfAct
            // 
            lblProfAct.AutoSize = true;
            lblProfAct.Font = new Font("Segoe UI", 10.2F);
            lblProfAct.Location = new Point(158, 128);
            lblProfAct.Name = "lblProfAct";
            lblProfAct.Size = new Size(17, 23);
            lblProfAct.TabIndex = 16;
            lblProfAct.Text = "-";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl.Location = new Point(405, 44);
            lbl.Name = "lbl";
            lbl.Size = new Size(115, 28);
            lbl.TabIndex = 17;
            lbl.Text = "Inscripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 20);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Actividad:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(57, 78);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 19;
            lblFecha.Text = "Fecha:";
            // 
            // lblProf
            // 
            lblProf.AutoSize = true;
            lblProf.Location = new Point(26, 128);
            lblProf.Name = "lblProf";
            lblProf.Size = new Size(81, 20);
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
            panel1.Location = new Point(348, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 193);
            panel1.TabIndex = 21;
            // 
            // btnConfirmarInscripcion
            // 
            btnConfirmarInscripcion.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirmarInscripcion.ForeColor = SystemColors.ControlText;
            btnConfirmarInscripcion.Location = new Point(281, 350);
            btnConfirmarInscripcion.Name = "btnConfirmarInscripcion";
            btnConfirmarInscripcion.Size = new Size(174, 55);
            btnConfirmarInscripcion.TabIndex = 22;
            btnConfirmarInscripcion.Text = "Confirmar";
            btnConfirmarInscripcion.UseVisualStyleBackColor = false;
            // 
            // frmInscripcionActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmarInscripcion);
            Controls.Add(panel1);
            Controls.Add(lbl);
            Controls.Add(lblVerificarSocio);
            Controls.Add(btnVerificarNoSocio);
            Controls.Add(txtIdNoSocio);
            Controls.Add(lblNoSocio);
            Controls.Add(btnVolver);
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
    }
}