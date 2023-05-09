using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_SistemadeTickets
{
    public partial class formularios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("f_atencionticket.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("f_empleado.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("f_escritoriovirtual.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("f_motivoatencion.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("f_solicitante.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("f_usuario.aspx");
        }
    }
}