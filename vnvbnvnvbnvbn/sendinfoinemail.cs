using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace vnvbnvnvbnvbn
{
    class sendinfoinemail
    {

        public void SendEmail(string address, string opis)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.poczta.onet.pl");
            mail.From = new MailAddress("wojtasg3@autograf.pl");
            mail.To.Add(address);
            mail.Subject = "Test Mail - 1";
            mail.Body = opis;
            Attachment attachment;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("wojtasg3@autograf.pl", "Tinittunga1");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

    }
}
