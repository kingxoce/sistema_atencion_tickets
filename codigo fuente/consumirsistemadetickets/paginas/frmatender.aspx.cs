using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail; 
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace consumirsistemadetickets.paginas
{
    public partial class frmatender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


           


            label2.text="0";

            nticket.Text = Session["idticket"].ToString();
            carnett.Text = Session["carne"].ToString();
            fechatt.Text = Session["fecha"].ToString();
            motivott.Text = Session["atencion"].ToString();
            estadott.Text = Session["estado"].ToString();
            ida.Text = Session["idAtencionTicket"].ToString();
            correot.Text = Session["correo"].ToString();

           

            if (estadott.Text == "pendiente")
            {
                Label1.Text = "Usted está atendiendo el ticket al finalizar presione el boton Finalizar";
                estadott.BackColor = System.Drawing.Color.Red;
                avisar.Visible = true;
                darfin.Visible = true;
            } else if (estadott.Text == "atendido")
            {
                Label1.Text = "Este ticket ya fue atendido, Puede regresar a la pagina anterior";
                estadott.BackColor = System.Drawing.Color.Green;
                avisar.Visible = false;
                darfin.Visible = false;
                ob.Visible = false;
                obtxt.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:darkorange;}
                            </style>
                            <h1>Ticket siendo atendido</h1></br>
                            <h2>pongase en contacto con el remitente</h2>";

            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(correot.Text));
            email.From = new MailAddress("jmonroyf@miumg.edu.gt");
            email.Subject = "Su ticket está siendo atendido ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            email.Body = body;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //se omite en este documento la parte de la contraseña
            //en esta parte se ponen las credenciales del empleado
            client.Credentials = new NetworkCredential("jmonroyf@miumg.edu.gt","contraseña");
            client.EnableSsl = true;

            try
            {
                client.Send(email);
                email.Dispose();
                Label1.Text = "correo enviado exitosamente";
            }
            catch (Exception ex)
            {

            }





        }

        protected void darfin_Click(object sender, EventArgs e)
        {
            wsatencionticketc.wsatencionticketSoapClient atention = new wsatencionticketc.wsatencionticketSoapClient();
            string idem = Session["idempleado"].ToString();
            string ides = Session["idescrit"].ToString();

            try
            {
                if (obtxt.Text == "")
                {
                    atention.actualizaratencionticket(Convert.ToInt32(ida.Text), Convert.ToInt32(nticket.Text),Convert.ToInt32(ides),Convert.ToInt32(idem), "atendido", "NA");
                    estadott.Text = "atendido";
                    Response.Redirect("~/paginas/frmlista.aspx");
                }
                else
                {


                    atention.actualizaratencionticket(Convert.ToInt32(ida.Text), Convert.ToInt32(nticket.Text), Convert.ToInt32(ides), Convert.ToInt32(idem), "atendido", obtxt.Text);
                    estadott.Text = "atendido";
                    Response.Redirect("~/paginas/frmlista.aspx");


                }


            }
            catch
            {
                ob.Text = "No se pudo finalizar el ticket";
               

            }
                

                
            

            



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/paginas/frmlista.aspx");
        }
    }
}