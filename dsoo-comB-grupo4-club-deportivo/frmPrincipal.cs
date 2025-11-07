using dsoo_comB_grupo4_club_deportivo.Datos;
using dsoo_comB_grupo4_club_deportivo.Entidades.Personas;
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


        // boton para registrar un nuevo socio
        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionSocio inscripcionSocio = new frmInscripcionSocio();
            inscripcionSocio.rol = rol;
            inscripcionSocio.usuario = usuario;
            inscripcionSocio.Show();
            this.Hide();
        }


        // boton para registrar un nuevo no socio
        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionNoSocio inscripcionNoSocio = new frmInscripcionNoSocio();
            inscripcionNoSocio.rol = rol;
            inscripcionNoSocio.usuario = usuario;
            inscripcionNoSocio.Show();
            this.Hide();
        }


        // boton para listar socios
        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            frmListadoSocios listadoSocios = new frmListadoSocios();
            listadoSocios.usuario = usuario;
            listadoSocios.rol = rol;
            listadoSocios.Show();
            this.Hide();
        }


        // boton para listar No Socios
        private void btnListarNoSocios_Click(object sender, EventArgs e)
        {
            frmListadoNoSocios listadoNoSocios = new frmListadoNoSocios();
            listadoNoSocios.usuario = usuario;
            listadoNoSocios.rol = rol;
            listadoNoSocios.Show();
            this.Hide();
        }


        // boton para inscribir un noSocio a una actividad
        private void btnInscribirActividadNoSocio_Click(object sender, EventArgs e)
        {
            frmActividadNoSocio actividadNoSocio = new frmActividadNoSocio();
            actividadNoSocio.rol = rol;
            actividadNoSocio.usuario = usuario;
            actividadNoSocio.Show();
            this.Hide();
        }


        // boton para ir al formulario de pagar una actividad
        private void btnPagarActividad_Click(object sender, EventArgs e)
        {
            frmPagarActividad pagarAct = new frmPagarActividad();
            pagarAct.rol = rol;
            pagarAct.usuario = usuario;
            pagarAct.Show();
            this.Hide();
        }


        // Boton para mandar la impresion del listado de socios que vencen hoy
        private void btnListadoVencimiento_Click(object sender, EventArgs e)
        {
            Socio herramientasSocio = new Socio();
            List<E_Socio> vencenHoy = herramientasSocio.ListaSociosVencenHoy();
            if (vencenHoy.Count > 0)
            {
                frmListadoVencimientos impresionVencidos = new frmListadoVencimientos(vencenHoy);
                impresionVencidos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay socios que vencen hoy.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        // boton para "cerrar sesion" o salir del sistema
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
