using IubShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace IubShop.Libraries.Email
{
    public class ContactEmail
    {
        public static void SenderContactEmail(Contact contact)
        {
            /*
             * SMTP -> Servidor que vai enviar a mensagem
             */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("diego.slashlp@gmail.com", "");
            smtp.EnableSsl = true;

            string bodyMsg = string.Format("<h2>Contato - IubShop</h2>" + 
                "<b>Nome:</b> {0} <br />" +
                "<b>E-mail:</b> {1} <br />" +
                "<b>Assunto:</b> {2} <br />" +
                "<b>Mensagem:</b> {3} <br /><br />" +
                "<p>E-mail enviado automaticamente do site IubShop.</p>",
                contact.Name, contact.Email, contact.Subject, contact.Message);

            /*
             * MailMessage -> Construir a mensagem
             */
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("diego.slashlp@gmail.com");
            msg.To.Add("diego.slashlp@gmail.com");
            msg.Subject = "Contato IubShop - " + contact.Email;
            msg.Body = bodyMsg;
            msg.IsBodyHtml = true;

            // Processo de envio de mensagem com smtp
            smtp.Send(msg);
        }
    }
}
