using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Actividad
    {
        public int idActividad { get; set; }
        public int idServicio { get; set; }
        public string nombreActividad { get; set; }
        public string descripcionActividad { get; set; }
        public int estado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechTermino { get; set; }
    }
}

