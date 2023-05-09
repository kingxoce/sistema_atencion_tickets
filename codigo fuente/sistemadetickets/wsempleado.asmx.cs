using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;

namespace sistemadetickets
{
    /// <summary>
    /// Descripción breve de wsempleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsempleado : System.Web.Services.WebService
    {



        [WebMethod]
        public DataSet listaempleados()
        {
            return new classes.csempleado().listaempleado();
        }

        [WebMethod]
        public DataSet buscar_empleados(int idempleado)
        {
            return new classes.csempleado().bempleado(idempleado);
        }

        [WebMethod]
        public Int32 insertar_empleado(int idEmpleado, string nombre, string puesto, string correo, int telefono, string dirreccion, double sueldo)
        {
            return new classes.csempleado().insertarempleado(idEmpleado,nombre,puesto,correo,telefono,dirreccion,sueldo); 
        }

        [WebMethod]
        public Int32 actualizar_empleado(int idEmpleado, string nombre, string puesto, string correo, int telefono, string dirreccion, double sueldo)
        {
            return new classes.csempleado().actuempleado(idEmpleado, nombre, puesto, correo, telefono, dirreccion, sueldo);
        }

        [WebMethod]
        public Int32 eliminar_empleado(int idEmpleado)
        {
            return new classes.csempleado().elimiempleado(idEmpleado);
        
        }

       




    }
}