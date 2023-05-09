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
    /// Descripción breve de reportes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class reportes : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet buscartickets()
        {
            return new classes.reporte().busqueda_ticket();
        }

        [WebMethod]
        public DataSet buscarescritorio(int fecha1i, int fecha2f)
        {
            return new classes.reporte().busquedaporfecha(fecha1i ,fecha2f);
        }
    }
}
