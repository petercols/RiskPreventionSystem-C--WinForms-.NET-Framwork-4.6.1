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
// Esta clase Rut hace uso de la libreria
using System.Text.RegularExpressions;

namespace Sistema.Diseño
{
    public partial class frmDeshabilitarCliente : Form
    {
        int habilitado;
        public frmDeshabilitarCliente()
        {
            InitializeComponent();
        }

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


        public static bool ValidaRut2(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        private void Limpiar()
        {
            txtRutDeshabilitar.Clear();

        }

        private void frmDeshabilitarCliente_Load(object sender, EventArgs e)
        {
            rbNo0.Enabled = true;
            rbSi1.Enabled = true;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string Rpta = "";
                if (txtRutDeshabilitar.Text == string.Empty || rbSi1.Text == string.Empty || rbNo0.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRutDeshabilitar, "Ingrese un Rut.");
                    ErrorIcono.SetError(rbSi1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNo0, "Seleccione un Campo");
                }       
                else              
                {
                    Rpta = NUsuario.ActualizarEstado(this.txtRutDeshabilitar.Text.Trim(), this.habilitado);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el Estado del Cliente");
                        this.Limpiar();
                        this.Hide();
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

        private void rbSi1_CheckedChanged(object sender, EventArgs e)
        {
            habilitado = 1;
        }

        private void rbNo0_CheckedChanged(object sender, EventArgs e)
        {
            habilitado = 0;
        }

        private void txtRutDeshabilitar_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutDeshabilitar.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }
    }
}
