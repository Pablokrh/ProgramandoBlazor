using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace AccesoADatos.CorreoElectronico
{
    public abstract class ServidorDeCorreoMaestro
    {
        private SmtpClient smtpClient;
        protected string senderMail;
        protected string password;
        protected string host;
        protected int port;
        protected bool ssl;


        protected void IntializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void SendMail( string subject, string body, List <string> receiverMail)
            //Asunto, cuerpo que se manda, y a quién o quiénes lo hace.
        {
            MailMessage mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string receptor in receiverMail)
                {
                    mailMessage.To.Add(receptor);

                }
                mailMessage.Body = body;
                mailMessage.Subject = subject;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception err) { }
            
            finally { mailMessage.Dispose();
                smtpClient.Dispose();
            }

        }
    }
}
