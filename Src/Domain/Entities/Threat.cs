namespace Src.Domain.Entities;

public class Threat(string threatType, DateTime startTime, IEnumerable<string> sourceIPs)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string ThreatType { get; private set; } = threatType;
    public DateTime StartTime { get; private set; } = startTime;
    public DateTime EndTime { get; private set; } = DateTime.UtcNow;
    public IEnumerable<string> SourceIPs { get; private set; } = sourceIPs;
    
}