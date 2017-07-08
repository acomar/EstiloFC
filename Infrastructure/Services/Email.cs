using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Infrastructure.Services
{
    public class Email
    {
        private static string emailEmpresa = ConfigurationManager.AppSettings["EmailEmpresa"];
        private static string passwordEmail = ConfigurationManager.AppSettings["PasswordEmail"];
        private static string serverSMTP = ConfigurationManager.AppSettings["ServerSMTP"];
        private static int portServer = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portServer"]);
        private string sendTo;
        private string subject;
        private string body;

        public Email(string sendTo, string subject, string body)
        {
            this.sendTo = sendTo;
            this.subject = subject;
            this.body = body;
        }

        public string SendTo
        {
            get
            {
                return sendTo;
            }
            set
            {
                sendTo = this.SendTo;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = this.Subject;
            }
        }

        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                body = this.Body;
            }
        }

        public void Send()
        {
            this.valid();
            MailMessage mailMessage = new MailMessage(emailEmpresa, this.sendTo, this.subject, this.body);
            SmtpClient client = prepareSmtpClient();
            prepareCredential(client);
            mailMessage.IsBodyHtml = true;
            client.EnableSsl = true;
            client.Send(mailMessage);
        }


        public void valid()
        {
            // Verifica se o e-mail é válido.
            Regex valid = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (!valid.IsMatch(this.sendTo))
                throw new InvalidOperationException("Invalid email.");
        }

        private static void prepareCredential(SmtpClient client)
        {
            NetworkCredential credential = new NetworkCredential(emailEmpresa, passwordEmail);
            client.Credentials = credential;
        }

        private static SmtpClient prepareSmtpClient()
        {
            SmtpClient client = new SmtpClient(serverSMTP, portServer);
            return client;
        }
    }
}
