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
    public partial class frmForzarCierreActividad : Form
    {
        int estado;
        public frmForzarCierreActividad()
        {
            InitializeComponent();
        }

        private void frmForzarCierreActividad_Load(object sender, EventArgs e)
        {
            //ESTADO
            rbNo0.Enabled = true;
            rbSi1.Enabled = true;
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
            txtIdActividad.Clear();
        }

        private void btnConfirmarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdActividad.Text == string.Empty || rbSi1.Text == string.Empty || rbNo0.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtIdActividad, "Ingrese un ID.");
                    ErrorIcono.SetError(rbSi1, "Seleccione un Campo");
                    ErrorIcono.SetError(rbNo0, "Seleccione un Campo");
                }
                else
                {
                    Rpta = NActividad.ActualizarEstado(Convert.ToInt32(txtIdActividad.Text.Trim()),this.estado);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta La Modificacion del cierre de Actividad");
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

        private void rbSi1_CheckedChanged(object sender, EventArgs e)
        {
            estado = 1;
        }

        private void rbNo0_CheckedChanged(object sender, EventArgs e)
        {
            estado = 0;
        }

        private void txtIdActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmpresa.validarCampoEntero(e);
        }
    }
}
