using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace website_blog.Service
{
    public class EmailSender:IEmailSender
    {
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			throw new NotImplementedException();
		}

		public bool SendMail(string email, string message1)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            message.From = new MailAddress("yourFrom@email.com");
            message.To.Add(email);
            message.Subject = "Confirm Your Email";
            message.IsBodyHtml = true;
            message.Body = "<a href ='" + message1+ "'>Click here to confirm your email:</a>";

            smtpClient.Port = 587;
            smtpClient.Host = "sandbox.smtp.mailtrap.io";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("c68f06bef95448", "73fa6082cd147c");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);
            return true;
        }
    }
}
