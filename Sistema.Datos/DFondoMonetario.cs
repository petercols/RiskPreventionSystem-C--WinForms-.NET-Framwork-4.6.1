using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Datos
{
   public class DFondoMonetario
   {
        public string InsertarFM(Usuario ObjU, FondoMonetario ObjFM)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_FONDO_MONETARIO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;

                Comando.Parameters.Add("IN_MONTO", OracleType.Int32).Value = ObjFM.montoAbono;      
                Comando.Parameters.Add("IN_FECHA_ABONO", OracleType.DateTime).Value = ObjFM.fechaAbono;

                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el Fondo Monetario";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
            return Rpta;
        }
        //EXISTE FONDO MONETARIO
        public string existeFondoMonetario(string valor)
        {
            {
                string Rpta = "";
                OracleConnection OracleCon = new OracleConnection();
                try
                {
                    OracleCon = ConexionOracle.getInstancia().CrearConexion();
                    OracleCommand Comando = new OracleCommand("VALIDAR_FMONETARIO_E", OracleCon);
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = valor;
                    OracleParameter ParExiste = new OracleParameter();
                    ParExiste.ParameterName = "OUT_RESULTADO";
                    ParExiste.OracleType = OracleType.Int32;
                    ParExiste.Direction = ParameterDirection.Output;
                    Comando.Parameters.Add(ParExiste);
                    OracleCon.Open();

                    Comando.ExecuteNonQuery();
                    Rpta = Convert.ToString(ParExiste.Value);

                    Comando.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    Rpta = ex.Message;

                    Console.WriteLine(Rpta + " VERRRR");
                }
                finally
                {
                    if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
                }
                return Rpta;
            }
        }

    }
}
