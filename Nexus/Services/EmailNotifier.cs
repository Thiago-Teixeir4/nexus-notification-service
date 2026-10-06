namespace Nexus.Services;

public class EmailNotifier : INotificationService
{
    public DateTime Timestamp { get; set; }
    public string Receiver { get; set; }
    public string Sender { get; set; }
    public string Subject { get; }
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

    public void Notify()
    {
        Console.WriteLine($"""
                           New message:
                           from {this.Sender}
                           ------------------
                           subject: {this.Subject}
                           Message: {this.Body}
                           Sent at {this.Timestamp}
                           """);
    }
}