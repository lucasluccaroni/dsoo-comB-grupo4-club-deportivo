using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dsoo_comB_grupo4_club_deportivo.Entidades.Personas;

namespace dsoo_comB_grupo4_club_deportivo
{
    public partial class frmInscripcionNoSocio : Form
    {
        internal string? rol, usuario;
        public frmInscripcionNoSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        // Boton para ingresar y regsitrar un NO socio
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
                string respuesta;
                // E_NoSocio noSocio = new E_NoSocio(txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtDireccion.Text, dtpFechaNac.Value, int.Parse(txtTelefono.Text), chkFichaMedica.Checked, int.Parse(txtDni.Text));
                E_NoSocio noSocio = new E_NoSocio(txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtDireccion.Text, dtpFechaNac.Value, int.Parse(txtTelefono.Text),chkFichaMedica.Checked, int.Parse(txtDni.Text));
                // instanciamos esta variable que tiene el metodo de nuevo_Socio
                Datos.NoSocio noSocios = new Datos.NoSocio();
                respuesta = noSocios.Nuevo_No_Socio(noSocio);
                System.Diagnostics.Debug.WriteLine("llego aca");
                bool esNumero = int.TryParse(respuesta, out int codigo);

                if (esNumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("El socio ya existe!", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Socio nro." + respuesta + " registrado con exito.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("");
                }
            }
        }

        // Boton para limpiar todos los campos del formulario
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

