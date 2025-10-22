using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Pagos
{
    public class E_PagoActividad : E_Pago
    {
        public int? IdActividad { get; set; }
        public int IdNoSocio { get; set; }

        public E_PagoActividad(int IdPago, int Monto, DateOnly FechaPago, int idAct, int idNoSoc) : base (IdPago, Monto, FechaPago)
        {
            IdActividad = idAct;
            IdNoSocio = idNoSoc;
        }
    }
}
