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
    internal class NoSocio
    {
        public string Nuevo_No_Socio(E_NoSocio noSocio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // agregamos parametros
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("email", MySqlDbType.VarChar).Value = noSocio.Email;
                comando.Parameters.Add("dniNoSoc", MySqlDbType.VarChar).Value = noSocio.Dni;
                comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = noSocio.Direccion;
                comando.Parameters.Add("fechaNac", MySqlDbType.Date).Value = noSocio.FechaNac;
                comando.Parameters.Add("telefono", MySqlDbType.Int32).Value = noSocio.Telefono;
                comando.Parameters.Add("fichaMedica", MySqlDbType.Byte).Value = noSocio.FichaMedica ? (byte)1 : (byte)0;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "respuesta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
                System.Diagnostics.Debug.WriteLine("PAR CODIGO QUE ES => " + salida);

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

        // Método que busca en la DB si el socio existe
        public bool VerificarNoSocio(int id)
        {
            bool salida;
            string query;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // creamos una conexion con la DB y le solicitamos una consulta SELECT con el id del no Socio
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT * FROM NoSocio WHERE IdNoSocio = @id ;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", id);
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                System.Diagnostics.Debug.WriteLine("READER => " + reader.HasRows);
                
                if (reader.HasRows)
                {
                    // Si es true, significa que la consulta devolvió una fila por lo que el usuario existe
                    salida = true; 
                }
                else
                {
                    // Si es false, significa que la consulta no devolvió una fila por lo que el socio no existe
                    salida = false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
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
    }
}
