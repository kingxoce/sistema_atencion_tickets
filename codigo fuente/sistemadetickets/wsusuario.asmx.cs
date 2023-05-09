using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace sistemadetickets
{
    /// <summary>
    /// Descripción breve de wsusuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsusuario : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listado_de_usuarios()
        {
            return new classes.csusuario().lista_de_usuarios();

        }

        [WebMethod]

        public DataSet usuario(string idUsuario, string password)
        {
            return new classes.csusuario().usuario(idUsuario, password);
        }

        [WebMethod]

        public Int32 insertar_un_usuario(string idUsuario, string carne, int idEmpleado, string correo, string password)
        {
            return new classes.csusuario().insertar_un_usuario(idUsuario, carne, idEmpleado, correo, password);
        }

        [WebMethod]

        public Int32 actualizacion_de_usuario(string idUsuario, string carne, Int32 idEmpleado, string correo, string password)
        {
            return new classes.csusuario().actualizacion_de_usuario(idUsuario, correo, password);

        }

        [WebMethod]

        public Int32 eliminar_un_usuario(string idUsuario)
        {
            return new classes.csusuario().eliminar_un_usuario(idUsuario);
        }
    }
}
