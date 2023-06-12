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
    public class DEmpresa
    {
        public string InsertarEmpresa(Empresa ObjE, Login ObjL, Tipo_Usuario ObjT, Usuario ObjU)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_USUARIO_CLIENTE_E", OracleCon);

                Comando.CommandType = System.Data.CommandType.StoredProcedure;

                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjE.rutUsuario;
                Comando.Parameters.Add("IN_CONTRASEÑA", OracleType.VarChar).Value = ObjL.contraseniaUser;
                Comando.Parameters.Add("IN_TIPO", OracleType.VarChar).Value = ObjT.tipo;

                Comando.Parameters.Add("IN_NOMBRE_USUARIO", OracleType.VarChar).Value = ObjU.nombreUsuario;
                Comando.Parameters.Add("IN_APELLIDO_USUARIO", OracleType.VarChar).Value = ObjU.apellidoUsuario;
                Comando.Parameters.Add("IN_TELEFONO_USUARIO", OracleType.Int32).Value = ObjU.telefonoUsuario;
                Comando.Parameters.Add("IN_CORREO_USUARIO", OracleType.VarChar).Value = ObjU.correoUsuario;
                Comando.Parameters.Add("IN_DOMICILIO_USUARIO", OracleType.VarChar).Value = ObjU.domicilioUsuario;

                Comando.Parameters.Add("IN_RUT_EMPRESA", OracleType.VarChar).Value = ObjE.rutEmpresa;
                Comando.Parameters.Add("IN_RAZON_SOCIAL", OracleType.VarChar).Value = ObjE.razonSocialEmpresa;
                Comando.Parameters.Add("IN_DIRECCION", OracleType.VarChar).Value = ObjE.direccionEmpresa;
                Comando.Parameters.Add("IN_FONO", OracleType.Int32).Value = ObjE.telefonoEmpresa;
                Comando.Parameters.Add("IN_CORREO", OracleType.VarChar).Value = ObjE.correoEmpresa;
                Comando.Parameters.Add("IN_PAGINA_WEB", OracleType.VarChar).Value = ObjE.paginaWebEmpresa;

                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar la Empresa";
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

        public string Actualizar(Empresa Obj)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("MODIFICAR_USUARIO_CLIENTE_E_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = Obj.rutUsuario;
                Comando.Parameters.Add("IN_R_SOCIAL", OracleType.VarChar).Value = Obj.razonSocialEmpresa;
                Comando.Parameters.Add("IN_DIRECCION", OracleType.VarChar).Value = Obj.direccionEmpresa;
                Comando.Parameters.Add("IN_TELEFONO", OracleType.Int32).Value = Obj.telefonoEmpresa;
                Comando.Parameters.Add("IN_CORREO", OracleType.VarChar).Value = Obj.correoEmpresa;
                Comando.Parameters.Add("IN_PAGINA_WEB", OracleType.VarChar).Value = Obj.paginaWebEmpresa;
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
                OracleCommand Comando = new OracleCommand("VISUALIZAR_USUARIO_CLIENTE", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_CLIENTE", OracleType.Cursor).Direction=ParameterDirection.Output;
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
   
        public string Desactivar(int id)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("MODIFICAR_ESTADO_DES_USUARIO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", SqlDbType.Int).Value = id;
                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
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

        public string ActualizarEstado(Usuario Obj)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("MODIFICAR_ESTADO_USUARIO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = Obj.rutUsuario;
                Comando.Parameters.Add("IN_HABILITADO", OracleType.VarChar).Value = Obj.habilitado;
            
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

        //public string Activar(int id)
        //{
        //    string Rpta = "";
        //    OracleConnection OracleCon = new OracleConnection();
        //    try
        //    {
        //        OracleCon = ConexionOracle.getInstancia().CrearConexion();
        //        OracleCommand Comando = new OracleCommand("MODIFICAR_ESTADO_ACT_USUARIO_E", OracleCon);
        //        Comando.CommandType = System.Data.CommandType.StoredProcedure;            
        //        Comando.Parameters.Add("IN_USUARIO", SqlDbType.Int).Value = id;
        //        OracleCon.Open();
        //        Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
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


        //NO FUNCIONA...

        public DataTable BuscarEmpresa(string Valor)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_USUARIO_CLIENTE_RC", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_CLIENTE", OracleType.Cursor).Direction = ParameterDirection.Output;
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
        
        public string ExisteEmpresa(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_USUARIO_RUT_E_E", OracleCon);
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
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
            return Rpta;
        }
       
        public string ExisteRutCliente(string valor)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_USUARIO_RUT_E", OracleCon);
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

                //Console.WriteLine(Rpta + " VERRRR");
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
            return Rpta;
        }
    }
}
