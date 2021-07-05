using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Bilbayt.Web.Api.Services
{
    public interface IMailService
    {
        Task SendMailAsync();
    }

    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendMailAsync()
        {

              var apiKey = _configuration.GetValue<string>("SendGrid:ApiKey");
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("ijatuyitemi194@gmail.com", "Sunkanmi");
                var subject = "Sending with SendGrid is Fun";
                var to = new EmailAddress("sunkanmiijatuyi@gmail.com", "Sunkanmi Ijatuyi");
                var plainTextContent = "and easy to do anywhere, even with C#";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
        }
    }
}