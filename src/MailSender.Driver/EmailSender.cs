using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Driver
{
    public partial class EmailSender
    {
        public String EmailServer { get; set; }
        public String Username { get; private set; }
        public String Password { get; private set; }

        public EmailSender(String outgoingServer)
        {
            EmailServer = outgoingServer;
        }

        public EmailSender()
        {
        }

        public void SetCredentials(String username, String password)
        {
            Username = username;
            Password = password;
        }

        public void Send(EmailMessage message)
        {
            var mail = new MailMessage();
            mail.To.Add(message.ToAddress);
            mail.From = new MailAddress(message.FromAddress);
            mail.Subject = message.Subject;
            mail.Body = message.Message;
            mail.IsBodyHtml = true;

            var smtp = new SmtpClient(EmailServer, 587);
            smtp.Credentials = new NetworkCredential(Username, Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        public static bool SendMail(string toMail, string whoMail, string subjectMail, string contentMail, string smtpMail, string passMail)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(toMail);
            mail.From = new MailAddress(whoMail);
            mail.Subject = subjectMail;
            string Body;
            Body = string.Format("");
            Body += contentMail;

            mail.Body = Body;
            mail.IsBodyHtml = true;

            var smtp = new SmtpClient("localhost", 587);
            smtp.Host = smtpMail;
            smtp.Credentials = new System.Net.NetworkCredential(whoMail, passMail);

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Port = 587;
            smtp.Host = smtpMail;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return true;
        }
    }
}
