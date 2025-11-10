using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace dsoo_comB_grupo4_club_deportivo.Datos
{
    public class Actividad
    {
        // Método que busca en la DB si la actividad existe y tiene cupo
        public bool VerificarActividad(string idAct)
        {
            bool salida = false;
            string queryActividad;
            string queryCupo;
            int cupoMaximo = 0;
            int cupoActual = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // primero verificamos que exista la actividad
                queryActividad = "SELECT CupoMaximo FROM Actividad WHERE IdActividad = @idAct;"; //consulta a la DB
                MySqlCommand comandoActividad = new MySqlCommand(queryActividad, sqlCon);
                comandoActividad.Parameters.AddWithValue("@idAct", idAct);
                sqlCon.Open();

                MySqlDataReader readerActividad;
                readerActividad = comandoActividad.ExecuteReader();


                if (readerActividad.Read())
                {
                    // si esto es true significa que pudo leer una linea en la tabla resultante por lo que existe una actividad con este id.
                    // asignamos a la variable cupoMaximo, el valor del la columna "CupoMaximo" de la DB
                    cupoMaximo = Convert.ToInt32(readerActividad["CupoMaximo"]);

                }
                else
                {
                    // El reader dio false, por lo que no se encontro la actividad
                    return false;
                }

                // ahora verificamos la cantidad de inscriptos
                queryCupo = "SELECT COUNT(*) FROM InscripcionActividad WHERE IdActividad = @idAct;";
                MySqlCommand comandoInscriptos = new MySqlCommand(queryCupo, sqlCon);
                comandoInscriptos.Parameters.AddWithValue("@idAct", idAct);


                MySqlDataReader readerInscriptos;
                readerInscriptos = comandoInscriptos.ExecuteReader();
                if (readerInscriptos.Read())
                {
                    // asignamos a la variable cupoActual la cantidad de inscriptos a la actividad buscada
                    cupoActual = Convert.ToInt32(readerInscriptos["Cantidad"]);
                }

                // Comparamos el cupo actual con el cupo maximo a ver si hay lugar para que alguien se inscriba a la actividad
                salida = cupoActual < cupoMaximo;


            }
            catch(Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("Error en VerificarActividad: " + ex.Message);
                salida = false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        public string InscribirActividadNoSocio(int idEdicion, int idNoSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("InscribirActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // agregamos los parametros
                comando.Parameters.Add("p_idEdicion", MySqlDbType.Int32).Value = idEdicion;
                comando.Parameters.Add("p_idNoSoc", MySqlDbType.Int32).Value = idNoSocio;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "respuesta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
                //System.Diagnostics.Debug.WriteLine("Respuesta del StoreProcedure ↓");
                //System.Diagnostics.Debug.WriteLine(salida);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
                //System.Diagnostics.Debug.WriteLine(ex.Source);
                //System.Diagnostics.Debug.WriteLine("Respuesta del StoreProcedure => " + salida);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
