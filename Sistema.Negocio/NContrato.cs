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
    public class NContrato
    {
        public static string Insertar
            (string rutUsuario,DateTime fechaContrato,string plazoContrato, int montoPago)
        {
            DContrato DatosC = new DContrato();
          
            string ExisteContrato = DatosC.ExisteRutContrato(rutUsuario);
            string ExisteHabilitado = DatosC.ExisteContratoHabilitado(rutUsuario);

            if (ExisteHabilitado.Equals("1"))
            {
                return "El Cliente no esta Habiitado, No puede generar un Contrato";
            }
            else
            {
                if (ExisteContrato.Equals("1"))
                {
                    return " El Contrato con este RUT ya existe!";
                }
                else
                {
                    Usuario ObjU = new Usuario();
                    Contrato ObjC = new Contrato();
                    ObjU.rutUsuario = rutUsuario;
                    ObjC.fechaContrato = fechaContrato;
                    ObjC.plazoContrato = plazoContrato;
                    ObjC.montoPago = montoPago;

                    return DatosC.Insertar(ObjU, ObjC);
                }
            }
        }

        public static DataTable Listar()
        {
            DContrato Datos = new DContrato();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DContrato Datos = new DContrato();
            return Datos.BuscarContrato(Valor);
        }

        public static string ActualizarSuspencion_Modificacion(string rutUsuario, int estado, int modificado)
        {
            DContrato Datos = new DContrato();
            Usuario ObjU = new Usuario();
            Contrato ObjC = new Contrato();
            DContrato DatosC = new DContrato(); 

            string ExisteContrato = DatosC.ExisteRutContrato(rutUsuario);

            if (ExisteContrato.Equals("0"))
            {
                return " El Contrato con este RUT no existe!";
            }
            if (rutUsuario.Equals(rutUsuario))
            {
                ObjU.rutUsuario = rutUsuario;
                ObjC.estado = estado;
                ObjC.modificado = modificado;
                return Datos.ActualizarSuspension(ObjU, ObjC);        
            }
            else
            {
                return "NO EXISTE ESTE CONTRATO";
                //ObjU.rutUsuario = rutUsuario;
                //ObjC.estado = estado;
                //ObjC.modificado = modificado;
                //return Datos.ActualizarSuspension(ObjU, ObjC);

            }
        }

        public static string SuspencionContrato_modificar(string rutUsuario,int folioContrato)
        {
            DContrato DatosC = new DContrato();
            string ExisteSuspencion = DatosC.ExisteSuspencionServicioContrato(rutUsuario);

            //if (ExisteSuspencion.Equals("1"))
           // {
                DContrato DatosContrato = new DContrato();
                //Usuario ObjU = new Usuario();
                Contrato ObjC = new Contrato();

                if (folioContrato.Equals(folioContrato))
                {
                    ObjC.folioContrato = folioContrato;
                    return DatosContrato.EditarEstadoContrato(ObjC);
                }
                else
                {
                    return "NO EXISTE ESTE CONTRATO";
                }
            //}
            //else
            //{
            //    return "NO EXISTE SUSPENCION";
            //}
        }

        public static string editarContratoActivo(string rutUsuario, int folioContrato)
        {
            DContrato DatosC = new DContrato();
            string ExisteSuspencion = DatosC.ExisteSuspencionServicioContrato(rutUsuario);

            if (ExisteSuspencion.Equals("0"))
            {
                DContrato DatosContrato = new DContrato();
                Usuario ObjU = new Usuario();
                Contrato ObjC = new Contrato();

                if (folioContrato.Equals(folioContrato))
                {
                    ObjC.folioContrato = folioContrato;
                    return DatosContrato.EditarEstadoContratoH(ObjC);
                }
                else
                {
                    return "NO EXISTE ESTE CONTRATO";
                }
            }
            else
            {
                return "NO EXISTE SUSPENCION";
            }
        }
    }
}
