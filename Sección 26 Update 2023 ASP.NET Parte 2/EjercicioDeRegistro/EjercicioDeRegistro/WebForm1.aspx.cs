using System;
using System.IO;
using System.Web.UI;

namespace EjercicioDeRegistro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.HttpMethod == "POST")
                {

                string nombre = Request.Form["Name"];
                string email = Request.Form["Email"];

                //Escribir los datos en el archivo

                string rutaArchivo = Server.MapPath("~/datos.txt");

                using (StreamWriter sw = File.AppendText(rutaArchivo))
                {
                    sw.WriteLine("Nombre " + nombre);
                    sw.WriteLine("Email " + email);
                    sw.WriteLine("Fecha y hora " + DateTime.Now.ToString());
                    sw.WriteLine();
                }

                Response.Redirect("gracias.html");

            }

        }
    }
}