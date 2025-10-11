using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades
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
            int id_Socio,
            DateTime FechaInscripcion
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
            FechaInscripcion = fechaInscripcion;
        }


        // get/set para la fecha
        private DateTime FechaInscripcion
        {
            get { return FechaInscripcion; }
            set { fechaArgentina(value); }
        }
        // funcion para modificar el formato de la fecha
        private DateTime fechaArgentina(DateTime fecha)
        {
            return fecha = DateTime.Parse("dd/MM/yyyy");
        }
    }
}
