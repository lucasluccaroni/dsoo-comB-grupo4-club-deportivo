using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // referencia a la libreria de MySQL

namespace dsoo_comB_grupo4_club_deportivo.Datos
{
    public class Conexion
    {
        // declaramos las variables de conexion
        private string
            baseDatos,
            servidor,
            puerto,
            usuario,
            clave;
        private static Conexion? connect = null;

        private Conexion() // asignamos valores a las variables de conexion
        {
            this.baseDatos = "Dsoo_club_deportivo";
            //this.baseDatos = "dsoo-club-deportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "Colondesantafe22.";
        }
        
        // proceso de interaccion
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadenaConexion = new MySqlConnection();
            try
            {
                cadenaConexion.ConnectionString =
                    "datasource=" + this.servidor +
                    ";port=" + this.puerto +
                    ";username=" + this.usuario +
                    ";password=" + this.clave +
                    ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadenaConexion = null;
                throw;
            }
            return cadenaConexion;
        }

        public static Conexion getInstancia()
        {
            if (connect == null) // quiere decir que la conexion esta cerrada
            {
                connect = new Conexion(); // se crea una nueva
            }
            return connect;
        }
    }
}
