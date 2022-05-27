using DependencyInjection;

public class User
{
    private INotificationService _notificationService;
    public User(string userName, INotificationService notificationService)
    {
        Username = userName;
        _notificationService = notificationService;
    }

    public string Username { get; set; }

    public void ChangeUserName(string newUserName)
    {
        Username = newUserName;
        _notificationService.NotifyUserNameChanged(this);
    }
}