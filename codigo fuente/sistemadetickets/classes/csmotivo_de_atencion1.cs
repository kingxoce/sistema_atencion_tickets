using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;



namespace sistemadetickets.classes
{
    public class csmotivo_de_atencion
    {
        //creacion de un metodo que retorna todos los datos de la tabla usuario 
        public DataSet lista_motivo_de_atencion()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from motivo_de_atencion", cn);

                da.Fill(dsi);
                cn.Close();
            }

            catch (Exception)
            {

            }
            return dsi;
        }

        //creacion de un metodo que busca un motivo por su idAtencion
        public DataSet motivo_de_atencion(int idAtencion)//busqueda de motivo por su idAtencion
        {
            DataSet dsi = new DataSet();

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from motivo_de_atencion where idAtencion= '" + idAtencion + "' ", cn);
                da.Fill(dsi);
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return dsi;


        }
        //creacion de un metodo que inserta un motivo de atencion
        public Int32 insertar_motivo_de_atencion(int idAtencion, string motivo, string descripcion)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                

                MySqlCommand cmd = new MySqlCommand("insert into motivo_de_atencion (idAtencion, motivo, descripcion) values (" + idAtencion + ",'" + motivo + "','" + descripcion + "')", cn);

                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 actualizacion_motivo_de_atencion(int idAtencion, string motivo, string descripcion)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();


                MySqlCommand cnd = new MySqlCommand("update motivo_de_atencion set motivo ='" + motivo + "',descripcion ='" + descripcion + "'where idAtencion='" + idAtencion + "' ", cn);

                respuesta = cnd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 eliminar_motivo_de_atencion(int idAtencion)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlCommand cnd = new MySqlCommand("delete from motivo_de_atencion where idAtencion=" + idAtencion + "", cn);
                respuesta = cnd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {

            }

            return respuesta;
        }


    }
}