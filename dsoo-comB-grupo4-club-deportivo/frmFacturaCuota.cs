using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmFacturaCuota : Form
    {
        internal string rol, usuario;
        public frmFacturaCuota()
        {
            InitializeComponent();
        }

        public int? idSocio_c;
        public int? idPago_c;
        public int? nroCuota_c;
        public float? monto_c;
        public DateTime? fechaVenc_c;
        public DateTime? fechaPago_c;
        public string? tipoPago_c;
        public string? nombreCompleto_c;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Ocultamos los botones que no van a salir en la impresion
            btnImprimir.Visible = false;

            // Creamos los objetos para la impresion
            PrintDocument pdf = new PrintDocument();
            pdf.PrintPage += new PrintPageEventHandler(ImprimirFactura);
            pdf.Print();

            // cuando temrmina la impresion visualizamos nuevamente los botones que escondimos
            btnImprimir.Visible = true;

            // regresamos al form principal despues de dar aviso
            MessageBox.Show("Operacion exitosa.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.usuario = usuario;
            principal.rol = rol;
            this.Close();
            principal.Show();
        }

        private void ImprimirFactura(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void frmFacturaCuota_Load(object sender, EventArgs e)
        {

            string fechaPagoParse = fechaPago_c.Value.ToString("dd/MM/yyyy");
            string fechaVencParse = fechaVenc_c.Value.ToString("dd/MM/yyyy");

            lblSocioId.Text = Convert.ToString(idSocio_c);
            lblPagoId.Text = Convert.ToString(idPago_c);
            lblNroCuota.Text = Convert.ToString(nroCuota_c);
            lblFechaHoy.Text = fechaPagoParse;
            lblFechaVenc.Text = fechaVencParse;
            lblMonto.Text = Convert.ToString(monto_c);
            lblTipoPago.Text = tipoPago_c;
            lblNombreCompleto.Text = nombreCompleto_c;
        }

        private void lblNombreCompleto_Click(object sender, EventArgs e)
        {

        }
    }

}
