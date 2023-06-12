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
    public partial class frmServicio : Form
    {
        public frmServicio()
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

        private void txtRutBuscarS_Validated(object sender, EventArgs e)
        {
            if (!validarRutOLD(txtRutBuscarS.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutBuscarS.Focus();
            }
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            this.Location = new Point(235, 0);
            this.Size = new Size(1254, 502);
            this.Listar();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Formato()
        {
            DgvListadoServicio.Columns[0].Visible = false;

            DgvListadoServicio.Columns[1].Width = 80;
            DgvListadoServicio.Columns[1].HeaderText = "Id Servicio";

            DgvListadoServicio.Columns[2].Width = 80;
            DgvListadoServicio.Columns[2].HeaderText = "Folio Contrato";

            DgvListadoServicio.Columns[3].Width = 80;
            DgvListadoServicio.Columns[3].HeaderText = "Nombre Servicio";

            DgvListadoServicio.Columns[4].Width = 80;
            DgvListadoServicio.Columns[4].HeaderText = "Valor Servicio";

            DgvListadoServicio.Columns[5].Width = 150;
            DgvListadoServicio.Columns[5].HeaderText = "Descripcion Servicio";

            DgvListadoServicio.Columns[6].Width = 100;
            DgvListadoServicio.Columns[6].HeaderText = "Fecha Inicio";

            DgvListadoServicio.Columns[7].Width = 80;
            DgvListadoServicio.Columns[7].HeaderText = "Fecha Termino";

            DgvListadoServicio.Columns[8].Width = 100;
            DgvListadoServicio.Columns[8].HeaderText = "Estado";

            DgvListadoServicio.Columns[9].Width = 100;
            DgvListadoServicio.Columns[9].HeaderText = "Pagado";

            DgvListadoServicio.Columns[0].Visible = false;
            btnSuspenderS.Visible = false;
            btnAprobarPago.Visible = false;

            chkboxSeleccionarS.Checked = false;
        }

        private void FormatoBuscarxRut()
        {
            DgvListadoServicio.Columns[0].Visible = false;

            //DgvListadoServicio.Columns[1].Width = 80;
            //DgvListadoServicio.Columns[1].HeaderText = "Rut Cliente";

            //DgvListadoServicio.Columns[2].Width = 80;
            //DgvListadoServicio.Columns[2].HeaderText = "Nombre";

            //DgvListadoServicio.Columns[3].Width = 80;
            //DgvListadoServicio.Columns[3].HeaderText = "Apellido";

            //DgvListadoServicio.Columns[4].Width = 80;
            //DgvListadoServicio.Columns[4].HeaderText = "Telefono";

            //DgvListadoServicio.Columns[5].Width = 80;
            //DgvListadoServicio.Columns[5].HeaderText = "Correo";

            //DgvListadoServicio.Columns[6].Width = 100;
            //DgvListadoServicio.Columns[6].HeaderText = "Domicilio";

            //DgvListadoServicio.Columns[7].Width = 80;
            //DgvListadoServicio.Columns[7].HeaderText = "Habilitado";

            //DgvListadoServicio.Columns[8].Width = 100;
            //DgvListadoServicio.Columns[8].HeaderText = "Rut Empresa";

            //DgvListadoServicio.Columns[9].Width = 100;
            //DgvListadoServicio.Columns[9].HeaderText = "Razon Social";

            //DgvListadoServicio.Columns[10].Width = 100;
            //DgvListadoServicio.Columns[10].HeaderText = "Direccion Empresa";

            //DgvListadoServicio.Columns[11].Width = 100;
            //DgvListadoServicio.Columns[11].HeaderText = "Telefono Empresa";

            //DgvListadoServicio.Columns[12].Width = 100;
            //DgvListadoServicio.Columns[12].HeaderText = "Correo Empresa";

            DgvListadoServicio.Columns[0].Visible = false;
            btnSuspenderS.Visible = false;
            btnAprobarPago.Visible = false;

            chkboxSeleccionarS.Checked = false;

        }

        private void Listar()
        {
            try
            {
                DgvListadoServicio.DataSource = NServicio.Listar();
                this.Formato();
                lblTotalServicio.Text = "Total Registros: " + Convert.ToString(DgvListadoServicio.Rows.Count);

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
                if (txtRutBuscarS.Text == string.Empty)
                {
                    this.MensajeError("Ingrese Rut!");
                }
                else
                    DgvListadoServicio.DataSource = NServicio.Buscar(txtRutBuscarS.Text);
                //this.FormatoBuscarxRut();
                lblTotalServicio.Text = "Total Registros: " + Convert.ToString(DgvListadoServicio.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarRutS_Click(object sender, EventArgs e)
        {
            this.BuscarRut();
        }

        private void chkboxSeleccionarS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSeleccionarS.Checked)
            {
                DgvListadoServicio.Columns[0].Visible = true;
                btnSuspenderS.Visible = true;
                btnAprobarPago.Visible = true;

            }
            else
            {
                DgvListadoServicio.Columns[0].Visible = false;
                btnSuspenderS.Visible = false;
                btnAprobarPago.Visible = false;
            }
        }

        private void DgvListadoServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListadoServicio.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkboxSeleccionarC = (DataGridViewCheckBoxCell)DgvListadoServicio.Rows[e.RowIndex].Cells["Seleccionar"];
                chkboxSeleccionarC.Value = !Convert.ToBoolean(chkboxSeleccionarC.Value);
            }
        }

        private void btnSuspenderS_Click(object sender, EventArgs e)
        {
            frmSuspenderServicio frmSuspenderS = new frmSuspenderServicio();
            frmSuspenderS.Show();
        }

        private void btnActualizarRegistrosS_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListadoServicio.DataSource = NServicio.Listar();
                this.Formato();

                lblTotalServicio.Text = "Total Registros: " + Convert.ToString(DgvListadoServicio.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAprobarPago_Click(object sender, EventArgs e)
        {
            frmAprobarPagoServicio frmApago = new frmAprobarPagoServicio();
            frmApago.Show();
        }
    }
}
