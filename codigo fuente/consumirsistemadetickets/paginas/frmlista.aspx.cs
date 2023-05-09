using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets.paginas
{
    public partial class frmlista : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                wsmotivodeatencionc.ws_motivo_de_atencionSoapClient motivoa = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
                DataSet dsmotivo = new DataSet();

                dsmotivo = motivoa.listado();

                DDm.DataSource = dsmotivo;
                DDm.DataValueField = "idAtencion";
                DDm.DataTextField = "motivo";
                DDm.DataBind();


                


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsticketc.wsticketSoapClient listame = new wsticketc.wsticketSoapClient();
            DataSet listadito = new DataSet();

            listadito = listame.listado2(Convert.ToInt32(DDm.SelectedValue), DDe.SelectedItem.ToString());

            GridView1.DataSource = listadito.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["idticket"] = GridView1.SelectedRow.Cells[1].Text.ToString();
            Session["carne"] = GridView1.SelectedRow.Cells[2].Text.ToString();
            Session["fecha"] = GridView1.SelectedRow.Cells[3].Text.ToString();
            Session["atencion"] = DDm.SelectedItem.ToString();
            Session["estado"] = GridView1.SelectedRow.Cells[5].Text.ToString();
            Session["idAtencionTicket"] = GridView1.SelectedRow.Cells[6].Text.ToString();
            Session["correo"] = GridView1.SelectedRow.Cells[7].Text.ToString();
            Response.Redirect("frmatender.aspx");



        }
    }
}