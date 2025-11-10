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
            // variables usadas para la repeticion de lineas de codigo
            bool correcto = false;
            int mensaje;

            // creamos las variables para recibir los datos desde el teclado
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            // ciclo while para repetir el ingreso de datos
            // la variable "correcto" la inicializamos para ingresar el ciclo

            while (correcto != true)
            {
                // armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor:", "Datos de instalación MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto:", "Datos de instalación MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario:", "Datos de instalación MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave:", "Datos de instalación MySQL");

                // controlamos que los datos ingresados para acceder a MySQL sean correctos
                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDIR = " + T_servidor + " PUERTO = " + T_puerto + " USUARIO = " + T_usuario + " CLAVE = " + T_clave, "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("Ingrese nuevamente los datos", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            this.baseDatos = "Dsoo_club_deportivo";
            this.servidor = T_servidor;   // "localhost"; 
            this.puerto = T_puerto;       // "3306"; 
            this.usuario = T_usuario;     // "root"; 
            this.clave = T_clave;         // "Colondesantafe22.";
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
