using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.Model.Manuel.Sinif
{
    class Temelİslem
    {
        // Mail gönderme kodları
        public void SendMail(ArrayList mailler, string icerik, string subject)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(Properties.Settings.Default.Email);
                foreach (var mail in mailler)
                {
                    message.To.Add(new MailAddress(mail.ToString()));

                }
                message.Subject = "Sifreniz";
                message.IsBodyHtml = true;  
                message.Body = icerik;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; 
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.Parola);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

            }
            catch (Exception hata)
            {

                throw new Exception(hata.Message, hata.InnerException);
            }
        }
    }

}
