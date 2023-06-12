using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;


namespace Sistema.Negocio
{
    public class NFondoMonetario
    {
      

        public static string Insertar
            (string rutUsuario, int montoAbono, DateTime fechaAbono)
        {
            DFondoMonetario DatosFM = new DFondoMonetario();
            DUsuario DatosU = new DUsuario();

            string Existe = DatosU.ExisteRutTest(rutUsuario);
            string ExisteFondoMonetario = DatosFM.existeFondoMonetario(rutUsuario);

            if (Existe.Equals("1"))
            {
                return "El Fondo Monetario con este rut ya existe!";
            }
            else
            {
                if (ExisteFondoMonetario.Equals("1"))
                {
                    return "El Fondo monetario con este RUT ya existe!";
                }
                else
                {
                    Usuario ObjU = new Usuario();
                    FondoMonetario ObjFM = new FondoMonetario();
                    ObjU.rutUsuario = rutUsuario;
                    ObjFM.montoAbono = montoAbono;
                    ObjFM.fechaAbono = fechaAbono;
                    //mantener orden igual que en DUSUARIO PARAMETRO!!!
                    return DatosFM.InsertarFM(ObjU, ObjFM);
                }
            }
        }
    }
}
