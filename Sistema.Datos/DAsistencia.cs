using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DAsistencia
    {
        public DataTable visualizarAsistencia()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_ASISTENCIASA", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ASISTENCIA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
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
    }
}
