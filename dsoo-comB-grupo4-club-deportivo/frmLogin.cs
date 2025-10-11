using System.Data;

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

        // Boton para ver / ocultar contraseña
        private void btnHashPass_Click(object sender, EventArgs e)
        {
            if(txtPass.Text != "Contraseña")
            {
                if (txtPass.UseSystemPasswordChar)
                {
                    txtPass.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPass.UseSystemPasswordChar = true;
                }
            }
        }

        // Boton ingresar + login
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase Usuarios

            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if(tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario existe
                MessageBox.Show("Ingreso exitoso", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ahora tenemos la conexion establecida y pasamos a mostrar el form principal
                frmPrincipal Principal = new frmPrincipal();
                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show(); // llamamos al form principal
                this.Hide(); // escondemos el form de login (este form)
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
