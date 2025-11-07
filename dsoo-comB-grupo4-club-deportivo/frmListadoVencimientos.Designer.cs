namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmListadoVencimientos
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
            btnImprimir = new Button();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Azure;
            btnImprimir.Location = new Point(117, 24);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(119, 55);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmListadoVencimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(365, 107);
            Controls.Add(btnImprimir);
            Name = "frmListadoVencimientos";
            Text = "Listado generado";
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
    }
}