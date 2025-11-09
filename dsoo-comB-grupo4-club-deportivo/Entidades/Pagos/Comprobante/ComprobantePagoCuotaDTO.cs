using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos.Comprobante
{
    public
        class ComprobantePagoCuotaDTO
    {
        public int IdSocio { get; set; }
        public int IdPago { get; set; }
        public int NroCuota { get; set; }
        public float Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public string TipoPago { get; set; }
    }
}
