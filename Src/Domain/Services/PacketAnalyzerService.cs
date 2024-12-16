using Domain.Entities;
using Src.Domain.Entities;

namespace Src.Domain.Services;

public class PacketAnalyzerService : IPacketAnalyzerService
{
    private const int DDoSThreshold = 1000;

    public Threat AnalyzeTraffic(IEnumerable<TrafficPacket> packets)
    {
        var groupedBySource = packets.GroupBy(p => p.SourceIP)
            .Where(g => g.Count() > DDoSThreshold); //TODO: Exemplo de limiar

        if (!groupedBySource.Any()) return null;

        var sourceIPs = groupedBySource.Select(g => g.Key);
        return new Threat("DDoS", DateTime.UtcNow, sourceIPs);
    }
}