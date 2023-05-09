using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsusuarioc.wsusuarioSoapClient ws = new wsusuarioc.wsusuarioSoapClient();
            DataSet ds = ws.listado_de_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idusuariot.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            carnett.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
           idempleadot.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            correot.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
           passwordt.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            wsusuarioc.wsusuarioSoapClient ws = new wsusuarioc.wsusuarioSoapClient();
            ws.insertar_un_usuario(idusuariot.Text, carnett.Text, int.Parse(idempleadot.Text), correot.Text, passwordt.Text);
            DataSet ds = ws.listado_de_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsusuarioc.wsusuarioSoapClient ws = new wsusuarioc.wsusuarioSoapClient();
            ws.actualizacion_de_usuario(idusuariot.Text, carnett.Text, int.Parse(idempleadot.Text), correot.Text, passwordt.Text);
            DataSet ds = ws.listado_de_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();


        }

        protected void eliminar_Click(object sender, EventArgs e)
        {
            wsusuarioc.wsusuarioSoapClient ws = new wsusuarioc.wsusuarioSoapClient();
            ws.eliminar_un_usuario(idusuariot.Text);
            DataSet ds = ws.listado_de_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }
    }
}