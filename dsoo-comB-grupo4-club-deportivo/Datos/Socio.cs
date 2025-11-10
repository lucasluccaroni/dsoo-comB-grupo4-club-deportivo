using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using dsoo_comB_grupo4_club_deportivo.Entidades.Personas;

namespace dsoo_comB_grupo4_club_deportivo.Datos
{
    internal class Socio
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // agregamos parametros
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("email", MySqlDbType.VarChar).Value = socio.Email;
                comando.Parameters.Add("dniSoc", MySqlDbType.VarChar).Value = socio.Dni;
                comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = socio.Direccion;
                comando.Parameters.Add("fechaNac", MySqlDbType.Date).Value = socio.FechaNac;
                comando.Parameters.Add("telefono", MySqlDbType.Int32).Value = socio.Telefono;
                comando.Parameters.Add("fichaMedica", MySqlDbType.Byte).Value = socio.FichaMedica ? (byte)1 : (byte)0;
                //comando.Parameters.Add("fechaInscripcion", MySqlDbType.Date).Value = socio.FechaInscripcion;
                //comando.Parameters.Add("fechaVencimiento", MySqlDbType.Date).Value = socio.FechaVencimiento;
                //comando.Parameters.Add("activo", MySqlDbType.Byte).Value = socio.Activo ? (byte)1 : (byte)0;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "respuesta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
                //System.Diagnostics.Debug.WriteLine("PAR CODIGO QUE ES => " + salida);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
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


        // Método que busca en la DB si el socio existe y está activo
        public bool VerificarSocio(int id)
        {
            bool salida;
            string query;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // creamos una conexion con la DB y le solicitamos una consulta SELECT con el id del Socio
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT * FROM Socio WHERE IdSocio = @id AND Activo = TRUE;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", id);
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                //System.Diagnostics.Debug.WriteLine("READER => " + reader.HasRows);

                if (reader.HasRows)
                {
                    // Si es true, significa que la consulta devolvió una fila por lo que el socio existe
                    salida = true;
                }
                else
                {
                    // Si es false, significa que la consulta no devolvió una fila por lo que el socio no existe o no está activo
                    salida = false;
                }
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(ex.Message);
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


        // Método para traer los datos de un Socio desde la DB
        public E_Socio DatosDelSocio(int id)
        {
            E_Socio socio = null;
            string query;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT * FROM Socio WHERE IdSocio = @id;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", id);
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    socio = new E_Socio(
                        reader.GetString("Nombre"),
                        reader.GetString("Apellido"),
                        reader.GetString("Email"),
                        reader.GetString("Dni"),
                        reader.GetString("Direccion"),
                        reader.GetDateTime("FechaNac"),
                        reader.GetInt32("Telefono"),
                        reader.GetBoolean("FichaMedica"),
                        reader.GetInt32("IdSocio")
                        );
                    // Asignamos los campos que son calculados desde la DB
                    socio.FechaInscripcion = reader.GetDateTime("FechaInscripcion");
                    socio.FechaVencimiento = reader.GetDateTime("FechaVencimiento");
                    socio.Activo = reader.GetBoolean("Activo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del socio: " + ex.Message);
                //System.Diagnostics.Debug.WriteLine(ex.Message + " - " + ex.Source);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return socio;
        }


        // Metodo para inactivar un socio
        public bool InactivarSocio(int idSocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "UPDATE Socio SET Activo = FALSE WHERE IdSocio = @id;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", idSocio);
                sqlCon.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("Eliminar socio -> Catch");
                //System.Diagnostics.Debug.WriteLine(ex.Source);
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        // Método para reactivar un NoSocio
        public bool ReactivarSocio(int idSocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "UPDATE Socio SET Activo = TRUE WHERE IdSocio = @id;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", idSocio);
                sqlCon.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("Eliminar NoSocio -> Catch");
                //System.Diagnostics.Debug.WriteLine(ex.Source);
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public List<E_Socio> ListaSociosVencenHoy()
        {
            List<E_Socio> lista = new List<E_Socio>();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "SELECT * FROM Socio WHERE FechaVencimiento = CURDATE() AND Activo = TRUE;";
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    E_Socio socio = new E_Socio(
                        reader.GetString("Nombre"),
                        reader.GetString("Apellido"),
                        reader.GetString("Email"),
                        reader.GetString("Dni"),
                        reader.GetString("Direccion"),
                        reader.GetDateTime("FechaNac"),
                        reader.GetInt32("Telefono"),
                        reader.GetBoolean("FichaMedica"),
                        reader.GetInt32("IdSocio")
                    );

                    socio.FechaInscripcion = reader.GetDateTime("FechaInscripcion");
                    socio.FechaVencimiento = reader.GetDateTime("FechaVencimiento");
                    socio.Activo = reader.GetBoolean("Activo");

                    lista.Add(socio);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return lista;
        }
    }
}
