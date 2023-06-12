using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Contrato
    {
        public int folioContrato { get; set; }
        public int idTipoUsuario  { get; set; }
        public DateTime fechaContrato { get; set; }
        public string plazoContrato { get; set; }
        public int montoPago { get; set; }
        public int modificado { get; set; }
        public int estado { get; set; }
    }
}
