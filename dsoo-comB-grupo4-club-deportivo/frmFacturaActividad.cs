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
    public partial class frmFacturaActividad : Form
    {
        public frmFacturaActividad()
        {
            InitializeComponent();
        }

        // Variables para traer los datos del formulario donde se ejecuta la lógica
        public string? nombreNoSocio_f;
        public string? actividad_f;
        public float? monto_f;
        public int? idInscrip_f;
        public DateTime? fecha_f;



    }
}
