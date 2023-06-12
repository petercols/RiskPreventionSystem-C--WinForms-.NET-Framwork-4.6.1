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
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
            this.ListarDgv();
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

        private void frmPago_Load(object sender, EventArgs e)
        {
            this.Location = new Point(235, 0);
            this.Size = new Size(1254, 502);
            this.ListarDgv();
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

        private void ListarDgv()
        {
            try
            {
                DgvListadoPagos.DataSource = NPago.Listar();
                this.Formato();
                lblTotalRegPago.Text = "Total Registros: " + Convert.ToString(DgvListadoPagos.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema No más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarRut()
        {
            try
            {
                if (txtRutBuscarGP.Text == string.Empty)
                {
                    this.MensajeError("Ingrese Rut!");
                }
                else
                    DgvListadoPagos.DataSource = NPago.BuscarPago(txtRutBuscarGP.Text);
                //this.Formato();
                lblTotalRegPago.Text = "Total Registros: " + Convert.ToString(DgvListadoPagos.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListadoPagos.Columns[0].Visible = false;

            DgvListadoPagos.Columns[1].Width = 80;
            DgvListadoPagos.Columns[1].HeaderText = "Id Servicio";

            DgvListadoPagos.Columns[2].Width = 80;
            DgvListadoPagos.Columns[2].HeaderText = "Id Folio Contrato";

            DgvListadoPagos.Columns[3].Width = 80;
            DgvListadoPagos.Columns[3].HeaderText = "Nombre Servicio";

            DgvListadoPagos.Columns[4].Width = 80;
            DgvListadoPagos.Columns[4].HeaderText = "Valor Servicio";

            DgvListadoPagos.Columns[5].Width = 150;
            DgvListadoPagos.Columns[5].HeaderText = "Descripcion Servicio";

            DgvListadoPagos.Columns[6].Width = 100;
            DgvListadoPagos.Columns[6].HeaderText = "Fecha Inicio";

            DgvListadoPagos.Columns[7].Width = 80;
            DgvListadoPagos.Columns[7].HeaderText = "Fecha Termino";

            DgvListadoPagos.Columns[8].Width = 100;
            DgvListadoPagos.Columns[8].HeaderText = "Estado";

            DgvListadoPagos.Columns[9].Width = 100;
            DgvListadoPagos.Columns[9].HeaderText = "Pagado";

            DgvListadoPagos.Columns[10].Width = 100;
            DgvListadoPagos.Columns[10].HeaderText = "Valor Total";

            DgvListadoPagos.Columns[11].Width = 100;
            DgvListadoPagos.Columns[11].HeaderText = "Fecha Pago";

            DgvListadoPagos.Columns[12].Width = 100;
            DgvListadoPagos.Columns[12].HeaderText = "Id Pago";
        }

        private void btnBuscarRutGP_Click(object sender, EventArgs e)
        {
            this.BuscarRut();
        }

        private void btnActualizarRegistrosGP_Click(object sender, EventArgs e)
        {

            try
            {
                DgvListadoPagos.DataSource = NPago.Listar();
                this.Formato();

                lblTotalRegPago.Text = "Total Registros: " + Convert.ToString(DgvListadoPagos.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtRutBuscarGP_Validating(object sender, CancelEventArgs e)
        {
            if (!validarRutOLD(txtRutBuscarGP.Text))
            {
                this.MensajeError("Rut invalido!");
                //txtRutBuscarGP.Focus();
            }
        }
    }
}
