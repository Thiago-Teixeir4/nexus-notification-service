namespace Nexus.Models;

public record Email(string Receiver, string Sender, string? Subject,
    string Body);
