using dsoo_comB_grupo4_club_deportivo.Datos;
using dsoo_comB_grupo4_club_deportivo.Entidades.Personas;
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
    public partial class frmListadoVencimientos : Form
    {
        private List<E_Socio> sociosVencidos;
        public frmListadoVencimientos(List<E_Socio> socios)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            sociosVencidos = socios;
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pdf = new PrintDocument();
            pdf.PrintPage += new PrintPageEventHandler(ImprimirListado);
            pdf.Print();
            MessageBox.Show("Operacion exitosa.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ImprimirListado(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 10);
            float y = e.MarginBounds.Top;
            float x = e.MarginBounds.Left;

            // Encabezado
            e.Graphics.DrawString("Listado de Socios que vencen hoy",
                new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
            y += 40;

            // Columnas
            e.Graphics.DrawString("ID", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString("Nombre", fuente, Brushes.Black, x + 50, y);
            e.Graphics.DrawString("Apellido", fuente, Brushes.Black, x + 200, y);
            e.Graphics.DrawString("DNI", fuente, Brushes.Black, x + 350, y);
            e.Graphics.DrawString("Vencimiento", fuente, Brushes.Black, x + 450, y);
            y += 30;

            // Filas dinámicas
            foreach (var socio in sociosVencidos)
            {
                e.Graphics.DrawString(socio.Id_Socio.ToString(), fuente, Brushes.Black, x, y);
                e.Graphics.DrawString(socio.Nombre, fuente, Brushes.Black, x + 50, y);
                e.Graphics.DrawString(socio.Apellido, fuente, Brushes.Black, x + 200, y);
                e.Graphics.DrawString(socio.Dni, fuente, Brushes.Black, x + 350, y);
                e.Graphics.DrawString(socio.FechaVencimiento.ToShortDateString(), fuente, Brushes.Black, x + 450, y);

                y += 20;

                // Si se pasa del margen, cortar página
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }
    }
}
