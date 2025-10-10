using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace dsoo_comB_grupo4_club_deportivo.Datos
{
    internal class Usuarios
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // ↓ elemento que almacena el nombre del  procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros del procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                // abrimos la conexin
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resultado en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla;

                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
