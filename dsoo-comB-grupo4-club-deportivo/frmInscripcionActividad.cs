using dsoo_comB_grupo4_club_deportivo.Datos;
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
    public partial class frmInscripcionActividad : Form
    {
        internal string
            rol,
            usuario,
            nombreActividad,
            fechaActividad,
            profesor;
        internal int idEdicion, idNoSocio;

        public frmInscripcionActividad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmInscripcionActividad_Load(object sender, EventArgs e)
        {
            lblNombreAct.Text = nombreActividad;
            lblFechaAct.Text = fechaActividad;
            lblProfAct.Text = profesor;

        }

        // boton para verificar que el socio exista
        private void btnVerificarNoSocio_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdNoSocio.Text);
            NoSocio noSocio = new NoSocio();
            bool noSocioExiste = noSocio.VerificarNoSocio(id);

            if (noSocioExiste)
            {
                lblVerificarSocio.Text = "Correcto.";
                lblVerificarSocio.ForeColor = Color.FromArgb(0, 128, 0);
                idNoSocio = id;

            }
            else
            {
                lblVerificarSocio.Text = "No se encontró.";
                lblVerificarSocio.ForeColor = Color.FromArgb(255, 000, 0);
            }
        }

        // Boton para volver al formulario de grilla de actividades
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmActividadNoSocio actividadNoSocio = new frmActividadNoSocio();
            actividadNoSocio.rol = rol;
            actividadNoSocio.usuario = usuario;
            actividadNoSocio.Show();
            this.Hide();
        }

        private void btnConfirmarInscripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
