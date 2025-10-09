namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Evento de foco en txtUsuario -> Enter
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            string texto = txtUsuario.Text;
            if (texto == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        // Evento de foco en txtUsuario -> Leave
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string texto = txtUsuario.Text;
            if (texto == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        // Evento de foco en txtPass -> Enter
        private void txtPass_Enter(object sender, EventArgs e)
        {
            string texto = txtPass.Text;
            if (texto == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }


        // Evento de foco en txtPass -> Leave
        private void txtPass_Leave(object sender, EventArgs e)
        {
            string texto = txtPass.Text;
            if (texto == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
