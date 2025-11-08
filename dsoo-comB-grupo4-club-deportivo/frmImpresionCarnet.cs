using dsoo_comB_grupo4_club_deportivo.Datos;
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
    public partial class frmImpresionCarnet : Form
    {

        internal string usuario, rol;
        public frmImpresionCarnet()
        {
            InitializeComponent();
        }

        // Variables para traer los datos del formulario anterior, donde se ejecutó la lógica
        public int? idSocio_c;
        public string?
            nombreSocio_c,
            apellidoSocio_c,
            dniSocio_c;
        public DateTime?
            fechaInscip_c,
            fechaVenc_c;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // ocultamos los botones que no van a salir en la impresion
            btnImprimir.Visible = false;
            btnVolver.Visible = false;

            // creamos los objetos para la impresion
            PrintDocument pdf = new PrintDocument();
            pdf.PrintPage += new PrintPageEventHandler(ImprimirCarnet);
            pdf.Print();

            // cuando termina la impresion visualizamos nuevamente los botones escondidos
            btnImprimir.Visible = true;
            btnVolver.Visible = true;

            // regresamos al form principal despues de dar aviso
            MessageBox.Show("Operación exitosa.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.usuario = usuario;
            principal.rol = rol;
            this.Close();
            principal.Show();
        }

        private void ImprimirCarnet(object o, PrintPageEventArgs e)
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

        private void frmImpresionCarnet_Load(object sender, EventArgs e)
        {
            string fechaInscripParse = fechaInscip_c.Value.ToString("dd/MM/yyyy");
            string fechaVencParse = fechaVenc_c.Value.ToString("dd/MM/yyyy");

            // Asignacion de los valores a los datos que muestra cada etiqueta de diseño
            lblId.Text = Convert.ToString(idSocio_c);
            lblNombre.Text = nombreSocio_c + " " + apellidoSocio_c;
            lblDni.Text = dniSocio_c;
            lblFechaInscrip.Text = fechaInscripParse;
            lblFechaVenc.Text = fechaVencParse;
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
