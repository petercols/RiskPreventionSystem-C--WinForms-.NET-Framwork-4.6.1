using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NLogin 
    {
        public static DataTable Login(string rutUsuario, string contraseniaUser)
        {
            DLogin datos = new DLogin();
            return datos.ValidaLogin(rutUsuario, contraseniaUser);
        }
        //no funka
        public static string ActualizarContraseña(string rutUsuario, string contraseniaUser)
        {
            Login ObjL = new Login();
            Usuario ObjU = new Usuario();
          
            DLogin Datos = new DLogin();

            if(rutUsuario.Equals(rutUsuario))
            {
                ObjU.rutUsuario = rutUsuario;
                ObjL.contraseniaUser = contraseniaUser;
                return Datos.ActualizarContraseña(ObjL, ObjU);
            }
            else
            {
                
                //string Existe = Datos.Existe(rutUsuario);
                //if (Existe.Equals("1"))
                //{
                //    return "El rut con esta contraseña ya existe.";
                //}
                //else      

                ObjU.rutUsuario = rutUsuario;
                ObjL.contraseniaUser = contraseniaUser;
                return Datos.ActualizarContraseña(ObjL, ObjU);
                
            }
        }
    }
}
