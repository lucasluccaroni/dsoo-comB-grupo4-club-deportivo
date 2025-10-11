using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace dsoo_comB_grupo4_club_deportivo.Entidades
{
    public class E_Persona
    {
        
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Dni { get; set; }
        public DateTime fechaNac;
        public string? Direccion { get; set; }
        public int Telefono { get; set; }
        public bool FichaMedica { get; set; }

        public E_Persona(
            string nombre,
            string apellido,
            string email,
            string dni,
            string direccion,
            DateTime fechaNac,
            int telefono,
            bool fichaMedica
            )
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Dni = dni;
            Direccion = direccion;
            FechaNac = fechaNac;
            Telefono = telefono;
            FichaMedica = fichaMedica;
        }



        // get/set para la fecha
       private DateTime FechaNac
        {
            get { return FechaNac; }
            set { FechaArgentina(value); }
        }
        // funcion para modificar el formato de la fecha
        private DateTime FechaArgentina(DateTime fecha)
        {
           return fecha = DateTime.Parse("dd/MM/yyyy");
        }


    }
}
