using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_atencionticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsatencionticketc.wsatencionticketSoapClient ws = new wsatencionticketc.wsatencionticketSoapClient();
            DataSet ds = ws.Listadoats();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsatencionticketc.wsatencionticketSoapClient ws = new wsatencionticketc.wsatencionticketSoapClient();
            ws.insertatencionticket(int.Parse(idtickett.Text), int.Parse(idescritoriot.Text), int.Parse(idempleadot.Text), estadot.Text,observaciont.Text);
            DataSet ds = ws.Listadoats();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsatencionticketc.wsatencionticketSoapClient ws = new wsatencionticketc.wsatencionticketSoapClient();
            ws.actualizaratencionticket(int.Parse(idatenciont.Text), int.Parse(idtickett.Text), int.Parse(idescritoriot.Text), int.Parse(idempleadot.Text), estadot.Text,observaciont.Text);
            DataSet ds = ws.Listadoats();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            wsatencionticketc.wsatencionticketSoapClient ws = new wsatencionticketc.wsatencionticketSoapClient();
            ws.eliminaratencion(int.Parse(idatenciont.Text));
            DataSet ds = ws.Listadoats();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           idatenciont.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            idtickett.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            idescritoriot.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
           idempleadot.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
           estadot.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            observaciont.Text = GridView1.SelectedRow.Cells[6].Text.ToString();
        }
    }
}