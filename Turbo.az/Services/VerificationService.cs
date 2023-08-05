using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Turbo.az_Desktop_App.Services
{
    internal class VerificationService
    {
        public string? gmail { get; set; }  
        public string? verification { get; set; }



        public VerificationService(string? gmail)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(100000,999999);

            verification = randomNumber.ToString();

            var fromAddress = new MailAddress("turbo.az.info@gmail.com", "TurboAz");
            var toAddress = new MailAddress(gmail, "");

            string fromPassword = "zjqcwdxnykbqopma";
            string subject = "TurboAz";
            string body = $"Verification Code: {randomNumber}";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
            
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
