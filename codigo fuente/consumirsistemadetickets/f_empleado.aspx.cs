using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsempleadoc.wsempleadoSoapClient ws = new wsempleadoc.wsempleadoSoapClient();
            DataSet ds = ws.listaempleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idempleadot.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            nombret.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            puestot.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            correot.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            telefonot.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            direcciont.Text = GridView1.SelectedRow.Cells[6].Text.ToString();
            sueldot.Text = GridView1.SelectedRow.Cells[7].Text.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsempleadoc.wsempleadoSoapClient ws = new wsempleadoc.wsempleadoSoapClient();
            ws.insertar_empleado(int.Parse(idempleadot.Text),nombret.Text,puestot.Text,correot.Text,int.Parse(telefonot.Text),direcciont.Text,double.Parse(sueldot.Text));
            DataSet ds = ws.listaempleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsempleadoc.wsempleadoSoapClient ws = new wsempleadoc.wsempleadoSoapClient();
            ws.actualizar_empleado(int.Parse(idempleadot.Text), nombret.Text, puestot.Text, correot.Text, int.Parse(telefonot.Text), direcciont.Text, double.Parse(sueldot.Text));
            DataSet ds = ws.listaempleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            wsempleadoc.wsempleadoSoapClient ws = new wsempleadoc.wsempleadoSoapClient();
            ws.eliminar_empleado(int.Parse(idempleadot.Text));
            DataSet ds = ws.listaempleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}