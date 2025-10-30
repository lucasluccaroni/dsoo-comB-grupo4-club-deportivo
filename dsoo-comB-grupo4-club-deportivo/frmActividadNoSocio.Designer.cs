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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblNoSocio = new Label();
            txtIdNoSocio = new TextBox();
            btnVolver = new Button();
            btnPagar = new Button();
            lblVerificarSocio = new Label();
            btnVerificarNoSocio = new Button();
            dtgvActividad = new DataGridView();
            NombreAct = new DataGridViewTextBoxColumn();
            FechaAct = new DataGridViewTextBoxColumn();
            NombreProf = new DataGridViewTextBoxColumn();
            PrecioAct = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            SuspendLayout();
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI", 11.25F);
            lblNoSocio.Location = new Point(12, 91);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(162, 20);
            lblNoSocio.TabIndex = 0;
            lblNoSocio.Text = "Ingrese ID del NoSocio";
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.Font = new Font("Segoe UI", 11.25F);
            txtIdNoSocio.Location = new Point(12, 126);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.Size = new Size(162, 27);
            txtIdNoSocio.TabIndex = 2;
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
            btnPagar.Location = new Point(896, 592);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(106, 43);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // lblVerificarSocio
            // 
            lblVerificarSocio.AutoSize = true;
            lblVerificarSocio.Location = new Point(104, 172);
            lblVerificarSocio.Name = "lblVerificarSocio";
            lblVerificarSocio.Size = new Size(10, 15);
            lblVerificarSocio.TabIndex = 7;
            lblVerificarSocio.Text = " ";
            // 
            // btnVerificarNoSocio
            // 
            btnVerificarNoSocio.Location = new Point(12, 168);
            btnVerificarNoSocio.Name = "btnVerificarNoSocio";
            btnVerificarNoSocio.Size = new Size(75, 23);
            btnVerificarNoSocio.TabIndex = 9;
            btnVerificarNoSocio.Text = "Verificar";
            btnVerificarNoSocio.UseVisualStyleBackColor = true;
            btnVerificarNoSocio.Click += btnVerificarNoSocio_Click;
            // 
            // dtgvActividad
            // 
            dtgvActividad.AllowUserToAddRows = false;
            dtgvActividad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvActividad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgvActividad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvActividad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Columns.AddRange(new DataGridViewColumn[] { NombreAct, FechaAct, NombreProf, PrecioAct });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvActividad.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvActividad.Location = new Point(129, 224);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.Size = new Size(818, 156);
            dtgvActividad.TabIndex = 10;
            // 
            // NombreAct
            // 
            NombreAct.HeaderText = "ACTIVIDAD";
            NombreAct.Name = "NombreAct";
            NombreAct.ReadOnly = true;
            NombreAct.Width = 110;
            // 
            // FechaAct
            // 
            FechaAct.HeaderText = "FECHA";
            FechaAct.Name = "FechaAct";
            FechaAct.ReadOnly = true;
            FechaAct.Width = 79;
            // 
            // NombreProf
            // 
            NombreProf.HeaderText = "PROFESOR";
            NombreProf.Name = "NombreProf";
            NombreProf.ReadOnly = true;
            NombreProf.Width = 105;
            // 
            // PrecioAct
            // 
            PrecioAct.HeaderText = "PRECIO";
            PrecioAct.Name = "PrecioAct";
            PrecioAct.ReadOnly = true;
            PrecioAct.Width = 83;
            // 
            // frmActividadNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 647);
            Controls.Add(dtgvActividad);
            Controls.Add(btnVerificarNoSocio);
            Controls.Add(lblVerificarSocio);
            Controls.Add(btnPagar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdNoSocio);
            Controls.Add(lblNoSocio);
            Name = "frmActividadNoSocio";
            Text = "No Socio -> Inscripción a Actividad";
            Load += frmActividadNoSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoSocio;
        private TextBox txtIdNoSocio;
        private Button btnVolver;
        private Button btnPagar;
        private Label lblVerificarSocio;
        private Button btnVerificarNoSocio;
        private DataGridView dtgvActividad;
        private DataGridViewTextBoxColumn NombreAct;
        private DataGridViewTextBoxColumn FechaAct;
        private DataGridViewTextBoxColumn NombreProf;
        private DataGridViewTextBoxColumn PrecioAct;
    }
}