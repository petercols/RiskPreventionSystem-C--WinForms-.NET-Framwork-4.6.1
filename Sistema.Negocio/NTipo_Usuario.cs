using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class NTipo_Usuario
    {
        public static DataTable Listar()
        {
            DTipoUsuario Datos = new DTipoUsuario();
            return Datos.ListarTipoUsuario();
        }

    }
}
