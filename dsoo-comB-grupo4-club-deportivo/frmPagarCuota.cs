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
using dsoo_comB_grupo4_club_deportivo.Entidades.Pagos;
using dsoo_comB_grupo4_club_deportivo.Entidades.Personas;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmPagarCuota : Form
    {
        internal string rol, usuario;
        public frmFacturaCuota docFactura = new frmFacturaCuota();
        public frmPagarCuota()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmPagarCuota_Load(object sender, EventArgs e)
        {
            btnComprobante.Enabled = false;
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            string tipoPago = "";

            // 1) intentamos parsear el id que se ingresa en el form
            // el resultado se almacena en idSocio
            if(!int.TryParse(txtSocio.Text, out int idSocio))
            {
                MessageBox.Show("Ingrese un número de ID válido.", "Aviso del sistema" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // si no se selecciona ningun tipo de pago, avisamos.
            if(!rbtEfectivo.Checked && !rbtTarjeta1.Checked && !rbtTarjeta3.Checked && !rbtTarjeta6.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de pago.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Almacenamos el tipo de pago
            if (rbtEfectivo.Checked)
            {
                tipoPago = "EFECTIVO";
            }
            if (rbtTarjeta1.Checked)
            {
                tipoPago = "TARJETA_1";
            }
            if (rbtTarjeta3.Checked)
            {
                tipoPago = "TARJETA_3";
            }
            if (rbtTarjeta6.Checked)
            {
                tipoPago = "TARJETA_6";
            }

            Pago servicioDePago = new Pago();
            PagoResultado resultado = servicioDePago.PagarCuota(idSocio, tipoPago);

            if (!resultado.Exito)
            {
                MessageBox.Show(resultado.Mensaje, "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var comprobante = resultado.ComprobanteCuota;
            MessageBox.Show("Pago exitoso!", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            // buscamos los datos del Socio para pasar al comprobante
            Socio herramientaSocio = new Socio();
            E_Socio socio = herramientaSocio.DatosDelSocio(idSocio);
            string nombreYAp = socio.Nombre + " " + socio.Apellido;
            
            // pasamos al documento imprimible todos los datos necesarios
            docFactura.nombreCompleto_c = nombreYAp;
            docFactura.idSocio_c = comprobante.IdSocio;
            docFactura.idPago_c = comprobante.IdPago;
            docFactura.nroCuota_c = comprobante.NroCuota;
            docFactura.monto_c = comprobante.Monto;
            docFactura.fechaVenc_c = comprobante.FechaVencimiento;
            docFactura.fechaPago_c = comprobante.FechaPago;
            docFactura.tipoPago_c = comprobante.TipoPago;

            btnComprobante.Enabled = true;
        }
        
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            docFactura.usuario = usuario;
            docFactura.rol = rol;
            docFactura.Show();
            this.Hide();
        }


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
