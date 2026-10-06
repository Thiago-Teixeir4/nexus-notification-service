namespace Nexus.Services;

public class SmsNotifier : INotificationService
{
    public DateTime Timestamp { get; set; }
    public string Receiver { get; set; }
    public string Body { get; set; }

    public SmsNotifier(string receiver, string body)
    {
        this.Timestamp = DateTime.Now;
        this.Receiver = receiver;
        this.Body = body;
    }
}