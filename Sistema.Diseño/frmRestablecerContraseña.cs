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
using Sistema.Datos;

namespace Sistema.Diseño
{
    public partial class frmRestablecerContraseña : Form
    {
        public frmRestablecerContraseña()
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

        private void textRut_Validated(object sender, EventArgs e)
        {
            if (!validarRut(textRut.Text))
            {
                this.MensajeError("Formato de Rut invalido!");
                //txtRut.Focus();
            }
        }

        private void textRut_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("K"))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("-"))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void frmRestablecerContraseña_Load(object sender, EventArgs e)
        {

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
            textRut.Clear();
            textContraseña.Clear();

            btnCambiarContraseña.Visible = true; 
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                if (textRut.Text == string.Empty || textContraseña.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(textRut, "Ingrese un Rut.");
                    ErrorIcono.SetError(textContraseña, "Ingrese una Contraseña.");
                }
                if (textRut.Text == string.Empty)
                {
                    this.MensajeError("Ingrese un Rut");
                }
                else
                if (textContraseña.Text == string.Empty)
                {
                    this.MensajeError("Ingrese la nueva Contraseña");
                }
                else
                {
                    Rpta = NLogin.ActualizarContraseña(textRut.Text.Trim(), textContraseña.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta la nueva Contraseña");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
