using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class ConexionOracle
    {
            private static ConexionOracle Con = null;

            private ConexionOracle()
            {

            }

            public OracleConnection CrearConexion()
            {
                OracleConnection Cadena = new OracleConnection();
                try
                {
                    //ELEGIR LA CONEXION COMENTANDO O DESCOMENTANDO...
                    //ORACLE LOCAL TEST
                    Cadena.ConnectionString = "Data Source=orcl;User ID=colshon;Password=hola123;Unicode=True";
                    //ORACLE- AZURE - CLOUD
                    //Cadena.ConnectionString = "Data Source=nomasacc.eastus.cloudapp.azure.com;User ID=prueba;Password=prueba;Unicode=True";
                 
                }
            catch (Exception ex)
                {
                    Cadena = null;
                    throw ex;
                }
                return Cadena;
            }
            public static ConexionOracle getInstancia()
            {
                if (Con == null)
                {
                    Con = new ConexionOracle();

                }
                return Con;
            }
        
    }
}
