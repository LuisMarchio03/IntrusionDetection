using Domain.Entities;
using Src.Domain.Services;
using Xunit;
using Assert = Xunit.Assert;

namespace Test;

public class PacketAnalyzerServiceTests
{
    [Fact]
    public void AnalyzeTraffic_ShouldDetectDDoS_WhenThresholdExceeded()
    {
        // Simule 1001 pacotes do mesmo IP
        var packets = Enumerable.Range(0, 1002)
            .Select(_ => new TrafficPacket { SourceIP = "192.168.1.1", Timestamp = DateTime.UtcNow })
            .ToList();
        
        var service = new PacketAnalyzerService();
        var threat = service.AnalyzeTraffic(packets);

        Assert.NotNull(threat);
        Assert.Equal("DDoS", threat.ThreatType);
        Assert.Contains("192.168.1.1", threat.SourceIPs);
    }
}