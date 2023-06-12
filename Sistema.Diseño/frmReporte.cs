using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Datos;
using Sistema.Negocio;

namespace Sistema.Diseño
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
           
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

        private void txtRutUsuario_Validated(object sender, EventArgs e)
        {
            if (!validarRutOLD(txtRutUsuario.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
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
            txtNombreServicio.Clear();
            txtValorTotalPago.Clear();
            txtDescServicio.Clear();
            txtDescActividad.Clear();
            txtDescPago.Clear();

            txtNombreInforme.Clear();
            txtDescripInforme.Clear();
            txtArchivo.Clear();
            //fechaEmision
            btnCrearReporte.Visible = true;
            ErrorIcono.Clear();
        }

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
                try
                {
                    string Rpta = "";
                        if (txtRutUsuario.Text == string.Empty || txtNombreInforme.Text == string.Empty || txtDescripInforme.Text == string.Empty || fechaEmision.Text == string.Empty || txtNombreServicio.Text == string.Empty || txtValorTotalPago.Text == string.Empty || txtDescServicio.Text == string.Empty || cmbNombreTipoActividad.Text == string.Empty || txtDescActividad.Text == string.Empty || txtDescPago.Text == string.Empty || dateInicioALL.Text == string.Empty || dateTerminoALL.Text == string.Empty)
                        {
                            this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                            ErrorIcono.SetError(txtRutUsuario, "Ingrese un Rut.");
                            ErrorIcono.SetError(txtNombreInforme, "Ingrese una Nombre de informe.");
                            ErrorIcono.SetError(txtArchivo, "Ingrese una Nombre de archivo");
                            ErrorIcono.SetError(txtDescripInforme, "Ingrese una Descripcion de informe");
                            ErrorIcono.SetError(fechaEmision, "Seleccione una Fecha");

                            ErrorIcono.SetError(txtNombreServicio, "Ingrese un Nombre de Servicio.");
                            ErrorIcono.SetError(txtValorTotalPago, "Ingrese un Valor para el Pago.");
                            ErrorIcono.SetError(txtDescServicio, "Ingrese una Descripcion para el Servicio.");
                            ErrorIcono.SetError(cmbNombreTipoActividad, "Seleccione un Nombre de Tipo Actividad");
                            ErrorIcono.SetError(txtDescActividad, "Ingrese una Descripcion para la Actividad.");
                            ErrorIcono.SetError(txtDescPago, "Ingrese una Descripcion para el Pago.");
                            ErrorIcono.SetError(dateInicioALL, "Seleccione una Fecha de Inicio.");
                            ErrorIcono.SetError(dateTerminoALL, "Seleccione una Fecha de Termino.");
                        }
                        if (!validarRutOLD(txtRutUsuario.Text))
                        {
                            this.MensajeError("Rut invalido!");
                        }
                        else
                        {
                            Rpta = NReporte.InsertarReporte(txtRutUsuario.Text.Trim(), txtNombreInforme.Text.Trim(), txtArchivo.Text.Trim(), txtDescripInforme.Text.Trim(), Convert.ToDateTime(fechaEmision.Text.Trim()), txtNombreServicio.Text.Trim(), Convert.ToInt32(txtValorTotalPago.Text.Trim()), txtDescServicio.Text.Trim(), cmbNombreTipoActividad.Text.Trim(), txtDescActividad.Text.Trim(), txtDescPago.Text.Trim(), Convert.ToDateTime(dateInicioALL.Text.Trim()), Convert.ToDateTime(dateTerminoALL.Text.Trim()));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se insertó de forma correcta la creacion de Reporte PDF");
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

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteFolder reporte = new Reportes.frmReporteFolder();
            reporte.ShowDialog();
        }

        private void txtRutUsuario_Validating(object sender, CancelEventArgs e)
        {

            if (!validarRutOLD(txtRutUsuario.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }

        private void txtValorTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }
    }
}
