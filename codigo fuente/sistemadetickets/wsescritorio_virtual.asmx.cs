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
    /// Descripción breve de swescritorio_virtual
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class wsescritorio_virtual : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listadoescritorio()
        {
            return new classes.csescritorio_virtual().Escritorio();
        }
        [WebMethod]
        public DataSet escritorio(int idEscritorio)
        {
            return new classes.csescritorio_virtual().escritorio_virtual(idEscritorio);
        }
        [WebMethod]
        public Int32 insertar_escritorio(int idEmpleado, int numero_de_computador)
        {
            return new classes.csescritorio_virtual().insertar_escritoriol(idEmpleado, numero_de_computador);
        }
        [WebMethod]
        public Int32 actualizar_escritorio(int idEscritorio, int idEmpleado, int numero_de_computador)
        {
            return new classes.csescritorio_virtual().actualizar_escritorio(idEscritorio, idEmpleado, numero_de_computador);
        }
        [WebMethod]
        public Int32 borrar_escritorio(int idEscritorio)
        {
            return new classes.csescritorio_virtual().borrar_escritorio(idEscritorio);
        }

    }
}