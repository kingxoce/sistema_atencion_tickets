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
    /// Descripción breve de wsmotivo_de_atencion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ws_motivo_de_atencion : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listado()
        {
            return new classes.csmotivo_de_atencion().lista_motivo_de_atencion();

        }

        [WebMethod]

        public DataSet Motivo_de_atencion(int idAtencion)
        {
            return new classes.csmotivo_de_atencion().motivo_de_atencion(idAtencion);
        }

        [WebMethod]

        public Int32 insertar_motivo_de_atencion(int idAtencion, string motivo, string descripcion)
        {
            return new classes.csmotivo_de_atencion().insertar_motivo_de_atencion(idAtencion, motivo, descripcion);
        }

        [WebMethod]

        public Int32 actualizacion_motivo_de_atencion(int idAtencion, string motivo, string descripcion)
        {
            return new classes.csmotivo_de_atencion().actualizacion_motivo_de_atencion(idAtencion, motivo, descripcion);

        }

        [WebMethod]

        public Int32 eliminar_motivo_de_atencion(int idAtencion)
        {
            return new classes.csmotivo_de_atencion().eliminar_motivo_de_atencion(idAtencion);
        }

    }

}

