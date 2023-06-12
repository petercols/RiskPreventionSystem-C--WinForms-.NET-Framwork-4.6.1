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
    public class NTipo_Actividad
    {
        public int cantEmpleados;
        public int cantAccidentes;

        public static string InsertarActividadC
            (string rutUsuario,string nombreUsuario, int valorServicio,string descripcionServicio, string nombreTipoActividad, string descripcionActividad,string descripcion,DateTime fechaInicio, DateTime fechTermino)
        {
            DUsuario DatosU = new DUsuario();        
            DTipo_Actividad DatosT = new DTipo_Actividad();

            string Existe = DatosT.ExisteTipoActividad(rutUsuario);

            if (Existe.Equals("0"))
            {
                return "La Actividad con ese Rut, no existe!";
            }
            else
            {

                Usuario ObjU = new Usuario();
                Servicio ObjS = new Servicio();
                Actividad ObjA = new Actividad();
                Tipo_Actividad ObjTP = new Tipo_Actividad();
                Pago ObjP = new Pago();


                ObjU.rutUsuario = rutUsuario;
                ObjS.nombreServicio = nombreUsuario;
                ObjS.valorServicio = valorServicio;
                ObjS.descripcionServicio = descripcionServicio;
                ObjTP.nombreTipoActividad = nombreTipoActividad;
                ObjA.descripcionActividad = descripcionActividad;
                ObjP.descripcion = descripcion;
                ObjA.fechaInicio = fechaInicio;
                ObjA.fechTermino = fechTermino;


                return DatosT.InsertarActividadC(ObjU, ObjS, ObjTP, ObjA, ObjP);
            }
        }

        public static string EditarActividadVisita
            (int idActividad, int idServicio, int estado, DateTime fechaInicio, DateTime fechTermino)
        {
            DUsuario DatosU = new DUsuario();
            DTipo_Actividad DatosT = new DTipo_Actividad();
            DServicio DatosS = new DServicio();
            DActividad DatosA = new DActividad();

            string Existe = DatosA.existeActividadId(idActividad);

            if (Existe.Equals("0"))
            {
                return "La Actividad con ese ID, no existe!";
            }

            string ExisteServicio = DatosS.existeServicioId(idServicio);

            if (ExisteServicio.Equals("0"))
            {
                return "El Servicio con este ID no existe!";
            }
            else
            {

                Servicio ObjS = new Servicio();
                Actividad ObjA = new Actividad();

                ObjA.idActividad = idActividad;
                ObjS.idServicio = idServicio;
                ObjS.estado = estado;
                ObjA.fechaInicio = fechaInicio;
                ObjA.fechTermino = fechTermino;


                return DatosT.EditaVisita(ObjS, ObjA);
            }
        }

        public static DataTable ListarEditarVisita()
        {
            DTipo_Actividad Datos = new DTipo_Actividad();
            return Datos.visualizarVisita();
        }

        public static DataTable ListarEliminarVisita()
        {
            DTipo_Actividad Datos = new DTipo_Actividad();
            return Datos.visualizarVisita();
        }

        public static DataTable ListarAsistencia()
        {
            DAsistencia Datos = new DAsistencia();
            return Datos.visualizarAsistencia();
        }

        public static DataTable ListarCheckList()
        {
            DCheckList Datos = new DCheckList();
            return Datos.visualizarcheckList();
        }
        
        public static string eliminarVisita(int idActividad)
        {
            DTipo_Actividad DatosT = new DTipo_Actividad();
            DActividad DatosA = new DActividad();

            string Existe = DatosA.existeActividadId(idActividad);

            if (Existe.Equals("0"))
            {
                return "La Actividad con ese ID, no existe!";
            }
            else
            {


                Tipo_Actividad ObjTP = new Tipo_Actividad();

                ObjTP.idActividad = idActividad;

                return DatosT.EliminarVisita(ObjTP);
            }
        }

        // TIPO ACTIVIDAD "ACCIDENTES"
        public static DataTable ListarAccidentes()
        {
            DTipo_Actividad Datos = new DTipo_Actividad();
            return Datos.visualizarAccidentes();
        }

       
    }
}
