﻿namespace dsoo_comB_grupo4_club_deportivo
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            picLogo = new PictureBox();
            lblLogin = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnHashPass = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(60, 80);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(166, 162);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(293, 55);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(167, 32);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Iniciar sesión";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(265, 129);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(265, 185);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(214, 27);
            txtPass.TabIndex = 3;
            txtPass.Text = "Contraseña";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnHashPass
            // 
            btnHashPass.BackgroundImage = (Image)resources.GetObject("btnHashPass.BackgroundImage");
            btnHashPass.BackgroundImageLayout = ImageLayout.Zoom;
            btnHashPass.Location = new Point(485, 185);
            btnHashPass.Name = "btnHashPass";
            btnHashPass.Size = new Size(36, 28);
            btnHashPass.TabIndex = 4;
            btnHashPass.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(404, 259);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 369);
            Controls.Add(button2);
            Controls.Add(btnHashPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblLogin);
            Controls.Add(picLogo);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblLogin;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnHashPass;
        private Button button2;
    }
}
