using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Pago
    {
        public int idPago { get; set; }
        public int idServicio { get; set; }
        public int valorTotal { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaPago { get; set; }
    }
}
