using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmFacturaActividad : Form
    {
        internal string usuario, rol;
        public frmFacturaActividad()
        {
            InitializeComponent();
        }

        // Variables para traer los datos del formulario donde se ejecuta la lógica
        public int? nroInscrip_f;
        public string? actividad_f;
        public string? nombreNoSocio_f;
        public float? monto_f;
        public DateTime? fechaAct_f;
        public DateTime? fechaPago_f;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Ocultamos los botones que no van a salir en la impresion
            btnImprimir.Visible = false;

            // Creamos los objetos para la impresion
            PrintDocument pdf = new PrintDocument();
            pdf.PrintPage += new PrintPageEventHandler(ImprimirFactura);
            pdf.Print();

            // cuando temrmina la impresion visualisamos nuevamente los botones que escondimos
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

        private void frmFacturaActividad_Load(object sender, EventArgs e)
        {
            // Asignacion de los valores a los datos que muestra cada etiqueta de diseño
            lblActividad.Text = actividad_f;
            lblNoSocio.Text = nombreNoSocio_f;
            lblFecha.Text = Convert.ToString(fechaAct_f);
            lblPrecio.Text = Convert.ToString(monto_f);
            lblFechaPago.Text = DateTime.UtcNow.ToShortDateString();
        }
    }
}
