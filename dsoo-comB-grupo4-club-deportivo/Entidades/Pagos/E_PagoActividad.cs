using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos
{
    public class E_PagoActividad : E_Pago
    {
        public int? IdEdicion { get; set; }
        public int IdNoSocio { get; set; }

        public E_PagoActividad(int IdPago, int idEdi, int idNoSoc, float Monto, DateTime FechaPago ) : base (IdPago, Monto, FechaPago)
        {
            IdEdicion = idEdi;
            IdNoSocio = idNoSoc;
        }
    }
}
