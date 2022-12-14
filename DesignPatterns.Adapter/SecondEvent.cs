namespace DesignPatterns.Adapter
{
    public class SecondEvent
    {
        private readonly INotificationService _notificationService;

        public SecondEvent(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task Execute()
        {
            await _notificationService.Notify("", "");
        }
    }
}
