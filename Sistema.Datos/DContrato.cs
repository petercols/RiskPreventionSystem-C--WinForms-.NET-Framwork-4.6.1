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
    public class DContrato
    {
        //CRUD
        public string Insertar(Usuario ObjU, Contrato ObjC)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_CONTRATO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;

                Comando.Parameters.Add("IN_FECHAC", OracleType.DateTime).Value = ObjC.fechaContrato;
                Comando.Parameters.Add("IN_PLAZO", OracleType.Int32).Value = ObjC.plazoContrato;
                Comando.Parameters.Add("IN_VALOR", OracleType.Int32).Value = ObjC.montoPago;

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
        public DataTable Listar()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_INFO_CONTRATO", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_CONTRATO", OracleType.Cursor).Direction = ParameterDirection.Output;
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
        public DataTable BuscarContrato(string Valor)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_INFO_CONTRATO_US", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_CONTRATO", OracleType.Cursor).Direction = ParameterDirection.Output;
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
        public string ActualizarSuspension(Usuario ObjU, Contrato ObjC)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_ESTADO_CONTRATOU_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;

                Comando.Parameters.Add("IN_MODIFICADO", OracleType.Int32).Value = ObjC.modificado;
                Comando.Parameters.Add("IN_ESTADO", OracleType.Int32).Value = ObjC.estado;

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
        public string ExisteRutContrato(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_CONTRATO_E", OracleCon);
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
        public string ExisteContratoHabilitado(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_USUARIO_HAB_E", OracleCon);
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
        //SERVICIO DESHABILITADO
        public string ExisteSuspencionServicioContrato(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_ESTADO_CONTRATO_E", OracleCon);
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
        public string EditarEstadoContrato(Contrato ObjC)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_CONTRATO_E_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_FOLIO_CONTRATO", OracleType.Int32).Value = ObjC.folioContrato;
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
        public string EditarEstadoContratoH(Contrato ObjC)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("EDITAR_CONTRATO_E_A_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_FOLIO_CONTRATO", OracleType.Int32).Value = ObjC.folioContrato;
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

    }
}
