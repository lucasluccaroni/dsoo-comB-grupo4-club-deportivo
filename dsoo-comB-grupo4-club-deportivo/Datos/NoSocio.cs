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
                comando.Parameters.Add("fechaNac", MySqlDbType.DateTime).Value = noSocio.FechaNac;
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
    }
}
