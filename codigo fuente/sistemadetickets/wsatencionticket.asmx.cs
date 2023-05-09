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
    /// Descripción breve de wsatencionticket
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsatencionticket : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet Listadoats()
        {
            return new classes.csatencionticket().lista_at();
        }


        [WebMethod]
        public DataSet atencionticket (int idAtencionTicket)
        {
            return new classes.csatencionticket().atencionticket(idAtencionTicket);
        }

        [WebMethod]
        public Int32 insertatencionticket(int idTicket, int idEscritorio, int idEmpleado, string estado_de_ticket, string observaciones)


        {
            return new classes.csatencionticket().insertatenciontickets(idTicket, idEscritorio, idEmpleado, estado_de_ticket,observaciones);
       
        }

        [WebMethod]
        public Int32 actualizaratencionticket(int idAtencionTicket, int idTicket, int idEscritorio, int idEmpleado, string estado_de_ticket, string observaciones)


        {
            return new classes.csatencionticket().actualizaratencion(idAtencionTicket ,idTicket, idEscritorio, idEmpleado, estado_de_ticket,observaciones);

        }

        [WebMethod]
        public Int32 eliminaratencion(int idAtencionTicket)
        {
            return new classes.csatencionticket().eliminaratencion(idAtencionTicket);
        }
        //este metodo aun se está trabajando
        [WebMethod]
        public DataSet buscar_por_fechas(Int64 fecha)
        {
            return new classes.csatencionticket().buscar_por_fecha(fecha);
        }



    }
}
