using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Esta clase Rut hace uso de la libreria
using System.Text.RegularExpressions;

namespace Sistema.Diseño
{
    public partial class Login : Form
    {
        public string rutUsuario;

        public string contraseniaUser;

        public Login()
        {
            InitializeComponent();
        }
  
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NLogin.Login(textRut.Text.Trim(), textContraseña.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El rut o la contraseña son incorrectos.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                if (textRut.Text == string.Empty)
                {
                    this.MensajeError("Ingrese un Rut");
                    ErrorIcono.SetError(textRut, "Ingrese un Rut");
                }
                
                if (textContraseña.Text == string.Empty)
                {
                    this.MensajeError("Ingrese Una Contraseña");
                    ErrorIcono.SetError(textContraseña, "Ingrese Una Contraseña");
                }
                if (!validarRutOLD(textRut.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    if (Convert.ToInt32(Tabla.Rows[0][3]) == 0)
                    {
                        MessageBox.Show("Este Usuario no esta Habilitado.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (Convert.ToString(Tabla.Rows[0][4]) != "Administrador")
                    {
                        MessageBox.Show("Este Usuario no es Administrador.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmPrincipalDiseño frmDiseñoData = new frmPrincipalDiseño();
                        frmDiseñoData.rutUsuario = Convert.ToString(Tabla.Rows[0][0]);
                        frmDiseñoData.nombreUsuario = Convert.ToString(Tabla.Rows[0][1]);
                        frmDiseñoData.apellidoUsuario = Convert.ToString(Tabla.Rows[0][2]);
                        frmDiseñoData.habilitado = Convert.ToInt32(Tabla.Rows[0][3]);
                        frmDiseñoData.tipo = Convert.ToString(Tabla.Rows[0][4]);
                        frmDiseñoData.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmUsuario frmUser = new frmUsuario();
            frmUser.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRestablecerContraseña frmPass = new frmRestablecerContraseña();
            frmPass.Show();
            this.Hide();
        }

        private void textRut_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(textRut.Text))
            {
                this.MensajeError("Rut invalido!");
                //textRut.Focus();
            }
        }
    }
}
