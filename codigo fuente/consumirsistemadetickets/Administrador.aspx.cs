using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Login_SistemadeTickets
{
    public partial class administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id;
            id=Session["login"].ToString();
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuario where idUsuario='"+id+"' ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            string idempleado = dt.Rows[0][2].ToString();
            int idem = Convert.ToInt32(idempleado);
            cn.Close();


            cn.Open();
            MySqlCommand cmd2 = cn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from escritorio_virtual where idEmpleado="+idem+" ";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            string idescritorio = dt2.Rows[0][0].ToString();
            cn.Close();

            Session["idempleado"] = idempleado;
            Session["idescrit"] = idescritorio;
            




        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnusuarios_Click(object sender, EventArgs e)
        {

        }

        protected void btntickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/paginas/frmlista.aspx");
        }

        protected void btNREPORTES_Click(object sender, EventArgs e)
        {
            Response.Redirect("menureportes.aspx");
        }
    }
}