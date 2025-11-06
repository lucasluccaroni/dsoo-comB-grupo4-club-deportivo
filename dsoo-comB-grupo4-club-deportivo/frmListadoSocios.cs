using dsoo_comB_grupo4_club_deportivo.Datos;
using dsoo_comB_grupo4_club_deportivo.Entidades.Personas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        public void CargarGrilla(bool mostrarInactivos = false)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                if (mostrarInactivos)
                {
                    query = "SELECT * FROM Socio WHERE Activo = FALSE;";
                }
                else
                {
                    query = "SELECT * FROM Socio WHERE Activo = TRUE;";

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
                        dtgvSocios.Rows[renglon].Cells[10].Value = reader.GetDateTime(10); // fechaVencimiento
                        dtgvSocios.Rows[renglon].Cells[11].Value = reader.GetBoolean(11); // activo
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

        // Boton para inactivar un socio
        private void btnInactivarSocio_Click(object sender, EventArgs e)
        {
            if(dtgvSocios.SelectedRows.Count > 0)
            {
                Socio herramientasSocio = new Socio();
                int idSocio = (int)dtgvSocios.SelectedRows[0].Cells["idSocio"].Value;
                System.Diagnostics.Debug.WriteLine("id a inactivar => " + idSocio);
                DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea inactivar al Socio {idSocio}?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = herramientasSocio.InactivarSocio(idSocio);
                    if (resultado)
                    {
                        MessageBox.Show("Socio inactivado correctamente.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvSocios.Rows.Clear();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se econtró el Socio a inactivar.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Socio seleccionado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        // checkBox para mostrar NoSocios activos o inactivos
        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarInactivos.Checked)
            {
                dtgvSocios.Rows.Clear();
                CargarGrilla(true); // muestra Socios inactivos
                btnReactivarSocio.Enabled = true; // activa el boton de reactivar Socios
                btnInactivarSocio.Enabled = false; // desactiva el boton para inactivar Socios
            }
            else
            {
                dtgvSocios.Rows.Clear();
                CargarGrilla(false); // muestra Socios activos
                btnReactivarSocio.Enabled = false; // desactiva el boton de reactivar Socios
                btnInactivarSocio.Enabled = true; // activa el boton para inactivar Socios
            }
        }

        // boton para activar el método de reactivar un NoSocio
        private void btnReactivarSocio_Click(object sender, EventArgs e)
        {
            if (dtgvSocios.SelectedRows.Count > 0)
            {
                Socio herramientasSocio = new Socio();
                int idSocio = (int)dtgvSocios.SelectedRows[0].Cells["idSocio"].Value;
                System.Diagnostics.Debug.WriteLine("id a activar => " + idSocio);
                DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea activar al Socio {idSocio}?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = herramientasSocio.ReactivarSocio(idSocio);
                    if (resultado)
                    {
                        MessageBox.Show("Socio activado correctamente.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvSocios.Rows.Clear();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se econtró el Socio a activar.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Socio seleccionado.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
