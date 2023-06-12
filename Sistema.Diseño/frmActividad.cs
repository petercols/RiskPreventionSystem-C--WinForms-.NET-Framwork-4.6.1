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
    public partial class frmActividad : Form
    {
        public frmActividad()
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
        private void LimpiarForzarCierre()
        {
            //txtEstado.Clear();
            //btnConfirmarE.Visible = true;
            //ErrorIcono.Clear();
        }
        private void Formato()
        {
            DgvListadoActividad.Columns[0].Visible = false;

            DgvListadoActividad.Columns[1].Width = 80;
            DgvListadoActividad.Columns[1].HeaderText = "Id Actividad";

            DgvListadoActividad.Columns[2].Width = 80;
            DgvListadoActividad.Columns[2].HeaderText = "Rut Usuario";

            DgvListadoActividad.Columns[3].Width = 100;
            DgvListadoActividad.Columns[3].HeaderText = "Nombre Actividad";

            DgvListadoActividad.Columns[4].Width = 100;
            DgvListadoActividad.Columns[4].HeaderText = "Descripcion Actividad";

            DgvListadoActividad.Columns[5].Width = 80;
            DgvListadoActividad.Columns[5].HeaderText = "Estado";

            DgvListadoActividad.Columns[6].Width = 100;
            DgvListadoActividad.Columns[6].HeaderText = "Fecha Inicio";

            DgvListadoActividad.Columns[7].Width = 80;
            DgvListadoActividad.Columns[7].HeaderText = "Fecha Termino";

            DgvListadoActividad.Columns[0].Visible = false;
            btnForzarCierreAc.Visible = false;

            chkboxSeleccionarAct.Checked = false;
        }
        private void Listar()
        {
            try
            {
                DgvListadoActividad.DataSource = NActividad.Listar();
                this.Formato();
                lblTotalAC.Text = "Total Registros: " + Convert.ToString(DgvListadoActividad.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
      
        private void DgvListadoActividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListadoActividad.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkboxSeleccionarAct = (DataGridViewCheckBoxCell)DgvListadoActividad.Rows[e.RowIndex].Cells["Seleccionar"];
                chkboxSeleccionarAct.Value = !Convert.ToBoolean(chkboxSeleccionarAct.Value);
            }
        }
        
        private void btnForzarCierreAc_Click(object sender, EventArgs e)
        {
            frmForzarCierreActividad frmSuspender = new frmForzarCierreActividad();
            frmSuspender.Show();
        }
        private void btnActualizarRegistrosAC_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListadoActividad.DataSource = NActividad.Listar();
                this.Formato();

                lblTotalAC.Text = "Total Registros: " + Convert.ToString(DgvListadoActividad.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmActividad_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void chkboxSeleccionarAct_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSeleccionarAct.Checked)
            {
                DgvListadoActividad.Columns[0].Visible = true;
                btnForzarCierreAc.Visible = true;

            }
            else
            {
                DgvListadoActividad.Columns[0].Visible = false;
                btnForzarCierreAc.Visible = false;
            }
        }
    }
}
