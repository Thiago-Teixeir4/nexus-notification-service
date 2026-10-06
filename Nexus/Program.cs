using Nexus.Services;

namespace Nexus;

class Program
{
    static void Main(string[] args)
    {
        INotificationService emailNotification =
            new EmailNotifier("email@example.com", "sender@example.com", "Congratulations", "Happy birthday!");
        emailNotification.Notify();
        INotificationService smsNotification = new SmsNotifier("911", "Help!");
        smsNotification.Notify();
    }
}