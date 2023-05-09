using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets
{
    public partial class f_solicitante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wssolicitantec.wssolicitanteSoap ws = new wssolicitantec.wssolicitanteSoapClient();
            DataSet ds = ws.listadosolicitantes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wssolicitantec.wssolicitanteSoapClient ws = new wssolicitantec.wssolicitanteSoapClient(); ;
            ws.insertar_solicitante(carnett.Text,nombret.Text,apellidot.Text,correot.Text);
            DataSet ds = ws.listadosolicitantes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            carnett.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            nombret.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            apellidot.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            correot.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
        }

        
        protected void Button3_Click(object sender, EventArgs e)
        {
            wssolicitantec.wssolicitanteSoapClient ws = new wssolicitantec.wssolicitanteSoapClient();
            ws.borrar_solicitante(carnett.Text);
            DataSet ds = ws.listadosolicitantes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            wssolicitantec.wssolicitanteSoapClient ws = new wssolicitantec.wssolicitanteSoapClient();
            ws.actualizar_solicitante(carnett.Text, nombret.Text, apellidot.Text, correot.Text);
            DataSet ds = ws.listadosolicitantes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}