namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmPagarActividad
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
            label1 = new Label();
            txtInscripcion = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(24, 27);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 75);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingrese número de inscripción";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInscripcion.Location = new Point(242, 115);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.PlaceholderText = "Número de inscripción";
            txtInscripcion.Size = new Size(238, 34);
            txtInscripcion.TabIndex = 2;
            txtInscripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(242, 237);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(249, 51);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComprobante.Location = new Point(242, 341);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(249, 51);
            btnComprobante.TabIndex = 4;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // frmPagarActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Name = "frmPagarActividad";
            Text = "Pagar una actividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private TextBox txtInscripcion;
        private Button btnPagar;
        private Button btnComprobante;
    }
}