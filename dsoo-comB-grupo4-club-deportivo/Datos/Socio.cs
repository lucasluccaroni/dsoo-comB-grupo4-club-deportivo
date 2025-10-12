using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsoo_comB_grupo4_club_deportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;


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
                comando.Parameters.Add("dni", MySqlDbType.VarChar).Value = socio.Dni;
                comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = socio.Direccion;
                comando.Parameters.Add("fechaNac", MySqlDbType.DateTime).Value = socio.FechaNac;
                comando.Parameters.Add("telefono", MySqlDbType.Int32).Value = socio.Telefono;
                comando.Parameters.Add("fichaMedica", MySqlDbType.Binary).Value = socio.FichaMedica;
                comando.Parameters.Add("fechaInscripcion", MySqlDbType.DateTime).Value = socio.fechaInscripcion;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);

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


    }
}
