using DependencyInjection;

var notificationService = new ConsoleNotification();

var user1 = new User("Claes", notificationService);
user1.ChangeUserName("Kalle");

Console.Write("\n\nPress any key to continue . . . ");
Console.ReadKey();