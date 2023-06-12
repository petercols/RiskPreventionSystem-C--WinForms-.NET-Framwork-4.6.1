using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NEmpresa
    {
        public static string Insertar(string rutUsuario, string contraseniaUser, string tipo, string nombreUsuario, string apellidoUsuario, int telefonoUsuario,
                                      string correoUsuario, string domicilioUsuario, string rutEmpresa, string razonSocialEmpresa, string direccionEmpresa, int telefonoEmpresa, string correoEmpresa,
                                      string paginaWebEmpresa)
        {
            //OBJ DE VALIDACION
            DEmpresa DatosE = new DEmpresa();

            DUsuario DatosU = new DUsuario();

            Empresa ObjEX = new Empresa();

            string Existe = DatosE.ExisteEmpresa(rutEmpresa);
            string Existe2 = DatosU.ExisteRutTest(rutUsuario);

            if (Existe.Equals("1"))
            {
                return ("La Empresa con este RUT ya existe");
            }
            else
            {
                if (Existe2.Equals("1"))
                {
                    return ("El Usuario con este RUT ya existe");

                }
                else
                {
                    Empresa ObjE = new Empresa();
                    Login ObjL = new Login();
                    Tipo_Usuario ObjT = new Tipo_Usuario();
                    Usuario ObjU = new Usuario();

                    ObjE.rutUsuario = rutUsuario;
                    ObjL.contraseniaUser = contraseniaUser;

                    ObjT.tipo = tipo;

                    ObjU.nombreUsuario = nombreUsuario;
                    ObjU.apellidoUsuario = apellidoUsuario;
                    ObjU.telefonoUsuario = telefonoUsuario;
                    ObjU.correoUsuario = correoUsuario;
                    ObjU.domicilioUsuario = domicilioUsuario;

                    ObjE.rutEmpresa = rutEmpresa;
                    ObjE.razonSocialEmpresa = razonSocialEmpresa;
                    ObjE.direccionEmpresa = direccionEmpresa;
                    ObjE.telefonoEmpresa = telefonoEmpresa;
                    ObjE.correoEmpresa = correoEmpresa;
                    ObjE.paginaWebEmpresa = paginaWebEmpresa;

                    return DatosE.InsertarEmpresa(ObjE, ObjL, ObjT, ObjU);
                }
            }          
        }

        public static string Actualizar(string rutUsuarioAntiguo, string rutUsuario, string razonSocialEmpresa, string direccionEmpresa, int telefonoEmpresa, string correoEmpresa, string paginaWebEmpresa)
        {
            DEmpresa Datos = new DEmpresa();
            Empresa Obj = new Empresa();

            if (rutUsuario.Equals(rutUsuario))
            {
                Obj.rutUsuario = rutUsuario;
                Obj.razonSocialEmpresa = razonSocialEmpresa;
                Obj.direccionEmpresa = direccionEmpresa;
                Obj.telefonoEmpresa = telefonoEmpresa;
                Obj.correoEmpresa = correoEmpresa;
                Obj.paginaWebEmpresa = paginaWebEmpresa;

                return Datos.Actualizar(Obj);
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
                    Obj.razonSocialEmpresa = razonSocialEmpresa;
                    Obj.direccionEmpresa = direccionEmpresa;
                    Obj.telefonoEmpresa = telefonoEmpresa;
                    Obj.correoEmpresa = correoEmpresa;
                    Obj.paginaWebEmpresa = paginaWebEmpresa;

                    return Datos.Actualizar(Obj);
                }
            }

        }

        public static DataTable Listar()
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DEmpresa Datos = new DEmpresa();
            return Datos.BuscarEmpresa(Valor);
        }
    }
}
