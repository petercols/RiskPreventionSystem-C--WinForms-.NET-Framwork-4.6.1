using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Sistema.Entidades;
using System.Data;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DPago
    {
        public DataTable ListarPagos()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_HISTORICO_PAGO_S", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_PAGO", OracleType.Cursor).Direction = ParameterDirection.Output;
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

        public DataTable BuscarUsuarioXPago(string Valor)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_HISTORICO_PAGO_SR", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_PAGO", OracleType.Cursor).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = Valor;

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

        public string InsertarPago(Usuario ObjU, Pago ObjP)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_PAGO_SERVICIO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;
                //NEXTVAL
                //Comando.Parameters.Add("IN_IDPAGO", OracleType.Int32).Value = ObjP.idPago;
                //Comando.Parameters.Add("IN_IDSERVICIO", OracleType.Int32).Value = ObjP.idServicio;
                Comando.Parameters.Add("IN_DESCRIPCION", OracleType.VarChar).Value = ObjP.descripcion;
                Comando.Parameters.Add("IN_VALOR", OracleType.Int32).Value = ObjP.valorTotal;
                Comando.Parameters.Add("IN_FECHA", OracleType.DateTime).Value = ObjP.fechaPago;
                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el usuario";
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

    }
}
