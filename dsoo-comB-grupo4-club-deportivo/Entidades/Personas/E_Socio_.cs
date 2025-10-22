using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Personas
{
    public class E_Socio : E_Persona
    {

        public int Id_Socio { get; set; }
        public DateTime fechaInscripcion;


        public E_Socio(
            string Nombre,
            string Apellido, 
            string Email,
            string DNI,
            string Direccion,
            DateTime FechaNac,
            int Telefono,
            bool FichaMedica,
            int id_Socio
            ): base( 
                Nombre,
                Apellido,
                Email,
                DNI,
                Direccion,
                FechaNac,
                Telefono,
                FichaMedica)
        {
            Id_Socio = id_Socio;
            fechaInscripcion = DateTime.Today;
        }
    }
}
