using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Login_SistemadeTickets
{
   
    public partial class Login : System.Web.UI.Page
    {

       
        protected void btningresar_Click(object sender, EventArgs e)
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *  FROM roles WHERE idUsuario='" +txtusuario.Text+ "' and password='" + txtpassword.Text + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Session["login"] = dt.Rows[0][2].ToString();
            if (dt.Rows.Count == 1)
            {
              if (dt.Rows[0][1].ToString() == "2")
            {
                    Response.Redirect("usuario.aspx");
                    

                }
            else if (dt.Rows[0][1].ToString()=="1") 
                {

                    Response.Redirect("Administrador.aspx");
                    
                }
            }


            cn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}