using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Utilidades
{
    public class Operaciones
    {

        public static Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        public static byte[] ImageToByte(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public static string GenerarIdProducto()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0, 15);
            return clave;
        }


        public static bool EnviarCorreo(string correo, string asunto, string mensaje)
        {
            bool resultado = false;
            try
            {
                

                Correo obj = LO_Correo.Instancia.ObtenerCorreo();


                //usar referencia System.Net.Mail y using System.Net;

                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress(obj.Email);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential(obj.Email,obj.Clave),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                smtp.Send(mail);
                resultado = true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                resultado = false;
            }

            return resultado;
        }


        public async Task EnviarCorreo2(string correo, string asunto, string mensaje)
        {
            
                Correo obj = LO_Correo.Instancia.ObtenerCorreo();

                bool obtenido = true;
                byte[] byteimage = LO_Dato.Instancia.ObtenerLogo(out obtenido);
                string base64String = Convert.ToBase64String(byteimage, 0, byteimage.Length);

                //validamos el formato de la imagen
                string tipo_imagen = string.Empty;
                MemoryStream ms = new MemoryStream(byteimage);
                Image img = Image.FromStream(ms);

                if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                    tipo_imagen = "data:image/png;base64,";
                else
                    tipo_imagen = "data:image/jpg;base64,";


                mensaje = mensaje.Replace("!imagen!", tipo_imagen + base64String);

                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress(obj.Email);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential(obj.Email, obj.Clave),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

              await smtp.SendMailAsync(mail);
        }

        public static bool EnviarCorreo3(string correo, string asunto, string mensaje) {

            bool resultado = false;
            try
            {
                Correo obj = LO_Correo.Instancia.ObtenerCorreo();

                bool obtenido = true;
                byte[] byteimage = LO_Dato.Instancia.ObtenerLogo(out obtenido);
                string base64String = Convert.ToBase64String(byteimage, 0, byteimage.Length);

                //validamos el formato de la imagen
                string tipo_imagen = string.Empty;
                MemoryStream ms = new MemoryStream(byteimage);
                Image img = Image.FromStream(ms);

                if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                    tipo_imagen = "data:image/png;base64,";
                else
                    tipo_imagen = "data:image/jpg;base64,";


                mensaje = mensaje.Replace("!imagen!", tipo_imagen + base64String);

                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress(obj.Email);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential(obj.Email, obj.Clave),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                smtp.Send(mail);
                smtp.Dispose();

                resultado = true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                resultado = false;
            }

            return resultado;

        }


    }
}
