namespace DesignPatterns.Adapter
{
    public interface INotificationService
    {
        Task Notify(string userId, string message);
    }
}