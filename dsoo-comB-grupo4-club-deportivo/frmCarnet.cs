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
    public partial class frmCarnet : Form
    {
        internal string
            usuario,
            rol;
        internal int idSocio;
        public frmImpresionCarnet carnet = new frmImpresionCarnet();

        public frmCarnet()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
        }

        // Boton para verificar que el socio exista y esté activo
        private void btnVerificarSocio_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdSocio.Text);
            Socio herramientasSocio = new Socio();
            bool socioExiste = herramientasSocio.VerificarSocio(id);

            if (socioExiste)
            {
                lblVerificarSocio.Text = "Correcto.";
                lblVerificarSocio.ForeColor = Color.FromArgb(0, 128, 0);
                idSocio = id;
                btnSiguiente.Enabled = true;
            }
            else
            {
                lblVerificarSocio.Text = "No se encontró.";
                lblVerificarSocio.ForeColor = Color.FromArgb(255, 000, 0);
                idSocio = 0;
                btnSiguiente.Enabled = false;
            }
        }

        // Boton para generar el carnet con la informacion del socio
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(idSocio);
            if (idSocio != 0)
            {
                Socio herramientasSocio = new Socio();
                E_Socio socio = herramientasSocio.DatosDelSocio(idSocio);
                carnet.idSocio_c = socio.Id_Socio;
                carnet.nombreSocio_c = socio.Nombre;
                carnet.apellidoSocio_c = socio.Apellido;
                carnet.dniSocio_c = socio.Dni;
                carnet.fechaInscip_c = socio.FechaInscripcion;
                carnet.fechaVenc_c = socio.FechaVencimiento;
                carnet.usuario = usuario;
                carnet.rol = rol;
                carnet.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe proporionar un Socio válido.", "Aviso del sistema - Error en ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Boton para volver al form principal
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
