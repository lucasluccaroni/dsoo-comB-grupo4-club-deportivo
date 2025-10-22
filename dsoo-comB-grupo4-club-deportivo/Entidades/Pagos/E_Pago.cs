using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos
{
    public class E_Pago
    {
        public int? IdPago { get; set; }
        public int? Monto { get; set; }
        public DateOnly? FechaPago { get; set; }

        public E_Pago(int idPago, int monto, DateOnly fechaPago)
        {
            IdPago = idPago;
            Monto = monto;
            FechaPago = fechaPago;
        }
    }
}
