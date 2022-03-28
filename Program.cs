using SendGrid;
using SendGrid.Helpers.Mail;
using System;
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
            var apiKey = "SG.gM8IU3SwTrmwG7wGs5bM5g.Q4BCb9w59GkCpIbwugjJkBMl9pxRjfxhhwBu450tbVQ";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("uthirakumaran01@gmail.com", "Uthira Kumaran");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("uthira.gopi@aspiresys.com", "uthira.gopi");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
