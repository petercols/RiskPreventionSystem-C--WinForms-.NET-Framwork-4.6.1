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
    public partial class frmEmpresa : Form
    {
        //VARIABLES LOCALES - METODOS
        private string rutUsuarioAntiguo;
        private string rutUsuario;
        private string rutEmpresa;

        public frmEmpresa()
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
            else if(char.IsSeparator(V.KeyChar))
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

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NEmpresa.Listar();
                this.Formato();
                lblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;

            DgvListado.Columns[1].Width = 80;
            DgvListado.Columns[1].HeaderText = "Rut Cliente";

            DgvListado.Columns[2].Width = 80;
            DgvListado.Columns[2].HeaderText = "Nombre";

            DgvListado.Columns[3].Width = 80;
            DgvListado.Columns[3].HeaderText = "Apellido";

            DgvListado.Columns[4].Width = 80;
            DgvListado.Columns[4].HeaderText = "Telefono";

            DgvListado.Columns[5].Width = 80;
            DgvListado.Columns[5].HeaderText = "Correo";

            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Domicilio";

            DgvListado.Columns[7].Width = 80;
            DgvListado.Columns[7].HeaderText = "Habilitado";

            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Rut Empresa";

            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[9].HeaderText = "Razon Social";

            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[10].HeaderText = "Direccion Empresa";

            DgvListado.Columns[11].Width = 100;
            DgvListado.Columns[11].HeaderText = "Telefono Empresa";

            DgvListado.Columns[12].Width = 100;
            DgvListado.Columns[12].HeaderText = "Correo Empresa";

            DgvListado.Columns[13].Width = 100;
            DgvListado.Columns[13].HeaderText = "Web Empresa";

            DgvListado.Columns[14].Width = 100;
            DgvListado.Columns[14].HeaderText = "Tipo Usuario";

            DgvListado.Columns[0].Visible = false;
            btnDeshabilitar.Visible = false;
         
            chkboxSeleccionar.Checked = false;
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {

            this.Listar();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutUsuario.Text == string.Empty || txtContraseña.Text == string.Empty || txtTipo.Text == string.Empty || txtNombreUsuario.Text == string.Empty || txtApellidoUsuario.Text == string.Empty || txtFonoUsuario.Text == string.Empty || txtCorreoUsuario.Text == string.Empty || txtDomicilioUsuario.Text == string.Empty || txtRutEmpresa.Text == string.Empty || txtRazonSocial.Text == string.Empty || txtDirecEmpresa.Text == string.Empty || txtTelefono.Text == string.Empty || txtCorreo.Text == string.Empty || txtWeb.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRutUsuario, "Ingrese un Rut.");                 
                    ErrorIcono.SetError(txtContraseña, "Ingrese una Contraseña.");
                    ErrorIcono.SetError(txtTipo, "Ingrese un Tipo de Usuario.");
                    ErrorIcono.SetError(txtNombreUsuario, "Ingrese un Nombre de Usuario.");
                    ErrorIcono.SetError(txtApellidoUsuario, "Ingrese un Apellido de Usuario.");
                    ErrorIcono.SetError(txtFonoUsuario, "Ingrese Fono de Usuario.");
                    ErrorIcono.SetError(txtCorreoUsuario, "Ingrese un Correo de Usuario.");
                    ErrorIcono.SetError(txtDomicilioUsuario, "Ingrese un Domicilio de Usuario.");
                    ErrorIcono.SetError(txtRutEmpresa, "Ingrese Rut de Empresa.");
                    ErrorIcono.SetError(txtRazonSocial, "Ingrese Razon Empresa.");
                    ErrorIcono.SetError(txtDirecEmpresa, "Ingrese Direccion Empresa.");
                    ErrorIcono.SetError(txtTelefono, "Ingrese telefono Empresa.");
                    ErrorIcono.SetError(txtCorreo, "Ingrese Correo Empresa.");
                    ErrorIcono.SetError(txtWeb, "Ingrese pagina web Empresa.");
                }
                if (!validarRutOLD(txtRutUsuario.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else if (!validarRutOLD(txtRutEmpresa.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else            
                {
                        Rpta = NEmpresa.Insertar(txtRutUsuario.Text.Trim(), txtContraseña.Text.Trim(), txtTipo.Text.Trim(), txtNombreUsuario.Text.Trim(), txtApellidoUsuario.Text.Trim(), Convert.ToInt32(txtFonoUsuario.Text.Trim()), txtCorreoUsuario.Text.Trim(), txtDomicilioUsuario.Text.Trim(), txtRutEmpresa.Text.Trim(), txtRazonSocial.Text.Trim(), txtDirecEmpresa.Text.Trim(), Convert.ToInt32(txtTelefono.Text.Trim()), txtCorreo.Text.Trim(), txtWeb.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó de forma correcta el Registro de la Empresa");
                            this.Limpiar();
                            this.Listar();
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

        private void Limpiar()
        {
            txtRutUsuario.Clear();
            txtContraseña.Clear();
            //txtTipo.Clear();

            txtRutEmpresa.Clear();
            txtApellidoUsuario.Clear();
            txtNombreUsuario.Clear();
            txtFonoUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtDomicilioUsuario.Clear();

            txtRutEmpresa.Clear();
            txtRazonSocial.Clear();
            txtDirecEmpresa.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtWeb.Clear();

            btnAgregar.Visible = true;
            ErrorIcono.Clear();

          
        }

        private void LimpiarUpdate()
        {
            txtRutUserED.Clear();
            txtDirecEmpreEditar.Clear();
            txtFonoEmpresaED.Clear();
            txtCorreoEmpresaED.Clear();
            txtWebEmpresaED.Clear();
            txtRazonEmpresaED.Clear();

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRutUserED.Text == string.Empty || txtDirecEmpreEditar.Text == string.Empty || txtFonoEmpresaED.Text == string.Empty|| txtCorreoEmpresaED.Text == string.Empty||txtWebEmpresaED.Text == string.Empty || txtRazonEmpresaED.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRutUserED, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtDirecEmpreEditar, "Ingrese una Direccion.");
                    ErrorIcono.SetError(txtFonoEmpresaED, "Ingrese un Telefono.");
                    ErrorIcono.SetError(txtCorreoEmpresaED, "Ingrese un Correo Empresa.");
                    ErrorIcono.SetError(txtWebEmpresaED, "Ingrese un Pagina Web.");
                }
                if (!validarRutOLD(txtRutUserED.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else       
                {
                    Rpta = NEmpresa.Actualizar(this.rutUsuarioAntiguo,txtRutUserED.Text.Trim(), txtRazonEmpresaED.Text.Trim(), txtDirecEmpreEditar.Text.Trim(),Convert.ToInt32(txtFonoEmpresaED.Text), txtCorreoEmpresaED.Text.Trim(), txtWebEmpresaED.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro de Empresa");
                        this.LimpiarUpdate();
                        this.Listar();
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
 
        private void BuscarRut()
        {    
            try
            {
                if (txtRutBuscarLIST.Text == string.Empty)
                {
                    this.MensajeError("Ingrese Rut!");
                }
                else
                DgvListado.DataSource = NEmpresa.Buscar(txtRutBuscarLIST.Text);
                //this.Formato();
                lblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListado.DataSource = NEmpresa.Listar();
                this.Formato();
               
                lblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarLIST_Click(object sender, EventArgs e)
        {
            this.BuscarRut();
        }

        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            frmDeshabilitarCliente frmDesha = new frmDeshabilitarCliente();
            frmDesha.Show();
        }

        private void chkboxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                btnDeshabilitar.Visible = true;
                
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btnDeshabilitar.Visible = false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkboxSeleccionar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkboxSeleccionar.Value = !Convert.ToBoolean(chkboxSeleccionar.Value);
            }
        }

        private void frmEmpresa_DoubleClick(object sender, EventArgs e)
        {
            //error de click
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizarEmpresa.Visible = true;

                this.rutUsuarioAntiguo = Convert.ToString(DgvListado.CurrentRow.Cells["Rut Cliente"].Value);
                txtRutUserED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Rut Cliente"].Value);

                txtDirecEmpreEditar.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion Empresa"].Value);
                txtFonoEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono Empresa"].Value);
                txtCorreoEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Correo Empresaa"].Value);
                txtWebEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Web Empresa"].Value);
                txtRazonEmpresaED.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Razon Social"].Value);


                tabGeneral.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una Fila" + "| Error: " + ex.Message);
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //colores

            //if (this.DgvListado.Columns[e.ColumnIndex].Name == "Habilitado")

            //{

            //    // aplicar colores a celda en estado normal

            //    e.CellStyle.BackColor = Color.MediumTurquoise;

            //    e.CellStyle.ForeColor = Color.DarkOrchid;

            //    // aplicar colores a celda en estado seleccionado

            //    e.CellStyle.SelectionBackColor = Color.DarkOliveGreen;

            //    e.CellStyle.SelectionForeColor = Color.Yellow;


            //    // establecer alineación del texto

            //    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //}


            // Set the background to red for negative values in the Balance column.
            if (DgvListado.Columns[e.ColumnIndex].Name.Equals("Habilitado"))
            {
                Int32 intValue;
                if (Int32.TryParse((String)e.Value, out intValue) &&
                    (intValue == 1))
                {
                    e.CellStyle.BackColor = Color.ForestGreen;
                    e.CellStyle.SelectionBackColor = Color.Green;
                }

                Int32 intValue2;
                if (Int32.TryParse((String)e.Value, out intValue2) &&
                    (intValue2 == 0))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
            // Replace string values in the Priority column with images.
            if (DgvListado.Columns[e.ColumnIndex].Name.Equals("Habilitado"))
            {
                // Ensure that the value is a string.
                String stringValue = e.Value as string;
                if (stringValue == null) return;

                // Set the cell ToolTip to the text value.
                DataGridViewCell cell = DgvListado[e.ColumnIndex, e.RowIndex];
                cell.ToolTipText = stringValue;

                // Replace the string value with the image value.
                switch (stringValue)
                {
                    case "1":
                        e.Value = "Habilitado";
                        break;
                    case "0":
                        e.Value = "Deshabilitado";
                        break;
                }
            }
        }

        private void txtFonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }
        //VALIDAR RUT USUARIO AGREGAR
        private void txtRutUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutUsuario.Text))
            {
                this.MensajeError("Rut invalido!");
            }
        }

        private void txtRutEmpresa_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutEmpresa.Text))
            {
                this.MensajeError("Rut invalido!");
            }
        }

        private void txtRutUserED_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutUserED.Text))
            {
                this.MensajeError("Rut invalido!");
            }
        }

        private void txtRutBuscarLIST_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutBuscarLIST.Text))
            {
                this.MensajeError("Rut invalido!");
            }
        }

        private void txtFonoEmpresaED_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }
    }
}
