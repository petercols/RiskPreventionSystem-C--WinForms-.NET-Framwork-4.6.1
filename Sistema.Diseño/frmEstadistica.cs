using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Sistema.Datos;
using Sistema.Negocio;

namespace Sistema.Diseño
{
    public partial class frmEstadistica : Form
    {
        public frmEstadistica()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {
            //graficoRutxTotal();
        }
        //GRAFICO
        ArrayList Usuario = new ArrayList();
        ArrayList Pago = new ArrayList();

        public void graficoRutxTotal()
        {
            OracleDataReader Resultado;
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("DATOS_ESTADISTICA_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ESTADISTICA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                while (Resultado.Read())
                {
                    Usuario.Add(Resultado.GetString(0));
                    Pago.Add(Resultado.GetInt32(1));
                }
                Grafico00.Series[0].Points.DataBindXY(Usuario, Pago);
                Grafico01.Series[0].Points.DataBindXY(Usuario, Pago);

                //Grafico02.Series[0].Points.DataBindXY(Usuario, Pago);
                Resultado.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            graficoRutxTotal();
        }

        private void btnGuardarGrafica_Click(object sender, EventArgs e)
        {
            this.Grafico00.SaveImage("C:\\ESTADISTICAS_NOMASAC\\UsuariosPagoTotal.png", ChartImageFormat.Png);
            MessageBox.Show("Imagen grabada en disco C: Correctamente!");
;        }
    }
}
