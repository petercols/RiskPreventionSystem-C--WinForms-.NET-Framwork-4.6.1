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
    public class DServicio
    {   
        //SEMI CRUD 
        public string InsertarSC(Usuario ObjU, Servicio ObjS)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_SERVICIO_CONTRATO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;

                Comando.Parameters.Add("IN_NOMBRES", OracleType.VarChar).Value = ObjS.nombreServicio;
                Comando.Parameters.Add("IN_VALORS", OracleType.Int32).Value = ObjS.valorServicio;
                Comando.Parameters.Add("IN_DESCS", OracleType.VarChar).Value = ObjS.descripcionServicio;
                Comando.Parameters.Add("IN_FECHAI", OracleType.DateTime).Value = ObjS.fechaInicio;
                Comando.Parameters.Add("IN_FECHAT", OracleType.DateTime).Value = ObjS.fechaTermino;

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
        public DataTable Listar()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_INFO_SERVICIO", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_SERVICIO", OracleType.Cursor).Direction = ParameterDirection.Output;
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
        public DataTable BuscarServicioRut(string Valor)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_INFO_SERVICIO_R", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_SERVICIO", OracleType.Cursor).Direction = ParameterDirection.Output;
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
        //SERVICIO DESHABILITADO
        public string ActualizarSuspensionServicio(Servicio ObjS)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_SERVICIO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;

                Comando.Parameters.Add("IN_ID_SERVICIO", OracleType.VarChar).Value = ObjS.idServicio;

                Comando.Parameters.Add("IN_FECHAT", OracleType.DateTime).Value = ObjS.fechaTermino;
                Comando.Parameters.Add("IN_ESTADO", OracleType.Int32).Value = ObjS.estado;
                Comando.Parameters.Add("IN_PAGADO", OracleType.Int32).Value = ObjS.pagado;

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
        public string EditarEstadoServicio(Servicio ObjS)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_SERVICIO_E_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_ID_SERVICIO", OracleType.Int32).Value = ObjS.idServicio;
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
        //PAGO
        public string ExistePago(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_ESTADO_SERVICIO_H_E", OracleCon);
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
        public string EditarServicioPagado(Servicio ObjS)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_SERVICIO_P_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_ID_SERVICIO", OracleType.Int32).Value = ObjS.idServicio;
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
        public string EditarEstadoServicioH(Servicio ObjS)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_SERVICIO_E_A_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_ID_SERVICIO", OracleType.Int32).Value = ObjS.idServicio;
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
        //EXISTE SERVICO X RUT
        public string existeServicio(string valor)
        {
            {
                string Rpta = "";
                OracleConnection OracleCon = new OracleConnection();
                try
                {
                    OracleCon = ConexionOracle.getInstancia().CrearConexion();
                    OracleCommand Comando = new OracleCommand("VALIDAR_SERVICIO_E", OracleCon);
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
        //EXISTE SERVICO X ID
        public string existeServicioId(int valor)
        {
            {
                string Rpta = "";
                OracleConnection OracleCon = new OracleConnection();
                try
                {
                    OracleCon = ConexionOracle.getInstancia().CrearConexion();
                    OracleCommand Comando = new OracleCommand("VALIDAR_SERVICIO_ID_E", OracleCon);
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("IN_SERVICIO", OracleType.VarChar).Value = valor;
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
