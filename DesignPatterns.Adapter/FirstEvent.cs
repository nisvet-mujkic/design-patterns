namespace DesignPatterns.Adapter
{
    public class FirstEvent
    {
        private readonly INotificationService _notificationService;

        public FirstEvent(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task ExecuteAsync()
        {
            await _notificationService.Notify("", "");
        }
    }
}