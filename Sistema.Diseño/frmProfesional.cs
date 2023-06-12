
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
using Sistema.Datos;

namespace Sistema.Diseño
{
    public partial class frmProfesional : Form
    {
        //Var para validar existencia de rut cliente - profesional
        string rutUsuario;

        public frmProfesional()
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

        //VALIDAR RUT PROFESIONAL AGREGAR
        private void txtRutUsuario_Validated(object sender, EventArgs e)
        {
            if (!validarRutOLD(txtRutUsuario.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }

        //VALIDAR RUT  PROFESIONAL BUSCAR
        private void txtBuscarProf_Validated(object sender, EventArgs e)
        {
            if (!validarRutOLD(txtBuscarProf.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }
        
        //VALIDAR RUT  PROFESIONAL EDITAR
        private void txtRutUserP_Validated(object sender, EventArgs e)
        {
            if (!validarRutOLD(txtRutUserP.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }

        private void frmProfesional_Load(object sender, EventArgs e)
        {
            //240
            this.Location = new Point(235,0);

            this.Size = new Size(1254,502);
            
            this.ListarDgv();

        }

        private void ListarDgv()
        {
            try
            {
                DgvListadoProfesional.DataSource = NUsuario.Listar();
                this.Formato();
                lblTotalRegProf.Text = "Total Registros: " + Convert.ToString(DgvListadoProfesional.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarRut()
        {
            try
            {
                if (txtBuscarProf.Text == string.Empty)
                {
                    this.MensajeError("Ingrese Rut!");
                }
                else
                    DgvListadoProfesional.DataSource = NUsuario.Buscar(txtBuscarProf.Text);
                //this.Formato();
                lblTotalRegProf.Text = "Total Registros: " + Convert.ToString(DgvListadoProfesional.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListadoProfesional.Columns[0].Visible = false;

            DgvListadoProfesional.Columns[1].Width = 80;
            DgvListadoProfesional.Columns[1].HeaderText = "Rut Profesional";

            DgvListadoProfesional.Columns[2].Width = 80;
            DgvListadoProfesional.Columns[2].HeaderText = "Nombre";

            DgvListadoProfesional.Columns[3].Width = 80;
            DgvListadoProfesional.Columns[3].HeaderText = "Apellido";

            DgvListadoProfesional.Columns[4].Width = 80;
            DgvListadoProfesional.Columns[4].HeaderText = "Telefono";

            DgvListadoProfesional.Columns[5].Width = 80;
            DgvListadoProfesional.Columns[5].HeaderText = "Correo";

            DgvListadoProfesional.Columns[6].Width = 100;
            DgvListadoProfesional.Columns[6].HeaderText = "Domicilio";

            DgvListadoProfesional.Columns[7].Width = 80;
            DgvListadoProfesional.Columns[7].HeaderText = "Habilitado";

            DgvListadoProfesional.Columns[8].Width = 100;
            DgvListadoProfesional.Columns[8].HeaderText = "Profesion";


            btnDeshabilitarPro.Visible = false;

            chkBoxSelecionarPro.Checked = false;
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
            txtContraseña.Clear();
            txtNombreUsuario.Clear();
            txtApellidoUsuario.Clear();
            txtFonoUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtDomicilioUsuario.Clear();
            btnAgregarProfesional.Visible = true;
            ErrorIcono.Clear();
        }

        private void LimpiarUpdate()
        {
            txtRutUserP.Clear();
            txtTelefonoUsuarioP.Clear();
            txtCorreoUsuarioP.Clear();
            txtDomicilioUsuarioP.Clear();
        }

        private void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutUsuario.Text == string.Empty || txtContraseña.Text == string.Empty || txtTipo.Text == string.Empty || txtNombreUsuario.Text == string.Empty || txtApellidoUsuario.Text == string.Empty || txtFonoUsuario.Text == string.Empty || txtCorreoUsuario.Text == string.Empty || txtDomicilioUsuario.Text == string.Empty || txtProfesion.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");

                    ErrorIcono.SetError(txtRutUsuario, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtContraseña, "Ingrese una Contraseña.");

                    ErrorIcono.SetError(txtTipo, "Seleccione Profesional");

                    ErrorIcono.SetError(txtNombreUsuario, "Ingrese un Nombre de Usuario.");
                    ErrorIcono.SetError(txtApellidoUsuario, "Ingrese un Apellido de Usuario.");
                    ErrorIcono.SetError(txtFonoUsuario, "Ingrese Fono de Usuario.");
                    ErrorIcono.SetError(txtCorreoUsuario, "Ingrese un Correo de Usuario.");
                    ErrorIcono.SetError(txtDomicilioUsuario, "Ingrese un Domicilio de Usuario.");

                    ErrorIcono.SetError(txtProfesion, "Ingrese un la Profesion del Usuario.");
                }
                if (!validarRutOLD(txtRutUsuario.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {                
                        Rpta = NUsuario.InsertarProfesional(txtRutUsuario.Text.Trim(), txtContraseña.Text.Trim(), txtTipo.Text.Trim(), txtNombreUsuario.Text.Trim(), txtApellidoUsuario.Text.Trim(), Convert.ToInt32(txtFonoUsuario.Text.Trim()), txtCorreoUsuario.Text.Trim(), txtDomicilioUsuario.Text.Trim(), txtProfesion.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó de forma correcta el Registro de la Empresa");
                            this.Limpiar();
                            this.ListarDgv();
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

        private void btnActualizarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutUserP.Text == string.Empty || txtTelefonoUsuarioP.Text == string.Empty || txtCorreoUsuarioP.Text == string.Empty || txtDomicilioUsuarioP.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRutUserP, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtTelefonoUsuarioP, "Ingrese un Telefono.");
                    ErrorIcono.SetError(txtCorreoUsuarioP, "Ingrese una Correo.");
                    ErrorIcono.SetError(txtDomicilioUsuarioP, "Ingrese un Domicilio.");     
                }
                if (!validarRutOLD(txtRutUserP.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                    
                {
                    Rpta = NUsuario.Actualizar(txtRutUserP.Text.Trim(), Convert.ToInt32(txtTelefonoUsuarioP.Text), txtCorreoUsuarioP.Text.Trim(), txtDomicilioUsuarioP.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro de Profesional");
                        this.LimpiarUpdate();
                        this.ListarDgv();
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

        private void btnBuscarProf_Click(object sender, EventArgs e)
        {
            this.BuscarRut();
        }

        private void btnActualizarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListadoProfesional.DataSource = NUsuario.Listar();
                this.Formato();
                
                lblTotalRegProf.Text = "Total Registros: " + Convert.ToString(DgvListadoProfesional.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDeshabilitarPro_Click(object sender, EventArgs e)
        {
            frmDeshabilitarProfesional frmDesha = new frmDeshabilitarProfesional();
            frmDesha.Show();
        }

        private void chkBoxSelecionarPro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSelecionarPro.Checked)
            {
                DgvListadoProfesional.Columns[0].Visible = true;
                btnDeshabilitarPro.Visible = true;
            }
            else
            {
                DgvListadoProfesional.Columns[0].Visible = false;
                btnDeshabilitarPro.Visible = false;
            }
        }

        private void DgvListadoProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListadoProfesional.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkBoxSelecionarPro = (DataGridViewCheckBoxCell)DgvListadoProfesional.Rows[e.RowIndex].Cells["Seleccionar"];
                chkBoxSelecionarPro.Value = !Convert.ToBoolean(chkBoxSelecionarPro.Value);
            }
        }

        private void DgvListadoProfesional_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtFonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtTelefonoUsuarioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtRutUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutUsuario.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }

        private void txtBuscarProf_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtBuscarProf.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }

        private void txtRutUserP_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutUserP.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRut.Focus();
            }
        }
    }
}
