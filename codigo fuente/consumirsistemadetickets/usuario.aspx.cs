using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_SistemadeTickets
{
    public partial class usuario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btNREPORTES_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nosotros.aspx");
        }

        protected void btnusuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("contactenos.aspx");
        }

        protected void btntickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmsolicitarticket.aspx");
        }
    }
}