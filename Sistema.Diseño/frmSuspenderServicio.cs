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
    public partial class frmSuspenderServicio : Form
    {
        int estado;
        int pagado;
        int folioContrato;

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

        public frmSuspenderServicio()
        {
            InitializeComponent();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeAlerta(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            txtIDeditarS.Clear();

        }

        private void frmSuspenderServicio_Load(object sender, EventArgs e)
        {
            //ESTADO
            rbNo0.Enabled = true;
            rbSi1.Enabled = true;

            //MODIFICADO
            rbSI_1.Enabled = true;
            rbNO_0.Enabled = true;
        }

        private void btnConfirmarSS_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //string Rpta2 = "";
                if (txtRutUsuario.Text == string.Empty || txtIDfolio.Text == string.Empty || txtIDeditarS.Text == string.Empty || dateFechaUPDS.Text == string.Empty || rbSi1.Text == string.Empty || rbNo0.Text == string.Empty || rbSI_1.Text == string.Empty || rbNO_0.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    //valida para el metdodo de suspencion
                    ErrorIcono.SetError(txtRutUsuario, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtIDeditarS, "Ingrese un ID.");
                    ErrorIcono.SetError(txtIDfolio, "Ingrese un ID.");

                    ErrorIcono.SetError(dateFechaUPDS, "Seleccione un Campo");

                    ErrorIcono.SetError(rbSi1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNo0, "Seleccione un Campo");

                    ErrorIcono.SetError(rbSI_1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNO_0, "Seleccione un Campo");
                }
                if (!validarRutOLD(txtRutUsuario.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    Rpta = NServicio.ActualizarServicio_Modificacion(Convert.ToInt32(txtIDeditarS.Text.Trim()), Convert.ToDateTime(dateFechaUPDS.Text.Trim()), this.estado, this.pagado);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta la Suspencion del Contrato y Modificacion");
                        this.Limpiar();
                        this.Hide();

                        //DESHABILITADO
                        if(rbNo0.Checked)
                        {
                            Rpta = NContrato.SuspencionContrato_modificar(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIDfolio.Text.Trim()));
                            this.MensajeAlerta("Al Susepnder el Servicio; El Contrato queda DESHABILIATDO ");

                            Rpta = NActividad.SuspencionActividad_modificar(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIDfolio.Text.Trim()));
                            this.MensajeAlerta("Al Susepnder el Servicio; La Actividad queda DESHABILIATDA ");

                            Rpta = NServicio.DeshabiltarServicio(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIDfolio.Text.Trim()));

                            this.MensajeAlerta("Al Susepnder el Servicio; El Servicio queda DESHABILIATDO ");
                        }
                        //ACTIVO
                        if(rbSi1.Checked)
                        {
                            Rpta = NContrato.editarContratoActivo(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIDfolio.Text.Trim()));
                            this.MensajeAlerta("Al Activar el Servicio; El Contrato queda ACTIVO ");

                            Rpta = NActividad.editarActividadHabilitada(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIDfolio.Text.Trim()));
                            this.MensajeAlerta("Al Activar el Servicio; LA Actividad queda ACTIVO ");

                            Rpta = NServicio.HabilitarServicio(txtRutUsuario.Text.Trim(), Convert.ToInt32(txtIDfolio.Text.Trim()));
                            this.MensajeAlerta("Al Activar el Servicio; El Servicio queda ACTIVO ");
                        }
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
        private void dateFechaUPDS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbSi1_CheckedChanged(object sender, EventArgs e)
        {
            estado = 1;
        }

        private void rbNo0_CheckedChanged(object sender, EventArgs e)
        {
            estado = 0;
        }

        private void rbSI_1_CheckedChanged(object sender, EventArgs e)
        {
            pagado = 1;
        }

        private void rbNO_0_CheckedChanged(object sender, EventArgs e)
        {
            pagado = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtIDeditarS_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtIDfolio_KeyPress(object sender, KeyPressEventArgs e)
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

