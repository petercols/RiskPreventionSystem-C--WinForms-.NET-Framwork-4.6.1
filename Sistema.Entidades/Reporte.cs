using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    //ID_REPORTE NUMBER(8) NOT NULL,
    //ID_TIPO_ACTIVIDAD   NUMBER(8),
    //NOMBRE_REPORTE VARCHAR2(50),
    //ARCHIVO VARCHAR2(255),
    //DESCRIPCION_REPORTE VARCHAR2(255),
    //FECHA_EMISION DATE

    public class Reporte
    {
        public int idReporte { get; set; }
        public int idTipoActividad { get; set; }
        public string nombreReporte { get; set; }
        //QUIZAS SACAR!
        public string archivo { get; set; }
        public string descripcionReporte { get; set; }
        public DateTime fechaEmision { get; set; }

    }
}
