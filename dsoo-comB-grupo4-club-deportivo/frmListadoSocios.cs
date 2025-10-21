using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using dsoo_comB_grupo4_club_deportivo.Datos;


namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmListadoSocios : Form
    {
        internal string? rol, usuario;
        public frmListadoSocios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Metodo para que cuand se cargue el formulario automaticamente se implemente el metodo "CargarGrilla"
        private void frmListadoSocios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Metodo para buscar la consulta SQL en la base de datos y traer los datos para cargarlos en la grilla
        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT * FROM Socio;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvSocios.Rows.Add();
                        dtgvSocios.Rows[renglon].Cells[0].Value = reader.GetInt32(0); // idSocio
                        dtgvSocios.Rows[renglon].Cells[1].Value = reader.GetString(1); // nombre
                        dtgvSocios.Rows[renglon].Cells[2].Value = reader.GetString(2); // apellido
                        dtgvSocios.Rows[renglon].Cells[3].Value = reader.GetString(3); // email
                        dtgvSocios.Rows[renglon].Cells[4].Value = reader.GetString(4); // dni
                        dtgvSocios.Rows[renglon].Cells[5].Value = reader.GetString(5); // direccion
                        dtgvSocios.Rows[renglon].Cells[6].Value = reader.GetDateTime(6); // fechaNac
                        dtgvSocios.Rows[renglon].Cells[7].Value = reader.GetInt32(7); // telefono
                        dtgvSocios.Rows[renglon].Cells[8].Value = reader.GetBoolean(8); // fichaMed
                        dtgvSocios.Rows[renglon].Cells[9].Value = reader.GetDateTime(9); // fechaInscrip
                    }
                }
                else
                {
                    MessageBox.Show("No hay información para mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //System.Diagnostics.Debug.WriteLine("frmListadoSocio.CS -> Catch");
                //System.Diagnostics.Debug.WriteLine(ex.Source);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        // Metodo para ver el detalle de algun socio en la grilla
        private void dtgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nro = e.RowIndex;
            if (nro != -1)
            {
                int idSocio = (int)dtgvSocios.Rows[nro].Cells[0].Value;
                string nombreSocio = (string)dtgvSocios.Rows[nro].Cells[1].Value;
                string apellidoSocio = (string)dtgvSocios.Rows[nro].Cells[2].Value;
                string dniSocio = (string)dtgvSocios.Rows[nro].Cells[4].Value;

                MessageBox.Show(
                    "ID: " + idSocio +
                    "\nNombre: " + nombreSocio +
                    "\nApellido: " + apellidoSocio +
                    "\nDNI: " + dniSocio, $"Informacion de socio: {idSocio}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Boton para activar el metodo de eliminar un socio
        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            if(dtgvSocios.SelectedRows.Count > 0)
            {
                int idSocio = (int)dtgvSocios.Rows[0].Cells["idSocio"].Value;
                DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar al socio {idSocio}?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    EliminarSocio(idSocio);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Socio seleccionado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        // Metodo para eliminar un socio
        public void EliminarSocio(int idSocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "DELETE FROM Socio WHERE idSocio = @id;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", idSocio);
                sqlCon.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                if(filasAfectadas > 0)
                {
                    MessageBox.Show("Socio eliminado correctamente.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvSocios.Rows.Clear();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se econtró el socio a eliminar.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("Eliminar socio -> Catch");
                //System.Diagnostics.Debug.WriteLine(ex.Source);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        // Boton para volver al  formulario principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.rol = rol;
            principal.usuario = usuario;
            principal.Show();
            this.Hide();
        }
    }
}
