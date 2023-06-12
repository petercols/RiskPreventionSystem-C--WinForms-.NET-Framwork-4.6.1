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
    public class NActividad
    {   
        public static DataTable Listar()
        {
            DActividad Datos = new DActividad();
            return Datos.Listar();
        }

        public static string ActualizarEstado(int idActividad, int estado)
        {
            DActividad Datos = new DActividad();
            Actividad Obj = new Actividad();

            string ExisteServicio = Datos.existeActividadId(idActividad);

            if (ExisteServicio.Equals("0"))
            {
                return "La Actividad con este ID no existe!";
            }
            else
            {
                if (idActividad.Equals(idActividad))
                {
                    Obj.idActividad = idActividad;
                    Obj.estado = estado;
                    return Datos.editarEstadoActividad(Obj);
                }
                else
                {
                    return "El Servicio con este ID no existe!";
                }
            }

        }

        public static string SuspencionActividad_modificar(string rutUsuario, int idActividad)
        {
            DActividad DatosA = new DActividad();
            DActividad DatosActividad = new DActividad();
            Actividad ObjA = new Actividad();

            if (idActividad.Equals(idActividad))
            {
                ObjA.idActividad = idActividad;
                return DatosActividad.EditarEstadoActividad(ObjA);
            }
            else
            {
                return "X ALERTA";
            }
        }

        public static string editarActividadHabilitada(string rutUsuario, int idActividad)
        {
            DActividad DatosA = new DActividad();
            DActividad DatosActividad = new DActividad();
            Actividad ObjA = new Actividad();
            if (idActividad.Equals(idActividad))
            {
                ObjA.idActividad = idActividad;
                return DatosActividad.EditarEstadoServicioH(ObjA);
            }
            else
            {
                return "X ALERTA";
            }
        }
    }
}
