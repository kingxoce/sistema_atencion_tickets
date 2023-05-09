using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemadetickets.classes
{
    public class csatencionticket
    {
        public DataSet lista_at()
        {
            DataSet dsi = new DataSet();
            try

            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from atencion_del_ticket", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;



        }

        public DataSet atencionticket(int idAtencionticket)
        {
            DataSet dti = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from atencion_del_ticket where idAtencionTicket = " + idAtencionticket, cn);
                da.Fill(dti);
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return dti;
        }

        public Int32 insertatenciontickets(int idTicket, int idEscritorio, int idEmpleado, string estado_de_ticket,string observaciones)

        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into atencion_del_ticket(idTicket,idEscritorio,idEmpleado,estado_de_ticket,observaciones,fecha_t,tiempodeatencion) " +
                    "values(" + idTicket + "," + idEscritorio + "," + idEmpleado + ",'" + estado_de_ticket + "','" + observaciones + "',now(),(SELECT TIMEDIFF(now(),fecha)as resta from ticket where idTicket="+idTicket+")) ", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }

            return respuesta;


        }

        public Int32 actualizaratencion(int idAtencionTicket ,int idTicket, int idEscritorio, int idEmpleado, string estado_de_ticket,string observaciones)


        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("update atencion_del_ticket set idTicket ="+idTicket+", idEscritorio="+idEscritorio+", idEmpleado="+idEmpleado+", estado_de_ticket='"+estado_de_ticket+"',observaciones='"+observaciones+ "',fecha_t=now(),tiempodeatencion=(SELECT TIMEDIFF(now(),fecha)as resta from ticket where idTicket=" + idTicket + ") where idAtencionTicket=" + idAtencionTicket+"", cn);

                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {

            }

            return respuesta;

        }

        public Int32 eliminaratencion(int idAtencionticket)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from  atencion_del_ticket where idAtencionTicket=" + idAtencionticket + "", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }

            return respuesta;

        }

        public DataSet buscar_por_fecha(Int64 fecha)
        {
            DataSet dti = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from atencion_del_ticket where fecha_t = " + fecha, cn);
                da.Fill(dti);
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return dti;
        }


    }

}