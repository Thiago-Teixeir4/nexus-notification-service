namespace Nexus.Services;

public interface INotificationService
{
    DateTime Timestamp { get; set; }
    string Receiver { get; set; }
    string Body { get; set; }

    void Notify()
    {
        Console.WriteLine("New message: " + this.Body);
    }
}
