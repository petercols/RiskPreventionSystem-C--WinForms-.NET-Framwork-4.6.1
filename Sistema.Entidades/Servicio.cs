using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Servicio
    {
        public int idServicio { get; set; }
        public int foliContrato { get; set; }
        public string nombreServicio { get; set; }
        public int valorServicio { get; set; }
        public string descripcionServicio { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaTermino { get; set; }
        public int estado { get; set; }
        public int pagado { get; set; }
    }
}
