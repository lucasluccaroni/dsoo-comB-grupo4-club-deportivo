using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsoo_comB_grupo4_club_deportivo.Entidades.Personas
{
    internal class E_Profesor : E_Persona
    {
        public int IdProfesor { get; set; }
        public string Condicion { get; set; }

        public E_Profesor(
            string Nombre,
            string Apellido,
            string Email,
            string DNI,
            string Direccion,
            DateTime FechaNac,
            int Telefono,
            bool FichaMedica,
            int idProf,
            string condicion
            ) : base(
                Nombre,
                Apellido,
                Email,
                DNI,
                Direccion,
                FechaNac,
                Telefono,
                FichaMedica)
        {
            IdProfesor = idProf;
            Condicion = condicion;
        }
    }
}
