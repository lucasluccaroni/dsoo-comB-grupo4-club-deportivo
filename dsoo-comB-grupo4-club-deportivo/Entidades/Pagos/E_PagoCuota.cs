using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos
{
    public class E_PagoCuota : E_Pago
    {
        public int? IdSocio { get; set; }
        public int? NroCuota { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? TipoPago { get; set; }


        // constructor
        public E_PagoCuota(
            int IdPago,
            int idSocio,
            int nroCuota,
            float Monto,
            string estado,
            DateTime fechaVencimiento,
            DateTime FechaPago,
            string tipoPago
            ) :
            base(IdPago, Monto, FechaPago)
        {
            IdSocio = idSocio;
            NroCuota = nroCuota;
            Estado = estado;
            FechaVencimiento = fechaVencimiento;
            TipoPago = tipoPago;
        }
    }
}
