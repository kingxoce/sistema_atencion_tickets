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
    /// Descripción breve de WSsolicitante
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wssolicitante : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listadosolicitantes()
        {
            return new classes.cssolicitante().Lista_solicitante();
        }
        [WebMethod]
        public DataSet solicitante(string carne)
        {
            return new classes.cssolicitante().solicitante(carne);
        }
        [WebMethod]
        public Int32 insertar_solicitante(string carne, string nombre, string apellido, string correo)
        {
            return new classes.cssolicitante().insertar_solicitante(carne, nombre, apellido, correo);
        }
        [WebMethod]
        public Int32 actualizar_solicitante(string carne, string nombre, string apellido, string correo)
        {
            return new classes.cssolicitante().actualizar_solicitante(carne, nombre, apellido, correo);
        }
        [WebMethod]
        public Int32 borrar_solicitante(string carne)
        {
            return new classes.cssolicitante().borrar_solicitante(carne);
        }

    }
}