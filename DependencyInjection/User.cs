using DependencyInjection;

public class User
{
    private ConsoleNotification _notificationService;
    public User(string userName)
    {
        Username = userName;
        _notificationService = new ConsoleNotification();
    }

    public string Username { get; set; }

    public void ChangeUserName(string newUserName)
    {
        Username = newUserName;
        _notificationService.NotifyUserNameChanged(this);
    }
}