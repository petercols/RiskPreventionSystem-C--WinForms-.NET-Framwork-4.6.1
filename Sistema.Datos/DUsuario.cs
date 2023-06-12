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
    public class DUsuario
    {
        public string Insertar(Usuario ObjU, Login ObjL, Tipo_Usuario ObjT)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_USUARIO_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;
                Comando.Parameters.Add("IN_CONTRASEÑA", OracleType.VarChar).Value = ObjL.contraseniaUser;
                Comando.Parameters.Add("IN_TIPO", OracleType.VarChar).Value = ObjT.tipo;
                Comando.Parameters.Add("IN_NOMBRE_USUARIO", OracleType.VarChar).Value = ObjU.nombreUsuario;
                Comando.Parameters.Add("IN_APELLIDO_USUARIO", OracleType.VarChar).Value = ObjU.apellidoUsuario;
                Comando.Parameters.Add("IN_TELEFONO_USUARIO", OracleType.Int32).Value = ObjU.telefonoUsuario;
                Comando.Parameters.Add("IN_CORREO_USUARIO", OracleType.VarChar).Value = ObjU.correoUsuario;
                Comando.Parameters.Add("IN_DOMICILIO_USUARIO", OracleType.VarChar).Value = ObjU.domicilioUsuario;

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
        //public string Existe(string rutUsuario)
        //{
        //    string Rpta = "";       
        //    OracleConnection OracleCon = new OracleConnection();

        //    try
        //    {
        //        OracleCon = ConexionOracle.getInstancia().CrearConexion();
        //        OracleCommand Comando = new OracleCommand("VALIDAR_USUARIO_RUT", OracleCon);
        //        Comando.CommandType = System.Data.CommandType.StoredProcedure;
        //        Comando.Parameters.Add("OUT_CURSOR_USUARIO", OracleType.Cursor).Direction = ParameterDirection.Output;                            
        //        Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = rutUsuario;

        //        OracleParameter ParExiste = new OracleParameter();
        //        //Dato rut varchar
        //        ParExiste.Size = 11;
        //        ParExiste.OracleType = OracleType.VarChar;
        //        ParExiste.Direction = ParameterDirection.Output;
        //        Comando.Parameters.Add(ParExiste);

        //        OracleCon.Open();
        //        Comando.ExecuteNonQuery();
        //        Rpta = Convert.ToString(ParExiste.Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        Rpta = ex.Message;
        //        //RETORNA NULO, TIRA ERROR "Referencia a objeto no establecida como instacia de un objeto"
        //        //return null;
        //        // throw ex;
        //    }
        //    finally
        //    {
        //        if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
        //    }
        //    return Rpta;
        //}

        //Funcional
        public  string ExisteRutTest(string valor)
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

                Console.WriteLine(Rpta + " VERRRR");
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

        public string InsertarProfesional(Usuario ObjU, Login ObjL, Tipo_Usuario ObjT, Profesion ObjP)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CREAR_USUARIO_PROFESIONAL_E", OracleCon);

                Comando.CommandType = System.Data.CommandType.StoredProcedure;

                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;
                Comando.Parameters.Add("IN_CONTRASEÑA", OracleType.VarChar).Value = ObjL.contraseniaUser;

                Comando.Parameters.Add("IN_TIPO", OracleType.VarChar).Value = ObjT.tipo;

                Comando.Parameters.Add("IN_NOMBRE_USUARIO", OracleType.VarChar).Value = ObjU.nombreUsuario;
                Comando.Parameters.Add("IN_APELLIDO_USUARIO", OracleType.VarChar).Value = ObjU.apellidoUsuario;
                Comando.Parameters.Add("IN_TELEFONO_USUARIO", OracleType.Int32).Value = ObjU.telefonoUsuario;
                Comando.Parameters.Add("IN_CORREO_USUARIO", OracleType.VarChar).Value = ObjU.correoUsuario;
                Comando.Parameters.Add("IN_DOMICILIO_USUARIO", OracleType.VarChar).Value = ObjU.domicilioUsuario;

                Comando.Parameters.Add("IN_PROFESION", OracleType.VarChar).Value = ObjP.nombreProfesion;


                OracleCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el Profesional";
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

        public string ActualizarProfesioanl(Usuario Obj)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("MODIFICAR_USUARIO_PROFESION_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = Obj.rutUsuario;
                Comando.Parameters.Add("IN_TELEFONO_USUARIO", OracleType.Int32).Value = Obj.telefonoUsuario;
                Comando.Parameters.Add("IN_CORREO_USUARIO", OracleType.VarChar).Value = Obj.correoUsuario;
                Comando.Parameters.Add("IN_DOMICILIO_USUARIO", OracleType.VarChar).Value = Obj.domicilioUsuario;
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

        public DataTable ListarProfesionales()
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_USUARIO_PROFESIONAL", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_PROFESIONAL", OracleType.Cursor).Direction = ParameterDirection.Output;
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

        public DataTable BuscarUsuarioProfesional(string Valor)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VISUALIZAR_USUARIO_CLIENTE_RP", OracleCon);
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
    }
}
