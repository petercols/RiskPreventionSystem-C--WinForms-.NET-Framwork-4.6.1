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
    public class NReporte
    {
        //public string nombreReporte { get; set; }
        ////QUIZAS SACAR!
        //public string archivo { get; set; }
        //public string descripcionReporte { get; set; }
        //public DateTime fechaEmision { get; set; }

        public static string InsertarReporte
            (string rutUsuario,string nombreReporte, string archivo, string descripcionReporte, DateTime fechaEmision,string nombreUsuario, int valorServicio, string descripcionServicio, string nombreTipoActividad, string descripcionActividad, string descripcion, DateTime fechaInicio, DateTime fechTermino)
        {
            //DUsuario DatosU = new DUsuario();
            DReporte DatosR = new DReporte();
            string Existe = DatosR.ExisteR(rutUsuario);

            DTipo_Actividad DatosT = new DTipo_Actividad();

            string Existe2 = DatosT.ExisteTipoActividad(rutUsuario);

            if (Existe2.Equals("0"))
            {
                return "La Actividad con ese Rut, no existe!, Ingrese una Actividad primero";
            }
            else
            {
                Usuario ObjU = new Usuario();
                Reporte ObjR = new Reporte();
                //ACTIVIDAD
                Servicio ObjS = new Servicio();
                Actividad ObjA = new Actividad();
                Tipo_Actividad ObjTP = new Tipo_Actividad();
                Pago ObjP = new Pago();

                ObjU.rutUsuario = rutUsuario;

                ObjR.nombreReporte = nombreReporte;
                ObjR.archivo = archivo;
                ObjR.descripcionReporte = descripcionReporte;
                ObjR.fechaEmision = fechaEmision;

                //ObjU.rutUsuario = rutUsuario;
                ObjS.nombreServicio = nombreUsuario;
                ObjS.valorServicio = valorServicio;
                ObjS.descripcionServicio = descripcionServicio;
                ObjTP.nombreTipoActividad = nombreTipoActividad;
                ObjA.descripcionActividad = descripcionActividad;
                ObjP.descripcion = descripcion;
                ObjA.fechaInicio = fechaInicio;
                ObjA.fechTermino = fechTermino;

                return DatosR.InsertarR(ObjU,ObjR,ObjS, ObjTP, ObjA, ObjP);
            }
        }

        public static DataTable ListarReporte()
        {
            DUsuario Datos = new DUsuario();
            return Datos.ListarProfesionales();
        }


    }
}
