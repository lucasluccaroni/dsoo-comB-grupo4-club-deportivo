using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dsoo_comB_grupo4_club_deportivo.Datos;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmActividadNoSocio : Form
    {
        internal string usuario, rol;
        public frmActividadNoSocio()
        {
            InitializeComponent();
        }


        // boton para verificar que el socio exista
        private void btnVerificarNoSocio_Click(object sender, EventArgs e)
        {
            string idNoSocio = txtIdNoSocio.Text;
            NoSocio noSocio = new NoSocio();
            bool noSocioExiste = noSocio.VerificarNoSocio(idNoSocio);

            if (noSocioExiste)
            {
                lblVerificarSocio.Text = "Correcto.";
                lblVerificarSocio.ForeColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                lblVerificarSocio.Text = "No existe.";
                lblVerificarSocio.ForeColor = Color.FromArgb(255, 000, 0);
            }
        }

        // boton para verificar que la actividad exista
        private void btnVerificarActividad_Click(object sender, EventArgs e)
        {
            string idActividad = txtIdNoSocio.Text;
            Actividad actividad = new Actividad();
            bool actividadExisteTieneCupo = actividad.VerificarActividad(idActividad);
            System.Diagnostics.Debug.WriteLine("Actividad existe y con cupo => " + actividadExisteTieneCupo);

            if (actividadExisteTieneCupo)
            {
                lblVerificarActividad.Text = "Correcto.";
                lblVerificarActividad.ForeColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                lblVerificarActividad.Text = "No existe / no tiene cupo.";
                lblVerificarActividad.ForeColor = Color.FromArgb(255, 000, 0);
            }
        }

        // Boton para volver al formulario principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.rol = rol;
            principal.usuario = usuario;
            principal.Show();
            this.Hide();
        }
    }
}
