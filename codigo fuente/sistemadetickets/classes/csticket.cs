using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Runtime.Remoting.Messaging;
using System.Web.UI.WebControls;

namespace sistemadetickets.classes
{
    public class csticket

    {

        public DataSet Lista_Tickets()
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from ticket", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public DataSet reverselist()
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from ticket order by idTicket desc", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;
        }


        public DataSet listao(int idatencion,string estado)
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select  ticket.idTicket,ticket.carne,fecha,idAtencion,estado_de_ticket,idAtencionTicket,s.correo from ticket join atencion_del_ticket join solicitante as s on ticket.idTicket = atencion_del_ticket.idTicket where ticket.carne=s.carne  and idAtencion="+idatencion+" and estado_de_ticket='"+estado+"'", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;
        }








        public DataSet Tickets(int idTicket)
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from ticket where idTicket =" + idTicket + "", cn);

                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;

        }

  
        public Int32 insertar_Tickets(string carne, Int32 idAtencion)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into ticket (carne,idAtencion,fecha) values('" + carne + "'," + idAtencion + ",NOW())", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        
        public Int32 actualizar_tickets(int idTicket, string carne, Int32 idAtencion)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update ticket set carne ='" + carne + "', idAtencion =" + idAtencion + ", fecha=NOW() where idTicket=" + idTicket + " ", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
            }
            return respuesta;

        }

       
        public Int32 borrar_tickets(int idTicket)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from ticket where idTicket=" + idTicket + " ", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }


        public DataSet buscar_por_motivo(int idAtencion)
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from ticket where idAtencion =" + idAtencion + "", cn);

                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;

        }
    }

}