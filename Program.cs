using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmailSendGrid
{
    class Program
    {
        static void Main(string[] args)
        {

            Execute().Wait();
        }
        static async Task Execute()
        {
            List<EmailAddress> emailAddresses = new List<EmailAddress>()
            {
                new EmailAddress("rubiga.rangasamy@aspiresys.com"),new EmailAddress("uthira.gopi@aspiresys.com")
            };
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("uthirakumaran01@gmail.com", "Uthira Kumaran");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("rubiga.rangasamy@aspiresys.com", "ruby");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            //Single From - To Email 
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //Single From - Multiple To
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, emailAddresses, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            
        }
    }
}
