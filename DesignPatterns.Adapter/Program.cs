using SendGrid;

namespace DesignPatterns.Adapter
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            var apiKey = "api-key";
            var notificationService = new EmailAdapter(new SendGridClient(apiKey));

            var event1 = new FirstEvent(notificationService);
            await event1.ExecuteAsync();

            var event2 = new SecondEvent(notificationService);
            await event2.Execute();
        }
    }
}