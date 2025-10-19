namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmListadoSocios
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
            dtgvSocios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 32);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvSocios
            // 
            dtgvSocios.AllowUserToAddRows = false;
            dtgvSocios.AllowUserToDeleteRows = false;
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Location = new Point(74, 129);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.ReadOnly = true;
            dtgvSocios.Size = new Size(881, 319);
            dtgvSocios.TabIndex = 2;
            // 
            // frmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 610);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Name = "frmListadoSocios";
            Text = "frmListadoSocios";
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ResumeLayout(false);
            Load += frmListadoSocios_Load;
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvSocios;
    }
}