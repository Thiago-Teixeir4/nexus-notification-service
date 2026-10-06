namespace Nexus.Services;

public class EmailNotifier : INotificationService
{
    public DateTime Timestamp { get; set; }
    public string Receiver { get; set; }
    public string Sender { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

    public EmailNotifier(string receiver, string sender, string subject,
        string body)
    {
        Timestamp = DateTime.Now;
        Receiver = receiver;
        Sender = sender;
        Subject = subject;
        Body = body;
    }
}