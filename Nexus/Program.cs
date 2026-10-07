using Serilog;
using Nexus.Services;

namespace Nexus;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Serilog.Debugging.SelfLog.Enable(Console.Error);
            
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt",
                    outputTemplate:
                    "{Timestamp:dd-MM-yyyy HH:mm:ss:fff zzz}  [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            Log.Information("No one listens to me!");

            INotificationService emailNotification =
                new EmailNotifier("email@example.com", "sender@example.com", "Congratulations", "Happy birthday!");
            emailNotification.Notify();
            INotificationService smsNotification = new SmsNotifier("911", "Help!");
            smsNotification.Notify();

            Log.Information("Program ran successfully!");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}