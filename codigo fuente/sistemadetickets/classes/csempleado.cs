using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace sistemadetickets.classes
{
    public class csempleado
    {

        public DataSet listaempleado()
        {
            DataSet dts = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;

                da = new MySqlDataAdapter("select * from empleado", cn);

                da.Fill(dts);
                cn.Close();
            }
            catch (Exception ex)
            {

            }

            return dts;


        }

        public DataSet bempleado(int idempleado)
        {
            DataSet dti = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from empleado where idempleado= " + idempleado, cn);
                da.Fill(dti);
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return dti;
        }

        public Int32 insertarempleado(int idempleado, string nombre, string puesto, string correo, int telefono, string dirreccion, double sueldo)
        {
            Int32 re = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into empleado(idEmpleado, nombre, puesto, correo, telefono, dirreccion, sueldo) values(" + idempleado + ",'" + nombre + "','" + puesto + "','" + correo + "'," + telefono + ",'" + dirreccion + "'," + sueldo + ") ", cn);
                re = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }

            return re;
        }


        public Int32 actuempleado(int idEmpleado, string nombre, string puesto, string correo, int telefono, string dirreccion, double sueldo)
        {
            Int32 re = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("update empleado set idEmpleado= " + idEmpleado + ", nombre = '" + nombre + "', puesto ='" + puesto + "', correo ='" + correo + "', telefono=" + telefono + ", dirreccion='" + dirreccion + "', sueldo=" + sueldo + " where idEmpleado=" + idEmpleado + "", cn);
                re = cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {

            }

            return re;

        }

        public Int32 elimiempleado(int idEmpleado)
        {
            Int32 re = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from empleado where idEmpleado=" + idEmpleado + "", cn);
                re = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }

            return re;



        }

       /* public Int32 loginE(int idempleado)
        {
            int re = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnconexion"].ConnectionString;
                cn.Open();


                MySqlCommand cmd = new MySqlCommand("select * from empleado where idempleado= " + idempleado, cn);
                re = cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {

            }
            return re;
        }

        */











            }
        }

    
    
    

