using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos.Comprobante
{
    public class ComprobantePagoActDTO
    {
        public int IdInscripcion { get; set; }
        public int IdPago { get; set; }
        public string Actividad { get; set; }
        public string NoSocio { get; set; }
        public DateTime FechaActividad { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
