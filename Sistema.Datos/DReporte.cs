using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Sistema.Entidades;
using System.Data;
using System.Collections;

namespace Sistema.Datos
{
    public class DReporte
    {
        //ArrayList Usuario = new ArrayList();
        //ArrayList Pago = new ArrayList();

        public string InsertarR(Usuario ObjU, Reporte ObjR,Servicio ObjS, Tipo_Actividad ObjTP, Actividad ObjA, Pago ObjP)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_ACTIVIDAD_COMPLETA_R", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;

                //Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;
                Comando.Parameters.Add("IN_NOMBRES", OracleType.VarChar).Value = ObjS.nombreServicio;
                Comando.Parameters.Add("IN_VALORS", OracleType.Int32).Value = ObjS.valorServicio;
                Comando.Parameters.Add("IN_DESCS", OracleType.VarChar).Value = ObjS.descripcionServicio;
                Comando.Parameters.Add("IN_NOMA", OracleType.VarChar).Value = ObjTP.nombreTipoActividad;
                Comando.Parameters.Add("IN_DESCRA", OracleType.VarChar).Value = ObjA.descripcionActividad;
                Comando.Parameters.Add("IN_DESCP", OracleType.VarChar).Value = ObjP.descripcion;
                Comando.Parameters.Add("IN_FECHAI", OracleType.DateTime).Value = ObjA.fechaInicio;
                Comando.Parameters.Add("IN_FECHAT", OracleType.DateTime).Value = ObjA.fechTermino;

                Comando.Parameters.Add("IN_NOM_REPORTE", OracleType.VarChar).Value = ObjR.nombreReporte;
                Comando.Parameters.Add("IN_ARCH", OracleType.VarChar).Value = ObjR.archivo;
                Comando.Parameters.Add("IN_DESC_R", OracleType.VarChar).Value = ObjR.descripcionReporte;
                Comando.Parameters.Add("IN_DATE_EMISION", OracleType.DateTime).Value = ObjR.fechaEmision;

                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el Servicio de Contrato";
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

        public DataTable ListarR()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_ESTADISTICA", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ESTADISTICA", OracleType.Cursor).Direction = ParameterDirection.Output;
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

        public string ExisteR(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_REPORTE_E", OracleCon);
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
