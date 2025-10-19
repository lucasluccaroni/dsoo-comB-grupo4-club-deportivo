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
using System.Data;

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

        private void frmListadoSocios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

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
                        dtgvSocios.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvSocios.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvSocios.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvSocios.Rows[renglon].Cells[3].Value = reader.GetString(3);
                        dtgvSocios.Rows[renglon].Cells[4].Value = reader.GetString(4);
                        dtgvSocios.Rows[renglon].Cells[5].Value = reader.GetString(5);
                        dtgvSocios.Rows[renglon].Cells[6].Value = reader.GetString(6);
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
