namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmCarnet
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
            components = new System.ComponentModel.Container();
            btnVolver = new Button();
            lblBusqueda = new Label();
            txtIdSocio = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnVerificarSocio = new Button();
            lblVerificarSocio = new Label();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(93, 33);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBusqueda.Location = new Point(65, 98);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(142, 20);
            lblBusqueda.TabIndex = 1;
            lblBusqueda.Text = "Ingrese ID del Socio";
            // 
            // txtIdSocio
            // 
            txtIdSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdSocio.Location = new Point(65, 132);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.PlaceholderText = "Id Socio";
            txtIdSocio.Size = new Size(142, 27);
            txtIdSocio.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnVerificarSocio
            // 
            btnVerificarSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificarSocio.Location = new Point(65, 180);
            btnVerificarSocio.Name = "btnVerificarSocio";
            btnVerificarSocio.Size = new Size(75, 33);
            btnVerificarSocio.TabIndex = 4;
            btnVerificarSocio.Text = "Verificar";
            btnVerificarSocio.UseVisualStyleBackColor = true;
            btnVerificarSocio.Click += btnVerificarSocio_Click;
            // 
            // lblVerificarSocio
            // 
            lblVerificarSocio.AutoSize = true;
            lblVerificarSocio.Location = new Point(154, 187);
            lblVerificarSocio.Name = "lblVerificarSocio";
            lblVerificarSocio.Size = new Size(0, 15);
            lblVerificarSocio.TabIndex = 5;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(300, 152);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(97, 50);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 335);
            Controls.Add(btnSiguiente);
            Controls.Add(lblVerificarSocio);
            Controls.Add(btnVerificarSocio);
            Controls.Add(txtIdSocio);
            Controls.Add(lblBusqueda);
            Controls.Add(btnVolver);
            Name = "frmCarnet";
            Text = "Busqueda de Socio";
            Load += frmCarnet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblBusqueda;
        private TextBox txtIdSocio;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnVerificarSocio;
        private Label lblVerificarSocio;
        private Button btnSiguiente;
    }
}