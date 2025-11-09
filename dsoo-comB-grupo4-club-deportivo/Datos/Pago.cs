using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using dsoo_comB_grupo4_club_deportivo.Entidades.Pagos;
using dsoo_comB_grupo4_club_deportivo.Entidades.Pagos.Comprobante;

namespace dsoo_comB_grupo4_club_deportivo.Datos
{
    public class Pago
    {

        // Método pagar insertar un pago de actividad en la base de datos
        public PagoResultado PagarActividad(int idInscrip)
        {
            // Creamos una instancia de PagoResultado que nos va a dar el resultado de intentar pagar la actividad
            PagoResultado resultado = new PagoResultado
            {
                Exito = false,
                Mensaje = "",
                ComprobanteCuota = null

            };

            // Definimos el resto de variables que vamos a utilizar
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlDataReader reader;


            // Mediante un try/catch realizamos el intento de pagar la actividad
            try
            {
                // establecemos qué y cómo será la conexion a la DB y usamos el storedProcedure "PagarActividad"
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("PagarActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // agregamos el parametro, que será el id de inscripcion
                comando.Parameters.Add("p_idInscripcion", MySqlDbType.Int32).Value = idInscrip;

                // abrimos la conexion y leemos el resultado
                sqlCon.Open();
                reader = comando.ExecuteReader(); // aca almacenamos el resultado


                if (!reader.Read()) // si el Reader no leyó nada significa que el idInscripcion no existe
                {
                    resultado.Mensaje = "No se encontró inscripción con ese ID.";
                    return resultado; // Exito = false; Comprobante = null;
                    // El flujo del método se corta aca, se retorna el objeto resultado.
                }


                // Si el Reader leyó un resultado, creamos un DTO que almacenará todos los datos necesarios
                // para pasarle al comprobante
                ComprobantePagoActDTO dto = new ComprobantePagoActDTO
                {
                    IdInscripcion = reader.GetInt32("IdInscripcion"),
                    IdPago = reader.GetInt32("IdPago"),
                    Actividad = reader.GetString("Actividad"),
                    NoSocio = reader.GetString("NoSocio"),
                    FechaActividad = reader.GetDateTime("FechaActividad"),
                    Precio = reader.GetFloat("Precio"),
                    FechaPago = reader.GetDateTime("FechaPago")
                };

                resultado.Exito = true;
                resultado.ComprobanteAct = dto;
                resultado.Mensaje = "Pago registrado correctamente.";
                return resultado;
                // Retornamos el objeto resultado con todos los atributos "positivos".

            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Source);
                resultado.Mensaje = "Error al procesar el pago: " + ex.Message;
                return resultado; // Exito = false; Comprobante = null
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }





        // Metodo para cobrar una cuota de Socio
        public PagoResultado PagarCuota(int idSocio, string tipoPago)
        {
            // Creamos una instancia de PagoResultado que nos va a dar el resultado de intentar pagar la cuota
            PagoResultado resultado = new PagoResultado
            {
                Exito = false,
                Mensaje = "",
                ComprobanteCuota = null
            };

            // Definimos el resto de variables que vamos a utilizar
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlDataReader reader;

            // Mediante un try/catch realizamos el intento de pagar la actividad
            try
            {
                // establecemos qué y cómo será la conexion a la DB y usamos el storedProcedure "PagarCuota"
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // agregamos el parametro, que será el id de inscripcion
                comando.Parameters.Add("p_idSocio", MySqlDbType.Int32).Value = idSocio;
                comando.Parameters.Add("p_tipoPago", MySqlDbType.VarChar).Value = tipoPago;

                // abrimos la conexion y leemos el resultado
                sqlCon.Open();
                reader = comando.ExecuteReader(); // aca almacenamos el resultado


                if (!reader.Read()) // si el Reader no leyó nada significa que el idInscripcion no existe
                {
                    resultado.Mensaje = "Error. No se pudo registrar el pago de la cuota.";
                    return resultado; // Exito = false; Comprobante = null;
                    // El flujo del método se corta aca, se retorna el objeto resultado.
                }


                // Si el Reader leyó un resultado, creamos un DTO que almacenará todos los datos necesarios
                // para pasarle al comprobante
                ComprobantePagoCuotaDTO dto = new ComprobantePagoCuotaDTO
                {
                    IdSocio = idSocio,
                    IdPago = reader.GetInt32("IdPago"),
                    NroCuota = reader.GetInt32("NroCuota"),
                    Monto = reader.GetFloat("Monto"),
                    FechaVencimiento = reader.GetDateTime("FechaVencimiento"),
                    FechaPago = reader.GetDateTime("FechaPago"),
                    TipoPago = reader.GetString("TipoPago"),
                };

                resultado.Exito = true;
                resultado.ComprobanteCuota = dto;
                resultado.Mensaje = "Pago registrado correctamente.";
                return resultado;
                // Retornamos el objeto resultado con todos los atributos "positivos".

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Source);
                resultado.Mensaje = "Error al procesar el pago: " + ex.Message;
                return resultado; // Exito = false; Comprobante = null
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
