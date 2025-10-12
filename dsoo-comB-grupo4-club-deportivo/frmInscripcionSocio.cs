using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dsoo_comB_grupo4_club_deportivo.Entidades;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmInscripcionSocio : Form
    {
        public frmInscripcionSocio()
        {
            InitializeComponent();
        }

        // Boton para volver al  formulario principal
        private void btnVolver_Click(object sender ,EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        // Boton para ingresar y regsitrar un socio
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" ||
                txtApellido.Text == "" ||
                txtDni.Text == "" ||
                txtMail.Text == "" ||
                txtDireccion.Text == "" ||
                txtTelefono.Text == "" ||
                !chkFichaMedica.Checked
                )
            {
                MessageBox.Show("Debe completar todos los datos prara continuar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("boton apretado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string respuesta;
                E_Socio socio = new E_Socio(txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtDireccion.Text, dtpFechaNac.Value, int.Parse(txtTelefono.Text), chkFichaMedica.Checked, int.Parse(txtDni.Text));

                // instanciamos esta variable que tiene el metodo de nuevo_Socio
                Datos.Socio socios = new Datos.Socio();
                respuesta = socios.Nuevo_Socio(socio);
                
                System.Diagnostics.Debug.WriteLine("AHORA FUNCIONA2");
                

                
                bool esNumero = int.TryParse(respuesta, out int codigo);
                if (esNumero)
                {
                    if(codigo == 1)
                    {
                        MessageBox.Show("El socio ya existe!", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Socio nro." + respuesta + "registrado con exito.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            chkFichaMedica.Checked = false;
            dtpFechaNac.Value = DateTime.Today;

        }
    }
}
