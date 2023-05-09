using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;


namespace sistemadetickets.classes
{
    public class csusuario
    {
        //creacion de un metodo que retorna todos los datos de la tabla usuario 
        public DataSet lista_de_usuarios()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from usuario", cn);

                da.Fill(dsi);
                
                cn.Close();
            }

            catch (Exception)
            {

            }
            return dsi;
        }

        //validacion de usuario con contraseña
        public DataSet usuario(string idUsuario, string password)
        {
            DataSet dsi = new DataSet();

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from usuario where idUsuario= '" + idUsuario + "' and password='" + password + "' ", cn);
                da.Fill(dsi);
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return dsi;


        }
        //creacion de un metodo que inserta un usuario
        public Int32 insertar_un_usuario(string idUsuario, string carne, int idEmpleado, string correo, string password)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();
              

                MySqlCommand cmd = new MySqlCommand("insert into usuario (idUsuario, carne, idEmpleado, correo, password) values ('" + idUsuario + "','" + carne + "'," + idEmpleado + ",'" + correo + "', '" + password + "')", cn);

                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }
        public Int32 actualizacion_de_usuario(string idUsuario, string correo, string password)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();


                MySqlCommand cnd = new MySqlCommand("update usuario set correo ='" + correo + "',password ='" + password + "'where idUsuario='" + idUsuario + "' ", cn);

                respuesta = cnd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return respuesta;
        }
        public Int32 eliminar_un_usuario(string idUsuario)
        {
            Int32 respuesta = 0;

            try
            {

                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cnd = new MySqlCommand("delete from usuario where idUsuario='" + idUsuario + "'", cn);
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