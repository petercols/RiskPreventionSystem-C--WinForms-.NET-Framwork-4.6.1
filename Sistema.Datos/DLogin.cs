using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using System.Data.OracleClient;
using System.Data;

namespace Sistema.Datos
{
    public class DLogin
    {
        public DataTable ValidaLogin(string rutUsuario, string contraseniaUser)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection OracleCon = new OracleConnection();

            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("VALIDAR_USUARIO", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;

                Comando.Parameters.Add("OUT_CURSOR_USUARIO", OracleType.Cursor).Direction = ParameterDirection.Output;

                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = rutUsuario;
                Comando.Parameters.Add("IN_CONTRASEÑA", OracleType.VarChar).Value = contraseniaUser;

                //Comando.ExecuteNonQuery();

                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
        }

        public string ActualizarContraseña(Login ObjL, Usuario ObjU)
        {
            string Rpta = "";
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("CAMBIAR_CONTRASEÑA_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;              
                Comando.Parameters.Add("IN_USUARIO", OracleType.VarChar).Value = ObjU.rutUsuario;
                Comando.Parameters.Add("IN_CONTRASEÑA", OracleType.VarChar).Value = ObjL.contraseniaUser;
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

    

