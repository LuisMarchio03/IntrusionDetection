namespace Src.Domain.Entities;

public class Alert(Guid threadId, string severity)
{
    public Guid Id { get; private init; } = Guid.NewGuid();
    public Guid ThreadId { get; private init; } = threadId;
    public DateTime AlertTime { get; private init; } = DateTime.UtcNow;
    public string Severity { get; private init; } = severity;
}