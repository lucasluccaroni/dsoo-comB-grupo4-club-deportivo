using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using dsoo_comB_grupo4_club_deportivo.Datos;
using dsoo_comB_grupo4_club_deportivo.Entidades.Pagos;


namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmPagarActividad : Form
    {
        internal string rol, usuario;
        public frmFacturaActividad docFactura = new frmFacturaActividad();

        public frmPagarActividad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmPagarActividad_Load(object sender , EventArgs e)
        {
            btnComprobante.Enabled = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // 1) intentamos parsear el id que se ingresa en el formulario.
            // El resultado se almacena en "idInscripcion"
            if (!int.TryParse(txtInscripcion.Text, out int idInscripcion))
            {
                MessageBox.Show("Ingrese un número de inscripción válido.");
                return;
            }

            Pago servicioDePago = new Pago();
            PagoResultado resultado = servicioDePago.PagarActividad(idInscripcion);

            if (!resultado.Exito)
            {
                MessageBox.Show(resultado.Mensaje, "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var comprobante = resultado.Comprobante;
            MessageBox.Show("Pago exitoso!", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            docFactura.nroInscrip_f = comprobante.IdInscripcion;
            docFactura.actividad_f = comprobante.Actividad;
            docFactura.nombreNoSocio_f = comprobante.NoSocio;
            docFactura.monto_f = comprobante.Precio;
            docFactura.fechaAct_f = comprobante.FechaActividad;
            docFactura.fechaPago_f = comprobante.FechaPago;
            
            btnComprobante.Enabled = true;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            docFactura.usuario = usuario;
            docFactura.rol = rol;
            docFactura.Show();
            this.Hide();
        }


        // Boton para volver al formlario de las actividades disponibles
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.usuario = usuario;
            principal.rol = rol;
            principal.Show();
            this.Hide();
        }
    }
}
