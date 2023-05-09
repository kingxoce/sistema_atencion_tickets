using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_ticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsticketc.wsticketSoapClient ws = new wsticketc.wsticketSoapClient();
            DataSet ds = ws.Lista_Tickets();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtickettt.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            carnett.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            idatenciont.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsticketc.wsticketSoapClient ws = new wsticketc.wsticketSoapClient();
            ws.insertar_Tickets(carnett.Text, int.Parse(idatenciont.Text));
            DataSet ds = ws.Lista_Tickets();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsticketc.wsticketSoapClient ws = new wsticketc.wsticketSoapClient();
            ws.actualizar_tickets(int.Parse(idtickettt.Text), carnett.Text, int.Parse(idatenciont.Text));
            DataSet ds = ws.Lista_Tickets();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            wsticketc.wsticketSoapClient ws = new wsticketc.wsticketSoapClient();
            ws.borrar_tickets(int.Parse(idtickettt.Text));
            DataSet ds = ws.Lista_Tickets();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}