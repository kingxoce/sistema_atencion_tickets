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
    public class csescritorio_virtual
    {

        public DataSet Escritorio()
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from escritorio_virtual", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

      
        public DataSet escritorio_virtual(int idEscritorio)
        {
            DataSet dsi = new DataSet();
            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from escritorio_virtual where idEscritorio =" +idEscritorio + " ", cn);

                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;

        }

        //creacion de un metodo que inserta un solicitante
        public Int32 insertar_escritoriol(int idEmpleado, int numero_de_computador)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into escritorio_virtual (idEmpleado,numero_de_computador) values(" + idEmpleado + "," + numero_de_computador + ")", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }
        //Creacion de un métido que actualiza (hace update) una tabla
        public Int32 actualizar_escritorio(int idEscritorio, int idEmpleado, int numero_de_computador)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update escritorio_virtual set numero_de_computador =" + numero_de_computador + ", idEmpleado =" + idEmpleado + " where idEscritorio=" + idEscritorio + " ", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
            }
            return respuesta;

        }
        //borrar Escritorio
        public Int32 borrar_escritorio(int idEscritorio)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from escritorio_virtual where idEscritorio=" + idEscritorio + " ", cn);
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
