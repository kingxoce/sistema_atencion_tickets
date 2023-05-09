using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class frmsolicitarticket : System.Web.UI.Page
    {
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Visible = false;
            if (!IsPostBack)
            {
                wsmotivodeatencionc.ws_motivo_de_atencionSoapClient motivoa = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
                DataSet dsmotivo = new DataSet();

                dsmotivo = motivoa.listado();

                DDmotivo.DataSource = dsmotivo;
                DDmotivo.DataValueField = "idAtencion";
                DDmotivo.DataTextField = "motivo";
                DDmotivo.DataBind();

                descripcion(Convert.ToInt32(DDmotivo.SelectedValue));

                DataColumn idmos = dt.Columns.Add("idmo", typeof(int));
                DataColumn carnes = dt.Columns.Add("carne", typeof(string));
                DataColumn motivos= dt.Columns.Add("motivo", typeof(string));
                

                Session["tablasesion"] = dt;


            }
        }

        protected void DDmotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcion(Convert.ToInt32(DDmotivo.SelectedValue));
        }

        protected void descripcion(int idAtencion)
        {
            wsmotivodeatencionc.ws_motivo_de_atencionSoapClient motivo = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
            DataSet mo = new DataSet();

            mo = motivo.Motivo_de_atencion(idAtencion);
            try
            {
                if (mo.Tables[0].Rows.Count > 0)
                {
                    desc.Text = mo.Tables[0].Rows[0]["descripcion"].ToString();
                }

            }
            catch(Exception ex)
            {

            }

            

        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            dt = Session["tablasesion"] as DataTable;
            DataRow fia = dt.NewRow();

            dt.Rows.Add(DDmotivo.SelectedValue, carnett.Text, DDmotivo.SelectedItem.ToString());
            GridView1.DataSource = dt;
            GridView1.DataBind();

            Session["tablasesion"] = dt;
            Button1.Visible = true;




        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                dt = (DataTable)Session["tablasesion"];
                dt.Rows.RemoveAt(index);

                GridView1.DataSource = dt;
                GridView1.DataBind();

                Session["tablasesion"] = dt;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsticketc.wsticketSoapClient ticket = new wsticketc.wsticketSoapClient();
            int resp;

            resp = ticket.insertar_Tickets(carnett.Text, Convert.ToInt32(DDmotivo.SelectedValue));
            if (resp == 1)
            {
                wsticketc.wsticketSoapClient ws = new wsticketc.wsticketSoapClient();
                DataSet ds = ws.reverse();


                string ticketn = ds.Tables[0].Rows[0]["idTicket"].ToString();


                wsatencionticketc.wsatencionticketSoapClient at = new wsatencionticketc.wsatencionticketSoapClient();

                at.insertatencionticket(Convert.ToInt32(ticketn),6,0,"pendiente","NA");
                Response.Redirect("paginaespera.aspx");
                


            }
            else
            {
               
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}