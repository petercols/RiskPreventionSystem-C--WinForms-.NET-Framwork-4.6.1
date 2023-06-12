using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using System.Data.OracleClient;
namespace Sistema.Datos
{
    public class DActividad
    {
        //SEMI CRUD
        public string editarEstadoActividad(Actividad ObjA)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_ACTIVIDAD_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_ID_ACTIVIDAD", OracleType.VarChar).Value = ObjA.idActividad;
                Comando.Parameters.Add("IN_ESTADO", OracleType.VarChar).Value = ObjA.estado;

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
        public DataTable Listar()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_ACTIVIDAD_ID", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ACTIVIDAD", OracleType.Cursor).Direction = ParameterDirection.Output;
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
        //SERVICIO DESHABILITADO
        public string EditarEstadoActividad(Actividad ObjA)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_ACTIVIDAD_E_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_ID_ACTIVIDAD", OracleType.Int32).Value = ObjA.idActividad;
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
        //SERVICIO HABILITADO
        public string EditarEstadoServicioH(Actividad ObjA)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_ACTIVIDAD_E_C_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_ID_ACTIVIDAD", OracleType.Int32).Value = ObjA.idActividad;
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
        //EXISTE SERVICIO X ID
        public string existeActividadId(int valor)
        {
            {
                string Rpta = "";
                OracleConnection OracleCon = new OracleConnection();
                try
                {
                    OracleCon = ConexionOracle.getInstancia().CrearConexion();
                    OracleCommand Comando = new OracleCommand("VALIDAR_ACTIVIDAD_ID_E", OracleCon);
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("IN_ACTIVIDAD", OracleType.VarChar).Value = valor;
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

                    Console.WriteLine(Rpta + "");
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
