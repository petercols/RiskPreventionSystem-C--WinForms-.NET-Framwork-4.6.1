using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public  class Usuario
    {
        public string rutUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }
        public int telefonoUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string domicilioUsuario { get; set; }
        public int habilitado { get; set; }

    }
}
