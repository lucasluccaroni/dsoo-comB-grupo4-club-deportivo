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
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Activo { get; set; }


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
            FechaInscripcion = DateTime.Today;
            FechaVencimiento = FechaInscripcion.AddDays(30);
            Activo = true;
        }

        // Método para modificar la fecha de vencimeinto cada vez que se paga
        public void RenovarCuota(int dias = 30)
        {
            FechaVencimiento = DateTime.Today.AddDays(30);
        }
    }
}
