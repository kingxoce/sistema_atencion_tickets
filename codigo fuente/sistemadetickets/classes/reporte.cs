using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace sistemadetickets.classes
{
    public class reporte
    {
        public DataSet busqueda_ticket()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;

                da = new MySqlDataAdapter("select t.idTicket,s.nombre,s.carne,s.apellido,s.correo,m.motivo,a.estado_de_ticket from solicitante as s join atencion_del_ticket as a join motivo_de_atencion as m join ticket as t where s.carne=t.carne and t.idTicket=a.idTicket and t.idAtencion=m.idAtencion", cn);

                da.Fill(dsi);

                cn.Close();
            }
            catch (Exception ex)
            {

            }

            return dsi;
        }


        public DataSet busquedaporfecha(int fecha1,int fecha2)
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;

                da = new MySqlDataAdapter("select t.idTicket,e.idEscritorio,em.idEmpleado,m.idAtencion,a.fecha_t,a.estado_de_ticket from ticket as t join atencion_del_ticket as a join motivo_de_atencion as m join escritorio_virtual as e join empleado as em where em.idEmpleado=e.idEmpleado and t.idTicket= a.idTicket  and e.idEscritorio=a.idEscritorio and t.idAtencion=m.idAtencion and a.fecha_t between "+fecha1+" and "+fecha2+" and a.estado_de_ticket='atendido' ", cn);

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