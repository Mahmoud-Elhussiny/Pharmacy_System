using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Pharmacy.Core.Services
{
    public interface IConfirmEmail
    {
        Task sendEmailAsync(string toEmail, string subject, string content, string htmlcontent);
    }



    public class ConfirmEmail: IConfirmEmail
    {
        private readonly IConfiguration _configuration;

        public ConfirmEmail(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task sendEmailAsync(string toEmail, string subject, string content, string htmlcontent)
        {
            var apiKey = _configuration["SendGraidApiKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("mahmoudelhussiny1998@gmail.com", "Auth Demo");
            var to = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, htmlcontent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
