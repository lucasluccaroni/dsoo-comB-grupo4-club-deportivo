namespace dsoo_comB_grupo4_club_deportivo
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
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(69, 116);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(189, 189);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(335, 73);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(210, 41);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Iniciar sesión";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(303, 172);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(244, 32);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(303, 247);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(244, 32);
            txtPass.TabIndex = 3;
            txtPass.Text = "Contraseña";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnHashPass
            // 
            btnHashPass.BackgroundImage = (Image)resources.GetObject("btnHashPass.BackgroundImage");
            btnHashPass.BackgroundImageLayout = ImageLayout.Zoom;
            btnHashPass.Location = new Point(553, 247);
            btnHashPass.Margin = new Padding(3, 4, 3, 4);
            btnHashPass.Name = "btnHashPass";
            btnHashPass.Size = new Size(37, 32);
            btnHashPass.TabIndex = 4;
            btnHashPass.UseVisualStyleBackColor = true;
            btnHashPass.Click += btnHashPass_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(462, 340);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(99, 43);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 492);
            Controls.Add(btnIngresar);
            Controls.Add(btnHashPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblLogin);
            Controls.Add(picLogo);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnIngresar;
    }
}
