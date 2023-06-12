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
    public partial class frmContrato : Form
    {
        public frmContrato()
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

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarC()
        {
            txtRutC.Clear();
            //dateFechaC
            txtDiasC.Clear();
            txtSueldoC.Clear();

            btnAgregarC.Visible = true;
            ErrorIcono.Clear();

        }

        private void LimpiarSC()
        {
           txtRutSC.Clear();
           txtNombreServicioSC.Clear();
           txtValorServicioSC.Clear();
           txtDescripServicioSC.Clear();
           // dateInicioSC.Visible 
           //dateTerminoSC.Visible

            btnAgregarSC.Visible = true;
            ErrorIcono.Clear();

        }

        private void LimpiarFM()
        {
            txtRutSC.Clear();
            txtNombreServicioSC.Clear();

            //btnAgregarFM,.Visible = true;
            ErrorIcono.Clear();

        }

        private void Formato()
        {
            DgvListadoContrato.Columns[0].Visible = false;

            DgvListadoContrato.Columns[1].Width = 80;
            DgvListadoContrato.Columns[1].HeaderText = "Folio Contrato";

            DgvListadoContrato.Columns[2].Width = 80;
            DgvListadoContrato.Columns[2].HeaderText = "Id Tipo Usuario";

            DgvListadoContrato.Columns[3].Width = 80;
            DgvListadoContrato.Columns[3].HeaderText = "Monto Pago";

            DgvListadoContrato.Columns[4].Width = 80;
            DgvListadoContrato.Columns[4].HeaderText = "Plazo Contrato";

            DgvListadoContrato.Columns[5].Width = 80;
            DgvListadoContrato.Columns[5].HeaderText = "Monto Pago";

            DgvListadoContrato.Columns[6].Width = 100;
            DgvListadoContrato.Columns[6].HeaderText = "Modificado";

            DgvListadoContrato.Columns[7].Width = 80;
            DgvListadoContrato.Columns[7].HeaderText = "Estado";

          
            DgvListadoContrato.Columns[0].Visible = false;
            btnSuspenderC.Visible = false;

            chkboxSeleccionarC.Checked = false;
        }

        private void Listar()
        {
            try
            {
                DgvListadoContrato.DataSource = NContrato.Listar();
                this.Formato();
                lblTotalC.Text = "Total Registros: " + Convert.ToString(DgvListadoContrato.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void LimpiarUpdate()
        {
            //txtRutUserED.Clear();
            //txtDirecEmpreEditar.Clear();
            //txtFonoEmpresaED.Clear();
            //txtCorreoEmpresaED.Clear();
            //txtWebEmpresaED.Clear();
            //txtRazonEmpresaED.Clear();

        }

        private void BuscarRut()
        {
            try
            {
                if (txtRutBuscarC.Text == string.Empty)
                {
                    this.MensajeError("Ingrese Rut!");
                }
                else
                    DgvListadoContrato.DataSource = NContrato.Buscar(txtRutBuscarC.Text);
                //this.Formato();
                lblTotalC.Text = "Total Registros: " + Convert.ToString(DgvListadoContrato.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarRutC_Click(object sender, EventArgs e)
        {
            this.BuscarRut();
        }

        private void chkboxSeleccionarC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSeleccionarC.Checked)
            {
                DgvListadoContrato.Columns[0].Visible = true;
                btnSuspenderC.Visible = true;

            }
            else
            {
                DgvListadoContrato.Columns[0].Visible = false;
                btnSuspenderC.Visible = false;
            }
        }

        private void DgvListadoContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListadoContrato.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkboxSeleccionarC = (DataGridViewCheckBoxCell)DgvListadoContrato.Rows[e.RowIndex].Cells["Seleccionar"];
                chkboxSeleccionarC.Value = !Convert.ToBoolean(chkboxSeleccionarC.Value);
            }
        }

        private void btnSuspenderC_Click(object sender, EventArgs e)
        {
            frmSuspenderContrato frmSuspender = new frmSuspenderContrato();
            frmSuspender.Show();
        }

        private void lblTotalC_Click(object sender, EventArgs e)
        {

        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            this.Location = new Point(235, 0);
            this.Size = new Size(1254, 502);
            this.Listar();
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutC.Text == string.Empty || dateFechaC.Text == string.Empty || txtDiasC.Text == string.Empty || txtSueldoC.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");

                    ErrorIcono.SetError(txtRutC, "Ingrese un Rut.");
                    ErrorIcono.SetError(dateFechaC, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtDiasC, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtSueldoC, "Ingrese un Rut.");
                }
                if (!validarRutOLD(txtRutC.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    Rpta = NContrato.Insertar(txtRutC.Text.Trim(), Convert.ToDateTime(dateFechaC.Text.Trim()),txtDiasC.Text.Trim(), Convert.ToInt32(txtSueldoC.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el Registro del Contrato");
                        this.LimpiarC();
                        this.Listar();
                       // this.ListarDgv();
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

        private void btnAgregarSC_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutSC.Text == string.Empty || txtNombreServicioSC.Text == string.Empty || txtValorServicioSC.Text == string.Empty || txtDescripServicioSC.Text == string.Empty || dateInicioSC.Text == string.Empty || dateTerminoSC.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");

                    ErrorIcono.SetError(txtRutSC, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtNombreServicioSC, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtValorServicioSC, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtDescripServicioSC, "Ingrese un Rut.");
                    ErrorIcono.SetError(dateInicioSC, "Ingrese un Rut.");
                    ErrorIcono.SetError(dateTerminoSC, "Ingrese un Rut.");

                }
                if (!validarRutOLD(txtRutSC.Text))
                {
                    this.MensajeError("Rut invalido!");
                }

                else 
                {
                    Rpta = NServicio.Insertar(txtRutSC.Text.Trim(), txtNombreServicioSC.Text.Trim(), Convert.ToInt32(txtValorServicioSC.Text.Trim()), txtDescripServicioSC.Text.Trim(), Convert.ToDateTime(dateInicioSC.Text.Trim()), Convert.ToDateTime(dateTerminoSC.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el Registro del Servicio de Contrato");
                        this.LimpiarSC();
                        this.Listar();
                        // this.ListarDgv();
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

        private void btnAgregarFM_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutFM.Text == string.Empty || txtMontoFM.Text == string.Empty || dateAbonoFM.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");

                    ErrorIcono.SetError(txtRutFM, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtMontoFM, "Ingrese un Rut.");
                    ErrorIcono.SetError(dateAbonoFM, "Ingrese un Rut.");
                }
                if (!validarRutOLD(txtRutFM.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    Rpta = NFondoMonetario.Insertar(txtRutFM.Text.Trim(), Convert.ToInt32(txtMontoFM.Text.Trim()), Convert.ToDateTime(dateAbonoFM.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el Registro de Fondo Monetario");
                        this.LimpiarSC();
                        this.Listar();
                        // this.ListarDgv();
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

        private void DgvListadoContrato_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    this.Limpiar();
            //    btnActualizarEmpresa.Visible = true;

            //    this.rutUsuarioAntiguo = Convert.ToString(DgvListado.CurrentRow.Cells["Rut Cliente"].Value);
            //    txtRutUserED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Rut Cliente"].Value);

            //    txtDirecEmpreEditar.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion Empresa"].Value);
            //    txtFonoEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono Empresa"].Value);
            //    txtCorreoEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Correo Empresaa"].Value);
            //    txtWebEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Web Empresa"].Value);
            //    txtRazonEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Razon Social"].Value);


            //    tabGeneral.SelectedIndex = 2;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Seleccione una Fila" + "| Error: " + ex.Message);
            //}
        }

        private void btnActualizarRegistrosC_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListadoContrato.DataSource = NContrato.Listar();
                this.Formato();

                lblTotalC.Text = "Total Registros: " + Convert.ToString(DgvListadoContrato.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtDiasC_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtSueldoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtMontoFM_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtValorServicioSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtRutC_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutC.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutC.Focus();
            }
        }

        private void txtRutFM_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutFM.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutFM.Focus();
            }
        }

        private void txtRutSC_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutSC.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutSC.Focus();
            }
        }

        private void txtRutBuscarC_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutBuscarC.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutBuscarC.Focus();
            }
        }
    }
    
}
