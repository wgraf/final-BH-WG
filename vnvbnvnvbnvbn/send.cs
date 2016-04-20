using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vnvbnvnvbnvbn
{
    class send
    {


        public void SendEmail(string address,string filename)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.poczta.onet.pl");
            mail.From = new MailAddress("wojtasg3@autograf.pl");
            mail.To.Add(address);
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";
            Attachment attachment;
            attachment = new Attachment(filename);
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("wojtasg3@autograf.pl", "Tinittunga1");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail); 
        }


    }
}
