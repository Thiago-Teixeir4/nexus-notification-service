using Serilog;
using Nexus.Models;
namespace Nexus.Services;

public class EmailNotifier : INotificationService
{
    public Email Email { init; get; }

    public EmailNotifier(Email email)
    {
        Email =  email;
    }

    public void Notify()
    {
        Log.Information("Email notification service started");
        Console.WriteLine($"""
                          From: {Email.Sender}
                          To: {Email.Receiver}
                          
                          Subject: {Email.Subject}
                          ------------------------------
                          {Email.Body} 
                          """);
    }
}