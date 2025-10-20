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

        // Metodo para que cuand se cargue el formulario automaticamente se implemente el metodo "CargarGrilla"
        private void frmListadoNoSocios_Load(object sender, EventArgs e)
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
                query = "SELECT * FROM NoSocio;";
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
                System.Diagnostics.Debug.WriteLine(ex.Source);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
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
