using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades
{
    public class E_NoSocio : E_Persona
    {
        public int IdNoSocio { get; set; }

        public E_NoSocio(
            string Nombre,
            string Apellido,
            string Email,
            string DNI,
            string Direccion,
            DateTime FechaNac,
            int Telefono,
            bool FichaMedica,
            int idNoSocio
            ): base(
                Nombre,
                Apellido,
                Email,
                DNI,
                Direccion,
                FechaNac,
                Telefono,
                FichaMedica
                )
        {
            IdNoSocio = idNoSocio;
        }
    }
}
