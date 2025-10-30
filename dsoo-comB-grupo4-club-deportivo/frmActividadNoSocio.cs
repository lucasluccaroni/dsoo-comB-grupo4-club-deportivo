using dsoo_comB_grupo4_club_deportivo.Datos;
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
    public partial class frmActividadNoSocio : Form
    {
        internal string usuario, rol;
        public frmActividadNoSocio()
        {
            InitializeComponent();
        }

        // Metodo para que cuando se cargue el formulario automaticamente se implemente el metodo "CargarGrilla"
        private void frmActividadNoSocio_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Metodo para buscar la consulta SQL en la base de datos y traer los datos para cargarlos en la grilla
        public void CargarGrilla()
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string queryUno;
                string queryDos;
                sqlCon = Conexion.getInstancia().CrearConexion();
                queryUno = "SELECT a.Nombre, e.FechaActividad, CONCAT(p.Nombre, ' ', p.Apellido), a.Precio FROM Actividad a INNER JOIN EdicionActividad e ON a.IdActividad = e.IdActividad INNER JOIN Profesor p ON e.IdProfesor = p.IdProfesor WHERE e.FechaActividad > curdate() ORDER BY a.Nombre;";
                queryDos = "Select ";
                MySqlCommand comando = new MySqlCommand(queryUno, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvActividad.Rows.Add();
                        dtgvActividad.Rows[renglon].Cells[0].Value = reader.GetString(0); // Nombre actividad
                        dtgvActividad.Rows[renglon].Cells[1].Value = reader.GetDateTime(1); // Fecha de la edicion
                        dtgvActividad.Rows[renglon].Cells[2].Value = reader.GetString(2); // Nombre + Apellido prof
                        dtgvActividad.Rows[renglon].Cells[3].Value = reader.GetInt32(3); // Precio
                    }
                }
                else
                {
                    MessageBox.Show("No hay información para mostrar", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
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

        // boton para verificar que el socio exista
        private void btnVerificarNoSocio_Click(object sender, EventArgs e)
        {
            string idNoSocio = txtIdNoSocio.Text;
            NoSocio noSocio = new NoSocio();
            bool noSocioExiste = noSocio.VerificarNoSocio(idNoSocio);

            if (noSocioExiste)
            {
                lblVerificarSocio.Text = "Correcto.";
                lblVerificarSocio.ForeColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                lblVerificarSocio.Text = "No existe.";
                lblVerificarSocio.ForeColor = Color.FromArgb(255, 000, 0);
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
