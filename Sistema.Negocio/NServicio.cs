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
    public class NServicio
    {
        public static string Insertar
            (string rutUsuario, string nombreServicio, int valorServicio, string descripcionServicio, DateTime fechaInicio, DateTime fechaTermino)
        {
            DServicio DatosS = new DServicio();
            DUsuario DatosU = new DUsuario();

            string Existe = DatosU.ExisteRutTest(rutUsuario);
            string ExisteServicio = DatosS.existeServicio(rutUsuario);

            if (ExisteServicio.Equals("1"))
            {
                return "El Servicio con este RUT ya existe!";
            }
            else
            {
                Usuario ObjU = new Usuario();
                Servicio ObjS = new Servicio();

                ObjU.rutUsuario = rutUsuario;
                ObjS.nombreServicio = nombreServicio;
                ObjS.valorServicio = valorServicio;
                ObjS.descripcionServicio = descripcionServicio;
                ObjS.fechaInicio = fechaInicio;
                ObjS.fechaTermino = fechaTermino;
                return DatosS.InsertarSC(ObjU, ObjS);
            }
        }

        public static DataTable Listar()
        {
            DServicio Datos = new DServicio();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DServicio Datos = new DServicio();
            return Datos.BuscarServicioRut(Valor);
        }

        public static string ActualizarServicio_Modificacion(int idServicio, DateTime fechaTermino, int estado, int pagado)
        {
            DServicio Datos = new DServicio();

            DServicio DatosS = new DServicio();

            Servicio ObjS = new Servicio();

           string ExisteServicio = DatosS.existeServicioId(idServicio);

            if (ExisteServicio.Equals("0"))
            {
                return "El Servicio con este ID no existe!";
            }
            else
            {
                if (idServicio.Equals(idServicio))
                {
                    ObjS.idServicio = idServicio;
                    ObjS.fechaTermino = fechaTermino;
                    ObjS.estado = estado;
                    ObjS.pagado = pagado;
                    return Datos.ActualizarSuspensionServicio(ObjS);
                }
                else
                {

                    return "No Existe este Servicio";
                    //{
                    //    ObjS.idServicio = idServicio;
                    //    ObjS.fechaTermino = fechaTermino;
                    //    ObjS.estado = estado;
                    //    ObjS.pagado = pagado;
                    //    return Datos.ActualizarSuspensionServicio(ObjS);
                    //}
                }
            }
        }

        public static string AprobarPago(string rutUsuario,int idServicio)
        {
            DServicio DatosS = new DServicio();
            //TAREA BD
            //crear metodo que valide si el servicio esta en Pagado = 1..
            string ExistePagoX = DatosS.ExistePago(rutUsuario);

            string ExisteServicio = DatosS.existeServicioId(idServicio);

            if (ExisteServicio.Equals("0"))
            {
                return "El Servicio con este ID no existe!";
            }
            else
            if (ExistePagoX.Equals("1"))
            {
                DServicio DatosServicio = new DServicio();
                Usuario ObjU = new Usuario();
                Servicio ObjS = new Servicio();
                if (rutUsuario.Equals(rutUsuario))
                {
                    ObjS.idServicio = idServicio;

                    return DatosServicio.EditarServicioPagado(ObjS);
                }
                else
                {
                    return "X ALERTA";
                }
            }
            else
            {
                return "x ALERTA";
            }

        }
        
        public static string DeshabiltarServicio(string rutUsuario, int idServicio)
        {
            DServicio DatosS = new DServicio();
                DServicio DatosServicio = new DServicio();
                Usuario ObjU = new Usuario();
                Servicio ObjS = new Servicio();

                    if (idServicio.Equals(idServicio))
                    {
                        ObjS.idServicio = idServicio;

                        return DatosServicio.EditarEstadoServicio(ObjS);
                    }
                    else
                    {
                        return "No Existe este Servicio";
                    }
        }

        public static string HabilitarServicio(string rutUsuario, int idServicio)
        {
            DServicio DatosS = new DServicio();
            DServicio DatosServicio = new DServicio();
            Usuario ObjU = new Usuario();
            Servicio ObjS = new Servicio();
          
                if (idServicio.Equals(idServicio))
                {
                    ObjS.idServicio = idServicio;

                    return DatosServicio.EditarEstadoServicioH(ObjS);
                }
                else
                {
                    return "No Existe este Servicio";
                }
            
        }
    }
}
