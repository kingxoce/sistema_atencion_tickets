using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_escritoriovirtual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsescritoriovirtualc.wsescritorio_virtualSoapClient ws = new wsescritoriovirtualc.wsescritorio_virtualSoapClient();
            DataSet ds = ws.listadoescritorio();         
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idescritoriot.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            idempleatot.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            numeropct.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsescritoriovirtualc.wsescritorio_virtualSoapClient ws = new wsescritoriovirtualc.wsescritorio_virtualSoapClient();
            ws.insertar_escritorio(int.Parse(idempleatot.Text),int.Parse(numeropct.Text));
            DataSet ds = ws.listadoescritorio();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsescritoriovirtualc.wsescritorio_virtualSoapClient ws = new wsescritoriovirtualc.wsescritorio_virtualSoapClient();
            ws.actualizar_escritorio(int.Parse(idescritoriot.Text), int.Parse(idempleatot.Text), int.Parse(numeropct.Text));
            DataSet ds = ws.listadoescritorio();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            wsescritoriovirtualc.wsescritorio_virtualSoapClient ws = new wsescritoriovirtualc.wsescritorio_virtualSoapClient();
            ws.borrar_escritorio(int.Parse(idescritoriot.Text));
            DataSet ds = ws.listadoescritorio();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}