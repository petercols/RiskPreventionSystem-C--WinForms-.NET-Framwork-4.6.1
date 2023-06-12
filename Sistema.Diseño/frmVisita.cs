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
    public partial class frmVisita : Form
    {
        int estado;
        public frmVisita()
        {
            InitializeComponent();
        }

        private void frmVisita_Load(object sender, EventArgs e)
        {
            this.ListarEditar();
            this.ListarAsistencia();
            this.ListarChecklist();
            this.ListarEliminarVista();

        }
        private void FormatoEditar()
        {
            //dataGridEditarVisita.Columns[0].Visible = false;

            dataGridEditarVisita.Columns[0].Width = 80;
            dataGridEditarVisita.Columns[0].HeaderText = "Id Actividad";

            dataGridEditarVisita.Columns[1].Width = 80;
            dataGridEditarVisita.Columns[1].HeaderText = "Id Servicio";

            dataGridEditarVisita.Columns[2].Width = 80;
            dataGridEditarVisita.Columns[2].HeaderText = "Estado";

            dataGridEditarVisita.Columns[3].Width = 80;
            dataGridEditarVisita.Columns[3].HeaderText = "Rut Usuario";

            dataGridEditarVisita.Columns[4].Width = 80;
            dataGridEditarVisita.Columns[4].HeaderText = "Nombre Actividad";

            dataGridEditarVisita.Columns[5].Width = 80;
            dataGridEditarVisita.Columns[5].HeaderText = "Fecha Inicio";

            dataGridEditarVisita.Columns[6].Width = 80;
            dataGridEditarVisita.Columns[6].HeaderText = "Fecha Termino";

            //dataGridEditarVisita.Columns[0].Visible = false;
        }

        private void ListarEditar()
        {
            try
            {
                dataGridEditarVisita.DataSource = NTipo_Actividad.ListarEditarVisita();
                this.FormatoEditar();
                lblTotalE.Text = "Total Registros: " + Convert.ToString(dataGridEditarVisita.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoEliminarVista()
        {
            //dataGridEliminarVista.Columns[0].Visible = false;


            dataGridEliminarVista.Columns[0].Width = 80;
            dataGridEliminarVista.Columns[0].HeaderText = "Id Actividad";

            dataGridEliminarVista.Columns[1].Width = 80;
            dataGridEliminarVista.Columns[1].HeaderText = "Id Servicio";

            dataGridEliminarVista.Columns[2].Width = 80;
            dataGridEliminarVista.Columns[2].HeaderText = "Estado";

            dataGridEliminarVista.Columns[3].Width = 80;
            dataGridEliminarVista.Columns[3].HeaderText = "Rut Usuario";

            dataGridEliminarVista.Columns[4].Width = 80;
            dataGridEliminarVista.Columns[4].HeaderText = "Nombre Actividad";

            dataGridEliminarVista.Columns[5].Width = 80;
            dataGridEliminarVista.Columns[5].HeaderText = "Fecha Inicio";

            dataGridEliminarVista.Columns[6].Width = 80;
            dataGridEliminarVista.Columns[6].HeaderText = "Fecha Termino";


            //dataGridEliminarVista.Columns[0].Visible = false;
        }

        private void ListarEliminarVista()
        {
            try
            {
                dataGridEliminarVista.DataSource = NTipo_Actividad.ListarEliminarVisita();
                this.FormatoEliminarVista();
                lblTotalEliminar.Text = "Total Registros: " + Convert.ToString(dataGridEliminarVista.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoAsistencia()
        {
 

            dataGridAsistencia.Columns[0].Width = 150;
            dataGridAsistencia.Columns[0].HeaderText = "Descripcion Asistencia";

            dataGridAsistencia.Columns[1].Width = 80;
            dataGridAsistencia.Columns[1].HeaderText = "Estado Asistencia";

            dataGridAsistencia.Columns[2].Width = 80;
            dataGridAsistencia.Columns[2].HeaderText = "Fecha Emision";

            dataGridAsistencia.Columns[3].Width = 80;
            dataGridAsistencia.Columns[3].HeaderText = "Estado Actividad";

            dataGridAsistencia.Columns[4].Width = 80;
            dataGridAsistencia.Columns[4].HeaderText = "Nombre Actividad";
        
            dataGridAsistencia.Columns[5].Width = 150;
            dataGridAsistencia.Columns[5].HeaderText = "Descripcion Actividad";

            dataGridAsistencia.Columns[6].Width = 80;
            dataGridAsistencia.Columns[6].HeaderText = "Fecha Inicio";

            dataGridAsistencia.Columns[7].Width = 80;
            dataGridAsistencia.Columns[7].HeaderText = "Fecha Termino";

        }

        private void ListarAsistencia()
        {
            try
            {
                dataGridAsistencia.DataSource = NTipo_Actividad.ListarAsistencia();
                this.FormatoAsistencia();
                lblTotalA.Text = "Total Registros: " + Convert.ToString(dataGridAsistencia.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoChecklist()
        {         
            dataGridChecklist.Columns[0].Width = 80;
            dataGridChecklist.Columns[0].HeaderText = "Rut Usuario";

            dataGridChecklist.Columns[1].Width = 80;
            dataGridChecklist.Columns[1].HeaderText = "Archivo";

            dataGridChecklist.Columns[2].Width = 80;
            dataGridChecklist.Columns[2].HeaderText = "Nombre Checklist";

            dataGridChecklist.Columns[3].Width = 150;
            dataGridChecklist.Columns[3].HeaderText = "Descripcion Checklist";

            dataGridChecklist.Columns[4].Width = 80;
            dataGridChecklist.Columns[4].HeaderText = "Fecha Emision";
        }

        private void ListarChecklist()
        {
            try
            {
                dataGridChecklist.DataSource = NTipo_Actividad.ListarCheckList();
                this.FormatoChecklist();
                lblTotalC.Text = "Total Registros: " + Convert.ToString(dataGridChecklist.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            txtRut.Clear();
            txtNombreServicio.Clear();
            txtValorTotalPago.Clear();
            txtDescServicio.Clear();
            //cmbNombreTipoActividad
            txtDescActividad.Clear();
            txtDescPago.Clear();
            //dateInicioALL.Clear();
            //dateTerminoALL.Clear();
            btnCrearActividadALL.Visible = true;
            ErrorIcono.Clear();


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

        private void btnCrearActividadALL_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtRut.Text == string.Empty || txtNombreServicio.Text == string.Empty || txtValorTotalPago.Text == string.Empty || txtDescServicio.Text == string.Empty || cmbNombreTipoActividad.Text == string.Empty || txtDescActividad.Text == string.Empty || txtDescPago.Text == string.Empty || dateInicioALL.Text == string.Empty || dateTerminoALL.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtRut, "Ingrese un Rut.");
                    ErrorIcono.SetError(txtNombreServicio, "Ingrese un Nombre de Servicio.");
                    ErrorIcono.SetError(txtValorTotalPago, "Ingrese un Valor para el Pago.");
                    ErrorIcono.SetError(txtDescServicio, "Ingrese una Descripcion para el Servicio.");
                    ErrorIcono.SetError(cmbNombreTipoActividad, "Seleccione un Nombre de Tipo Actividad");
                    ErrorIcono.SetError(txtDescActividad, "Ingrese una Descripcion para la Actividad.");
                    ErrorIcono.SetError(txtDescPago, "Ingrese una Descripcion para el Pago.");
                    ErrorIcono.SetError(dateInicioALL, "Seleccione una Fecha de Inicio.");
                    ErrorIcono.SetError(dateTerminoALL, "Seleccione una Fecha de Termino.");
                }
                if (!validarRutOLD(txtRut.Text))
                {
                    this.MensajeError("Rut invalido!");
                }
                else
                {
                    Rpta = NTipo_Actividad.InsertarActividadC(txtRut.Text.Trim(), txtNombreServicio.Text.Trim(), Convert.ToInt32(txtValorTotalPago.Text.Trim()), txtDescServicio.Text.Trim(), cmbNombreTipoActividad.Text.Trim(), txtDescActividad.Text.Trim(),txtDescPago.Text.Trim(), Convert.ToDateTime(dateInicioALL.Text.Trim()), Convert.ToDateTime(dateTerminoALL.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el Registro de la Empresa");
                        this.Limpiar();
                        this.ListarEditar();
                        this.ListarEliminarVista();
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

        private void btnEditarVisita_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdActividadE.Text == string.Empty || txtIdServicioE.Text == string.Empty || rb1Habilitado.Text == string.Empty || rb0Deshabilitado.Text == string.Empty || dateInicioE.Text == string.Empty || dateTerminoE.Text == string.Empty )
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtIdActividadE, "Ingrese un Id de Actividad");
                    ErrorIcono.SetError(txtIdServicioE, "Ingrese un Id de Servicio.");

                    ErrorIcono.SetError(rb1Habilitado, "Seleciona una Opcion.");
                    ErrorIcono.SetError(rb0Deshabilitado, "Seleciona una Opcion.");

                    ErrorIcono.SetError(dateInicioE, "Ingrese una Fecha.");
                    ErrorIcono.SetError(dateTerminoE, "Ingrese una Fecha.");
                }             
                else
                {
                    Rpta = NTipo_Actividad.EditarActividadVisita(Convert.ToInt32(txtIdActividadE.Text.Trim()), Convert.ToInt32(txtIdServicioE.Text.Trim()),this.estado , Convert.ToDateTime(dateInicioE.Text.Trim()), Convert.ToDateTime(dateTerminoE.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizo de forma correcta el Registro de la Visita");
                        this.Limpiar();
                        this.ListarEditar();
                        this.ListarEliminarVista();
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

        private void btnEliminarVisita_Click(object sender, EventArgs e)
        {

            try
            {
                string Rpta = "";
                if (txtIdVisita.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtIdVisita, "Ingrese un Id de Visita");
                }
                else
                {
                    Rpta = NTipo_Actividad.eliminarVisita(Convert.ToInt32(txtIdVisita.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Elimino de forma correcta el Registro de la Visita Ingresado");
                        this.Limpiar();
                        this.ListarEditar();
                        this.ListarEliminarVista();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void rb1Habilitado_CheckedChanged(object sender, EventArgs e)
        {
            estado = 1;
        }

        private void rb0Deshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            estado = 0;
        }

        private void txtValorTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtIdActividadE_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtIdServicioE_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtIdVisita_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }

        private void txtRut_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRut.Text))
            {
                this.MensajeError("Rut invalido!");
            }
        }
    }
}
