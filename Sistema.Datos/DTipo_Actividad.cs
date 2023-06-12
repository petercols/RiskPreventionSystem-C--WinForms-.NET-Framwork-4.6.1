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
    public class DTipo_Actividad
    {
        
        public string InsertarActividadC(Usuario ObjU, Servicio ObjS, Tipo_Actividad ObjTP, Actividad ObjA, Pago ObjP)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_ACTIVIDAD_COMPLETA_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;
                Comando.Parameters.Add("IN_NOMBRES", OracleType.VarChar).Value = ObjS.nombreServicio;
                Comando.Parameters.Add("IN_VALORS", OracleType.Int32).Value = ObjS.valorServicio;
                Comando.Parameters.Add("IN_DESCS", OracleType.VarChar).Value = ObjS.descripcionServicio;
                Comando.Parameters.Add("IN_NOMA", OracleType.VarChar).Value = ObjTP.nombreTipoActividad;
                Comando.Parameters.Add("IN_DESCRA", OracleType.VarChar).Value = ObjA.descripcionActividad;
                Comando.Parameters.Add("IN_DESCP", OracleType.VarChar).Value = ObjP.descripcion;
                Comando.Parameters.Add("IN_FECHAI", OracleType.DateTime).Value = ObjA.fechaInicio;
                Comando.Parameters.Add("IN_FECHAT", OracleType.DateTime).Value = ObjA.fechTermino;

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

        public string EditaVisita(Servicio ObjS, Actividad ObjA)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_FECHA_VISITA_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;                           
                Comando.Parameters.Add("IN_IDA", OracleType.Int32).Value = ObjA.idActividad;
                Comando.Parameters.Add("IN_IDS", OracleType.Int32).Value = ObjS.idServicio;
                Comando.Parameters.Add("IN_ESTADOS", OracleType.Int32).Value = ObjS.estado;
                Comando.Parameters.Add("IN_FECHA_I", OracleType.DateTime).Value = ObjA.fechaInicio;
                Comando.Parameters.Add("IN_FECHA_T", OracleType.DateTime).Value = ObjA.fechTermino;
                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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

        public DataTable visualizarVisita()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_VISITA", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_VISITA", OracleType.Cursor).Direction = ParameterDirection.Output;
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

        public string EliminarVisita(Tipo_Actividad ObjTP)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("ELIMINAR_VISITA_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_IDA", OracleType.Int32).Value = ObjTP.idActividad;    
                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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
        
        //FALTA
        public string ExisteTipoActividad(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_ACTIVIDAD_E", OracleCon);
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


        //ACCIDENTABILIDAD FORMA 1
        //public string DatosAccidentabilidad(int cantEmpleados, int cantAccidentes, string resultadoAcc)
        //{
        //    string Rpta = "";

        //    OracleConnection OracleCon = new OracleConnection();
        //    try
        //    {
        //        OracleCon = ConexionOracle.getInstancia().CrearConexion();
        //        OracleCommand Comando = new OracleCommand("CAL_ACCIDEN", OracleCon);
        //        Comando.CommandType = System.Data.CommandType.StoredProcedure;

        //        Comando.Parameters.Add("V_T_EMPLEADOS", OracleType.Int32).Value = cantEmpleados;
        //        Comando.Parameters.Add("V_T_ACCIDENT", OracleType.Int32).Value = cantAccidentes;
        //        Comando.Parameters.Add("V_RESUL_ACCIDEN", OracleType.VarChar).Value = resultadoAcc;

        //        Comando.Parameters.Add("OUT_CURSOR_EMPLE", OracleType.Cursor).Direction = ParameterDirection.Output;
        //        Comando.Parameters.Add("OUT_CURSOR_ACC", OracleType.Cursor).Direction = ParameterDirection.Output;

        //        OracleCon.Open();
        //        Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
        //    }
        //    catch (Exception ex)
        //    {
        //        Rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
        //    }
        //    return Rpta;
        //}

        public DataTable visualizarAccidentes()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_ACC", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ACC", OracleType.Cursor).Direction = ParameterDirection.Output;
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
