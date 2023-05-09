using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_motivoatencion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsmotivodeatencionc.ws_motivo_de_atencionSoapClient ws = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
            DataSet ds = ws.listado();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idatenciont.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            motivot.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            descripciont.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsmotivodeatencionc.ws_motivo_de_atencionSoapClient ws = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
            ws.insertar_motivo_de_atencion(int.Parse(idatenciont.Text),motivot.Text,descripciont.Text);
            DataSet ds = ws.listado();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsmotivodeatencionc.ws_motivo_de_atencionSoapClient ws = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
            ws.actualizacion_motivo_de_atencion(int.Parse(idatenciont.Text), motivot.Text, descripciont.Text);
            DataSet ds = ws.listado();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        

        protected void Button3_Click1(object sender, EventArgs e)
        {
            wsmotivodeatencionc.ws_motivo_de_atencionSoapClient ws = new wsmotivodeatencionc.ws_motivo_de_atencionSoapClient();
            ws.eliminar_motivo_de_atencion(int.Parse(idatenciont.Text));
            DataSet ds = ws.listado();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }
    }
}