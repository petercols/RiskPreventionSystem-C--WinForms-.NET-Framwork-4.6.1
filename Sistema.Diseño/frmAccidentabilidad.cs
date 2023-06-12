using Sistema.Datos;
using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Diseño
{
    public partial class frmAccidentabilidad : Form
    {
        public frmAccidentabilidad()
        {
            InitializeComponent();
        }

        private void frmAccidentabilidad_Load(object sender, EventArgs e)
        {
            this.ListarAccidentes();
            //txtN_Trabajadores.Text.ToString
        }

        private void Formato()
        {
            dataGridAccidentes.Columns[0].Visible = false;

            dataGridAccidentes.Columns[1].Width = 80;
            dataGridAccidentes.Columns[1].HeaderText = "Id Actividad";

            dataGridAccidentes.Columns[2].Width = 80;
            dataGridAccidentes.Columns[2].HeaderText = "Id Servicio";

            dataGridAccidentes.Columns[3].Width = 80;
            dataGridAccidentes.Columns[3].HeaderText = "Estado";

            dataGridAccidentes.Columns[4].Width = 80;
            dataGridAccidentes.Columns[4].HeaderText = "Rut Usuario";

            dataGridAccidentes.Columns[5].Width = 80;
            dataGridAccidentes.Columns[5].HeaderText = "Nombre Actividad";

            dataGridAccidentes.Columns[6].Width = 100;
            dataGridAccidentes.Columns[6].HeaderText = "Fecha Inicio";

            dataGridAccidentes.Columns[7].Width = 80;
            dataGridAccidentes.Columns[7].HeaderText = "Fecha Termino";



            dataGridAccidentes.Columns[0].Visible = false;
      
        }

        private void ListarAccidentes()
        {
            try
            {
                dataGridAccidentes.DataSource = NTipo_Actividad.ListarAccidentes();
                this.Formato();
                lblTotalE.Text = "Total Registros: " + Convert.ToString(dataGridAccidentes.Rows.Count);

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

        private void btnCalAccidentabilidad_Click(object sender, EventArgs e)
        {
            OracleConnection OracleCon = new OracleConnection();
            OracleCon = ConexionOracle.getInstancia().CrearConexion();          
            OracleCon.Open();

            string consulta1 = " SELECT COUNT(RUT_USUARIO) FROM USUARIO";
            string consulta2 = " SELECT COUNT(NOMBRE_TIPO_ACTIVIDAD) FROM TIPO_ACTIVIDAD WHERE NOMBRE_TIPO_ACTIVIDAD = 'Accidente'";

            OracleCommand Comando1 = new OracleCommand(consulta1, OracleCon);
            OracleCommand Comando2 = new OracleCommand(consulta2, OracleCon);

            DataTable tabla1 = new DataTable();
            DataTable tabla2 = new DataTable();

            OracleDataAdapter resultado1 = new OracleDataAdapter(consulta1, OracleCon);
            OracleDataAdapter resultado2 = new OracleDataAdapter(consulta2, OracleCon);

            resultado1.Fill(tabla1);
            resultado2.Fill(tabla2);

            string cantEmpleados = tabla1.Rows[0]["COUNT(RUT_USUARIO)"].ToString();
            string cantAccidentes = tabla2.Rows[0]["COUNT(NOMBRE_TIPO_ACTIVIDAD)"].ToString();

            txtN_Trabajadores.Text = cantEmpleados;
            txtN_Accidentes.Text = cantAccidentes;

            txtResultAcc.Text = "" + int.Parse(txtN_Accidentes.Text) * 100 / int.Parse(txtN_Trabajadores.Text);
            //txtResultAcc.Text = txtResultAcc.ToString();
            //txtResultAcc.Text = Math.Truncate(Convert.ToDouble(txtResultAcc.ToString())).ToString();

            txtResultAcc.Text = txtResultAcc.Text.Trim()+ "%";
            //txtResultAcc = System.Convert.ToInt32(txtResultAcc.Text + "%");
            //txtResultAcc.Clear();
        }

       
    }
}
