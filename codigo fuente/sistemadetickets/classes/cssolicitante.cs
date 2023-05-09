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
    public class cssolicitante
    {

        public DataSet Lista_solicitante()
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from solicitante", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

       
        public DataSet solicitante(string carne)
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from solicitante where carne ='" + carne + "'", cn);

                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;

        }

        //creacion de un metodo que inserta un solicitante
        public Int32 insertar_solicitante(string carne, string nombre, string apellido, string correo)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into solicitante (carne,nombre,apellido,correo) values('" + carne + "','" + nombre + "','" + apellido + "','" + correo + "')", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }
        //Creacion de un métido que actualiza (hace update) una tabla
        public Int32 actualizar_solicitante(string carne, string nombre, string apellido, string correo)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update solicitante set carne ='" + carne + "', nombre ='" + nombre + "', apellido ='" + apellido + "', correo ='" + correo + "' where carne='" + carne + "' ", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
            }
            return respuesta;

        }
        //borrar solicitante
        public Int32 borrar_solicitante(string carne)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from solicitante where carne='" + carne + "' ", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }


    }

}

