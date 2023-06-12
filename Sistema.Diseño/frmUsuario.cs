using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Diseño
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        //VALIDAR RUT GENERAL
        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        //VALIDAR RUT GENERAL
        public bool validarRutOLD(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        //VALIDAR CAMPO NUMERICO
        public static void validarCampoEntero(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("Ingrese un valor Numerico!");
            }
        }

        private void txtRut_Validated(object sender, EventArgs e)
        {
            if (!validarRut(txtRut.Text))
            {
                this.MensajeError("Formato de Rut invalido!");
                //txtRut.Focus();
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
           
        }  

        private void btnRedirecLogin_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            txtRut.Clear();
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            txtApellidoUsuario.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDomicilio.Clear();

            btnAddUsuario.Visible = true;
            ErrorIcono.Clear();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtTipoUsuario.Text == string.Empty || txtRut.Text == string.Empty || txtContraseña.Text == string.Empty  || txtNombreUsuario.Text == string.Empty || txtApellidoUsuario.Text == string.Empty || txtTelefono.Text == string.Empty || txtCorreo.Text == string.Empty || txtDomicilio.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRut, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtContraseña, "Ingrese una Contraseña.");
                    ErrorIcono.SetError(txtTipoUsuario, "Ingrese un Tipo de Usuario.");
                    ErrorIcono.SetError(txtNombreUsuario, "Ingrese un Nombre de Usuario.");
                    ErrorIcono.SetError(txtApellidoUsuario, "Ingrese un Apellido para el Usuario.");
                    ErrorIcono.SetError(txtTelefono, "Ingrese un Telefono para el Usuario.");
                    ErrorIcono.SetError(txtCorreo, "Ingrese un Correo para el Usuario.");
                    ErrorIcono.SetError(txtDomicilio, "Ingrese un Domocilio para el Usuario.");

                }
                if (!validarRutOLD(txtRut.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    Rpta = NUsuario.Insertar(txtRut.Text.Trim(),txtContraseña.Text.Trim(), txtTipoUsuario.Text.Trim(), txtNombreUsuario.Text.Trim(), txtApellidoUsuario.Text.Trim(), Convert.ToInt32(txtTelefono.Text.Trim()), txtCorreo.Text.Trim(), txtDomicilio.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el Registro de Usuario");
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtRut_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRut(txtRut.Text))
            {
                this.MensajeError("Formato de Rut invalido!");
                //txtRut.Focus();
            }
        }
    }
}
