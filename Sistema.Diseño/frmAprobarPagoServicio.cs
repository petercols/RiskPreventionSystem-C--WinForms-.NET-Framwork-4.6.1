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
    public partial class frmAprobarPagoServicio : Form
    {
        int pagado;
        public frmAprobarPagoServicio()
        {
            InitializeComponent();
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

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            txtRutUsuario.Clear();

        }

        private void frmAprobarPagoServicio_Load(object sender, EventArgs e)
        {
            //ESTADO PAGADO
            rbNo0.Enabled = true;
            rbSi1.Enabled = true;
        }

        private void btnConfirmarAS_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //string Rpta2 = "";
                if (txtRutUsuario.Text == string.Empty || rbSi1.Text == string.Empty || rbNo0.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRutUsuario, "Ingrese un ID.");
                    ErrorIcono.SetError(rbSi1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNo0, "Seleccione un Campo");
                }
                if (!validarRutOLD(txtRutUsuario.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    Rpta = NServicio.AprobarPago(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIdServicio.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta la Aprobacion Pago del Servicio");
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

        private void txtIdServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtRutUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutUsuario.Text))
            {
                this.MensajeError("Rut invalido!");
            }
        }
    }
}
