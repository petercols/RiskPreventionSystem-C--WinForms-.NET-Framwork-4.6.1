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
    public partial class frmSuspenderContrato : Form
    {
        int suspendido;
        int modificado;

        public frmSuspenderContrato()
        {
            InitializeComponent();
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


        private void txtRutSuspender_Validated(object sender, EventArgs e)
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
            txtRutSuspender.Clear();

        }

        private void frmSuspenderContrato_Load(object sender, EventArgs e)
        {
            //ESTADO
            rbNo0.Enabled = true;
            rbSi1.Enabled = true;
            rbDeshabilitado2.Enabled = true;

            //MODIFICADO
            rbSI_1.Enabled = true;
            rbNO_0.Enabled = true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutSuspender.Text == string.Empty || rbSi1.Text == string.Empty || rbNo0.Text == string.Empty|| rbDeshabilitado2.Text == string.Empty|| rbSI_1.Text == string.Empty || rbNO_0.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRutSuspender, "Ingrese un Rut.");

                    ErrorIcono.SetError(rbSi1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNo0, "Seleccione un Campo");
                    ErrorIcono.SetError(rbDeshabilitado2, "Seleccione un Campo");

                    ErrorIcono.SetError(rbSI_1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNO_0, "Seleccione un Campo");
                }
                if (!validarRutOLD(txtRutSuspender.Text))
                {
                    this.MensajeError("Rut invalido!");
                    //txtRutFM.Focus();
                }
                else
                {
                    Rpta = NContrato.ActualizarSuspencion_Modificacion(this.txtRutSuspender.Text.Trim(), this.suspendido, this.modificado);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta la Suspencion del Contrato y Modificacion");
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
            suspendido = 1;
        }

        private void rbNo0_CheckedChanged(object sender, EventArgs e)
        {
            suspendido = 0;
        }

        private void rbDeshabilitado2_CheckedChanged(object sender, EventArgs e)
        {
            suspendido = 2;
        }

        private void rbSI_1_CheckedChanged(object sender, EventArgs e)
        {
            modificado = 1;
        }

        private void rbNO_0_CheckedChanged(object sender, EventArgs e)
        {
            modificado = 0;
        }

        private void txtRutSuspender_Validating(object sender, CancelEventArgs e)
        {

            if (!validarRutOLD(txtRutSuspender.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutFM.Focus();
            }
        }
    }
}
 