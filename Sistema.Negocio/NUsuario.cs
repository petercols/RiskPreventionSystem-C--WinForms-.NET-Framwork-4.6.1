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
    public class NUsuario
    {       
        public static string Insertar
            (string rutUsuario, string contraseniaUser,
            string tipo,string nombreUsuario,string apellidoUsuario,int telefonoUsuario,
            string correoUsuario, string domicilioUsuario)
        {
            DUsuario DatosU = new DUsuario();
            DLogin DatosL = new DLogin();
            DTipoUsuario DatosT = new DTipoUsuario();

            string Existe = DatosU.ExisteRutTest(rutUsuario);

            if (Existe.Equals("1"))
            {
                return "El Cuenta con ese Rut, ya existe!";
            }      
            else
            {
                Usuario ObjU = new Usuario();
                Login ObjL = new Login();
                Tipo_Usuario ObjT = new Tipo_Usuario();  
                
                ObjU.rutUsuario = rutUsuario;
                ObjL.contraseniaUser = contraseniaUser;
                ObjT.tipo = tipo;
                ObjU.nombreUsuario = nombreUsuario;
                ObjU.apellidoUsuario = apellidoUsuario;
                ObjU.telefonoUsuario = telefonoUsuario;
                ObjU.correoUsuario = correoUsuario;
                ObjU.domicilioUsuario = domicilioUsuario;
                //mantener orden igual que en DUSUARIO PARAMETRO!!!
                return DatosU.Insertar(ObjU, ObjL, ObjT);
            }
        }

        public static string ActualizarEstado(string rutUsuario, int habilitado)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();

            DUsuario DatosU = new DUsuario();

            string Existe2 = DatosU.ExisteRutTest(rutUsuario);

            if (Existe2.Equals("0"))
            {
                return ("El Usuario con este RUT no existe");
            }
            else
            if (rutUsuario.Equals(rutUsuario))
            {
                Obj.rutUsuario = rutUsuario;
                Obj.habilitado = habilitado;
                return Datos.ActualizarEstado(Obj);
            }
            else
            {
                {
                    Obj.rutUsuario = rutUsuario;
                    Obj.habilitado = habilitado;
                    return Datos.ActualizarEstado(Obj);
                }
            }
        }

        public static string InsertarProfesional(string rutUsuario, string contraseniaUser, string tipo, string nombreUsuario, string apellidoUsuario, int telefonoUsuario,
                                     string correoUsuario, string domicilioUsuario, string nombreProfesion)
        {

            DUsuario DatosU = new DUsuario();
            string Existe = DatosU.ExisteRutTest(rutUsuario);

            if (Existe.Equals("1"))
            {
                return ("El Profesional con este RUT ya existe");
            }
            else
            {
                Usuario ObjU = new Usuario();
                Login ObjL = new Login();
                Tipo_Usuario ObjT = new Tipo_Usuario();              
                Profesion ObjP = new Profesion();

                ObjU.rutUsuario = rutUsuario;
                ObjL.contraseniaUser = contraseniaUser;
                ObjT.tipo = tipo;
                ObjU.nombreUsuario = nombreUsuario;
                ObjU.apellidoUsuario = apellidoUsuario;
                ObjU.telefonoUsuario = telefonoUsuario;
                ObjU.correoUsuario = correoUsuario;
                ObjU.domicilioUsuario = domicilioUsuario;
                ObjP.nombreProfesion = nombreProfesion;

                return DatosU.InsertarProfesional(ObjU, ObjL, ObjT, ObjP);
            }
        }

        public static string Actualizar(string rutUsuario, int telefonoUsuario, string correoUsuario, string direccionEmpresa)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();

            if (rutUsuario.Equals(rutUsuario))
            {
                Obj.rutUsuario = rutUsuario;
                Obj.telefonoUsuario = telefonoUsuario;
                Obj.correoUsuario = correoUsuario;
                Obj.domicilioUsuario = direccionEmpresa;
                return Datos.ActualizarProfesioanl(Obj);
            }
            else
            {
                //string Existe = Datos.ExisteEmpresa(rutUsuario); 
                //if (Existe.Equals(Existe))
                //{
                //    return "La Empresa ya existe";
                //}
                //else
                {
                    Obj.rutUsuario = rutUsuario;
                    Obj.telefonoUsuario = telefonoUsuario;
                    Obj.correoUsuario = correoUsuario;
                    Obj.domicilioUsuario = direccionEmpresa;

                    return Datos.ActualizarProfesioanl(Obj);
                }
            }

        }

        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.ListarProfesionales();
        }

        public static DataTable Buscar(string Valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.BuscarUsuarioProfesional(Valor);
        }
    }
}
