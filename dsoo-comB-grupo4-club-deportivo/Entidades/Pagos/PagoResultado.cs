using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsoo_comB_grupo4_club_deportivo.Entidades.Pagos.Comprobante;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos
{
    public class PagoResultado
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public ComprobantePagoActDTO Comprobante { get; set; }
    }
}
