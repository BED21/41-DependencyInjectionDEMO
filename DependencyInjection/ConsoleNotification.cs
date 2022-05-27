
namespace DependencyInjection
{
    public class ConsoleNotification : INotificationService
    {
        public void NotifyUserNameChanged(User user)
        {
            Console.WriteLine($"Username has been changed to: {user.Username}");
        }
    }
}
