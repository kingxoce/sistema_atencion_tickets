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
    /// Descripción breve de swtickets
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsticket : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet Lista_Tickets()
        {
            return new classes.csticket().Lista_Tickets();
        }

        [WebMethod]
        public DataSet reverse()
        {
            return new classes.csticket().reverselist();
        }

        [WebMethod]
        public DataSet Tickets(int idTicket)
        {
            return new classes.csticket().Tickets(idTicket);
        }
        [WebMethod]
        public Int32 insertar_Tickets(string carne, Int32 idAtencion)
        {
            return new classes.csticket().insertar_Tickets(carne, idAtencion);
        }
        [WebMethod]
        public Int32 actualizar_tickets(Int32 idTicket, String carne, Int32 idAtencion)
        {
            return new classes.csticket().actualizar_tickets(idTicket, carne, idAtencion);
        }
        [WebMethod]
        public Int32 borrar_tickets(int idticket)
        {
            return new classes.csticket().borrar_tickets(idticket);
        }

        [WebMethod]
        public DataSet buscar_por_motivos(int idAtencion)
        {
            return new classes.csticket().buscar_por_motivo(idAtencion);
        }

        [WebMethod]
        public DataSet listado2(int idAtencion,string estado)
        {
            return new classes.csticket().listao(idAtencion,estado);
        }


    }
}
