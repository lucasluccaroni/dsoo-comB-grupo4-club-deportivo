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
    public partial class frmListadoNoSocios : Form
    {
        internal string? rol, usuario;

        public frmListadoNoSocios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Metodo para que cuandO se cargue el formulario automaticamente se implemente el metodo "CargarGrilla"
        private void frmListadoNoSocios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Metodo para buscar la consulta SQL en la base de datos y traer los datos para cargarlos en la grilla
        public void CargarGrilla(bool mostrarInactivos = false)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                if (mostrarInactivos)
                {
                    query = "SELECT * FROM NoSocio WHERE Activo = FALSE;";
                }
                else
                {
                    query = "SELECT * FROM NoSocio WHERE Activo = TRUE;";

                }
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvNoSocios.Rows.Add();
                        dtgvNoSocios.Rows[renglon].Cells[0].Value = reader.GetInt32(0); // idSocio
                        dtgvNoSocios.Rows[renglon].Cells[1].Value = reader.GetString(1); // nombre
                        dtgvNoSocios.Rows[renglon].Cells[2].Value = reader.GetString(2); // apellido
                        dtgvNoSocios.Rows[renglon].Cells[3].Value = reader.GetString(3); // email
                        dtgvNoSocios.Rows[renglon].Cells[4].Value = reader.GetString(4); // dni
                        dtgvNoSocios.Rows[renglon].Cells[5].Value = reader.GetString(5); // direccion
                        dtgvNoSocios.Rows[renglon].Cells[6].Value = reader.GetDateTime(6); // fechaNac
                        dtgvNoSocios.Rows[renglon].Cells[7].Value = reader.GetInt32(7); // telefono
                        dtgvNoSocios.Rows[renglon].Cells[8].Value = reader.GetBoolean(8); // fichaMed
                        dtgvNoSocios.Rows[renglon].Cells[9].Value = reader.GetBoolean(9); // activo
                    }
                }
                else
                {
                    MessageBox.Show("No hay información para mostrar", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch(Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("frmListadoNoSocio.CS -> Catch");
                MessageBox.Show(ex.Message);
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

        // Metodo para ver el detalle de algun NoSocio de la grilla
        private void dtgvNoSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nro = e.RowIndex;
            if (nro != -1)
            {
                int idNoSocio = (int)dtgvNoSocios.Rows[nro].Cells[0].Value;
                string nombreNoSocio = (string)dtgvNoSocios.Rows[nro].Cells[1].Value;
                string apellidoNoSocio = (string)dtgvNoSocios.Rows[nro].Cells[2].Value;
                string dniNoSocio = (string)dtgvNoSocios.Rows[nro].Cells[4].Value;

                MessageBox.Show(
                    "ID: " + idNoSocio +
                    "\nNombre: " + nombreNoSocio +
                    "\nApellido: " + apellidoNoSocio +
                    "\nDNI: " + dniNoSocio, $"Informacion de NoSocio: {idNoSocio}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Boton para activar el metodo de inactivar un NoSocio
        private void btnInactivarNoSocio_Click(object sender, EventArgs e)
        {
            if (dtgvNoSocios.SelectedRows.Count > 0)
            {
                NoSocio herramientasNoSocio = new NoSocio();
                int idNoSocio = (int)dtgvNoSocios.SelectedRows[0].Cells["idNoSocio"].Value;
                //System.Diagnostics.Debug.WriteLine("id a inactivar => "+ idNoSocio);
                DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea inactivar al No Socio {idNoSocio}?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = herramientasNoSocio.InactivarNoSocio(idNoSocio);
                    if (resultado)
                    {
                        MessageBox.Show("No Socio inactivado correctamente.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvNoSocios.Rows.Clear();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se econtró el No Socio a inactivar.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningun NoSocio seleccionado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        
        // checkBox para mostrar NoSocios activos o inactivos
        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarInactivos.Checked)
            {
                dtgvNoSocios.Rows.Clear();
                CargarGrilla(true); // muestra NoSocios inactivos
                btnReactivarNoSocio.Enabled = true; // activa el boton de reactivar NoSocios
                btnInactivarNoSocio.Enabled = false; // desactiva el boton para inactivar NoSocios
            }
            else
            {
                dtgvNoSocios.Rows.Clear();
                CargarGrilla(false); // muestra NoSocios activos
                btnReactivarNoSocio.Enabled = false; // desactiva el boton de reactivar NoSocios
                btnInactivarNoSocio.Enabled = true; // activa el boton para inactivar NoSocios
            }
        }

        // boton para activar el método de reactivar un NoSocio
        private void btnReactivarSocio_Click(object sender, EventArgs e)
        {
            if (dtgvNoSocios.SelectedRows.Count > 0)
            {
                NoSocio herramientasNoSocio = new NoSocio();
                int idNoSocio = (int)dtgvNoSocios.SelectedRows[0].Cells["idNoSocio"].Value;
                //System.Diagnostics.Debug.WriteLine("id a activar => " + idNoSocio);
                DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea activar al No Socio {idNoSocio}?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = herramientasNoSocio.ReactivarNoSocio(idNoSocio);
                    if (resultado)
                    {
                        MessageBox.Show("NoSocio activado correctamente.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvNoSocios.Rows.Clear();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se econtró el NoSocio a activar.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningun NoSocio seleccionado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        
        // Boton para volver al formulario principal
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
