using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;


namespace Sistema.Negocio
{
    public class NPago
    {
        public static DataTable Listar()
        {
            DPago Datos = new DPago();
            return Datos.ListarPagos();
        }

        public static DataTable BuscarPago(string Valor)
        {
            DPago Datos = new DPago();
            return Datos.BuscarUsuarioXPago(Valor);
        }
      

        //NO LO HAGO YO LO HACE CLIENTE WEB...
        public static string InsertarPago
           (string rutUsuario, int valorTotal, string descripcion, DateTime fechaPago)
        {
            DPago DatosP = new DPago();
            //VALIDAR PAGO?
            //string Existe = DatosP.ExisteRutTest(rutUsuario);

            //if (Existe.Equals("0"))
            //{
            //    return "El Servicio con este rut ya existe!";
            //}           
            //else
            //{
            //string Existe = Datos.ExisteEmpresa(rutUsuario); 
            //if (Existe.Equals(Existe))
            //{
            //    return "La Empresa ya existe";
            //}
            //else

            Usuario ObjU = new Usuario();
            Pago ObjP = new Pago();
           
            ObjU.rutUsuario = rutUsuario;
            //Cargar datos de id servicio combo box consulta a la bd...
            //ObjP.idServicio = idServicio;
            ObjP.valorTotal = valorTotal;
            ObjP.descripcion = descripcion;
            ObjP.fechaPago = fechaPago;

            return DatosP.InsertarPago(ObjU,ObjP);
        }



    }
}
