using Nexus.Models;
using Serilog;
using Nexus.Services;

namespace Nexus;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt",
                    outputTemplate:
                    "{Timestamp:dd-MM-yyyy HH:mm:ss:fff zzz}  [{Level:u3}]{NewLine} {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            Log.Information("Log configuration created succesfully");

            Email email = new Email("thiago@gmail.com", "thiago@usp.br", null , "Teste");

            INotificationService emailNotifier = new EmailNotifier(email);
            emailNotifier.Notify();
            Log.Information("Program ran successfully");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}