using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmPrincipal : Form
    {
        internal string? rol, usuario;

        public frmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        // el frmLogin le pasa el usuario + rol de la persona que se logueó al sistema
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string usuarioGuardado = usuario;
            string rolGuardado = rol;
            timer1.Start();
            lblUsuario.Text = "Usuario: " + usuarioGuardado;
            lblRol.Text = "Rol: " + rolGuardado;
        }


        // timer para actualizar la hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionSocio inscripcionSocio = new frmInscripcionSocio();
            inscripcionSocio.rol = rol;
            inscripcionSocio.usuario = usuario;
            inscripcionSocio.Show();
            this.Hide();
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionNoSocio inscripcionNoSocio = new frmInscripcionNoSocio();
            inscripcionNoSocio.rol = rol;
            inscripcionNoSocio.usuario = usuario;
            inscripcionNoSocio.Show();
            this.Hide();
        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            frmListadoSocios listadoSocios = new frmListadoSocios();
            listadoSocios.usuario = usuario;
            listadoSocios.rol = rol;
            listadoSocios.Show();
            this.Hide();
        }

        private void btnListarNoSocios_Click(object sender, EventArgs e)
        {
            frmListadoNoSocios listadoNoSocios = new frmListadoNoSocios();
            listadoNoSocios.usuario = usuario;
            listadoNoSocios.rol = rol;
            listadoNoSocios.Show();
            this.Hide();
        }

        // boton para "cerrar sesion" o salir del sistema
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
