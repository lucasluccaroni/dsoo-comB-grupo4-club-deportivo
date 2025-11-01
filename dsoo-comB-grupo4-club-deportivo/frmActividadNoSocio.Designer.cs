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
            btnVolver = new Button();
            dtgvActividad = new DataGridView();
            IdEdicion = new DataGridViewTextBoxColumn();
            NombreAct = new DataGridViewTextBoxColumn();
            FechaAct = new DataGridViewTextBoxColumn();
            NombreProf = new DataGridViewTextBoxColumn();
            PrecioAct = new DataGridViewTextBoxColumn();
            CuposDispAct = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(14, 16);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 47);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
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
            dtgvActividad.Columns.AddRange(new DataGridViewColumn[] { IdEdicion, NombreAct, FechaAct, NombreProf, PrecioAct, CuposDispAct });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvActividad.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvActividad.Location = new Point(35, 120);
            dtgvActividad.Margin = new Padding(3, 4, 3, 4);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowHeadersWidth = 51;
            dtgvActividad.Size = new Size(1123, 454);
            dtgvActividad.TabIndex = 10;
            dtgvActividad.CellClick += dtgvActividad_CellClick;
            // 
            // IdEdicion
            // 
            IdEdicion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdEdicion.HeaderText = "ID-EDICION";
            IdEdicion.MinimumWidth = 6;
            IdEdicion.Name = "IdEdicion";
            IdEdicion.ReadOnly = true;
            IdEdicion.Resizable = DataGridViewTriState.True;
            IdEdicion.Width = 140;
            // 
            // NombreAct
            // 
            NombreAct.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NombreAct.HeaderText = "ACTIVIDAD";
            NombreAct.MinimumWidth = 6;
            NombreAct.Name = "NombreAct";
            NombreAct.ReadOnly = true;
            NombreAct.Width = 135;
            // 
            // FechaAct
            // 
            FechaAct.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FechaAct.HeaderText = "FECHA";
            FechaAct.MinimumWidth = 6;
            FechaAct.Name = "FechaAct";
            FechaAct.ReadOnly = true;
            FechaAct.Width = 97;
            // 
            // NombreProf
            // 
            NombreProf.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NombreProf.HeaderText = "PROFESOR";
            NombreProf.MinimumWidth = 6;
            NombreProf.Name = "NombreProf";
            NombreProf.ReadOnly = true;
            NombreProf.Width = 131;
            // 
            // PrecioAct
            // 
            PrecioAct.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PrecioAct.HeaderText = "PRECIO";
            PrecioAct.MinimumWidth = 6;
            PrecioAct.Name = "PrecioAct";
            PrecioAct.ReadOnly = true;
            PrecioAct.Width = 104;
            // 
            // CuposDispAct
            // 
            CuposDispAct.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CuposDispAct.HeaderText = "CUPOS DISPONIBLES";
            CuposDispAct.MinimumWidth = 6;
            CuposDispAct.Name = "CuposDispAct";
            CuposDispAct.ReadOnly = true;
            CuposDispAct.Width = 199;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(506, 64);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 11;
            label1.Text = "Actividades";
            // 
            // frmActividadNoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 625);
            Controls.Add(label1);
            Controls.Add(dtgvActividad);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmActividadNoSocio";
            Text = "No Socio -> Inscripción a Actividad";
            Load += frmActividadNoSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private DataGridView dtgvActividad;
        private DataGridViewTextBoxColumn IdEdicion;
        private DataGridViewTextBoxColumn NombreAct;
        private DataGridViewTextBoxColumn FechaAct;
        private DataGridViewTextBoxColumn NombreProf;
        private DataGridViewTextBoxColumn PrecioAct;
        private DataGridViewTextBoxColumn CuposDispAct;
        private Label label1;
    }
}