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
            this.StartPosition = FormStartPosition.CenterScreen;
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
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = @"SELECT 
                    e.IdEdicion,
                    a.Nombre AS Actividad, 
                    e.FechaActividad, 
                    CONCAT(p.Nombre, ' ', p.Apellido) AS Profesor, 
                    a.Precio, 
                    a.CupoMaximo - e.CupoEdicion AS CuposDisponibles
                        FROM Actividad a
                        INNER JOIN EdicionActividad e ON a.IdActividad = e.IdActividad
                        INNER JOIN Profesor p ON e.IdProfesor = p.IdProfesor
                        WHERE e.FechaActividad > CURDATE()
                        ORDER BY e.FechaActividad;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvActividad.Rows.Add();
                        dtgvActividad.Rows[renglon].Cells[0].Value = reader.GetInt32(0); // Id de la edicion
                        dtgvActividad.Rows[renglon].Cells[1].Value = reader.GetString(1); // Nombre actividad
                        dtgvActividad.Rows[renglon].Cells[2].Value = reader.GetDateTime(2); // Fecha de la edicion
                        dtgvActividad.Rows[renglon].Cells[3].Value = reader.GetString(3); // Nombre + Apellido prof
                        dtgvActividad.Rows[renglon].Cells[4].Value = reader.GetInt32(4); // Precio
                        dtgvActividad.Rows[renglon].Cells[5].Value = reader.GetInt32(5); // Cupos disponibles
                    }
                }
                else
                {
                    MessageBox.Show("No hay información para mostrar", "Aviso del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
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

                
        // Método para seleccionar una actividad de la grilla y poder inscribir un NoSocio en ella
        private void dtgvActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInscripcionActividad inscripActividad = new frmInscripcionActividad();

            int nro = e.RowIndex;

            // Tomamos de la grilla los datos de la actividad seleccionada
            string nombreActSeleccionada = (string)dtgvActividad.Rows[nro].Cells[1].Value;
            DateTime fechaActSeleccionada = (DateTime)dtgvActividad.Rows[nro].Cells[2].Value;
            string fechaParseada = fechaActSeleccionada.ToShortDateString();
            string profActSeleccionada = (string)dtgvActividad.Rows[nro].Cells[3].Value;
            int cupoActSeleccionada = (int)dtgvActividad.Rows[nro].Cells[5].Value;

            // Si la actividad tiene cupo, pasamos al formulario de inscripcion
            if ((nro != -1) && (cupoActSeleccionada > 0))
            {
                DialogResult confirmacion =  MessageBox.Show($"¿Desea inscribir un NoSocio para {nombreActSeleccionada} el dia {fechaParseada}?", "Aviso del sistema - Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int idEdicion = (int)dtgvActividad.Rows[nro].Cells[0].Value;
                    inscripActividad.usuario = usuario;
                    inscripActividad.rol = rol;
                    inscripActividad.idEdicion = idEdicion;
                    inscripActividad.nombreActividad = nombreActSeleccionada;
                    inscripActividad.profesor = profActSeleccionada;
                    inscripActividad.fechaActividad = fechaParseada;
                    inscripActividad.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("No hay cupo disponible para la actividad seleccionada.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
