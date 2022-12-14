using SendGrid;
using SendGrid.Helpers.Mail;

namespace DesignPatterns.Adapter
{
    public class EmailAdapter : INotificationService
    {
        private readonly SendGridClient _sendGridClient;

        public EmailAdapter(SendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }

        public async Task Notify(string userId, string message)
        {
            await _sendGridClient.SendEmailAsync(new SendGridMessage());
        }
    }
}