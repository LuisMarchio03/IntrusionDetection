using Domain.Entities;
using Src.Domain.Entities;

namespace Src.Domain.Services;

public interface IPacketAnalyzerService
{
    Threat AnalyzeTraffic(IEnumerable<TrafficPacket> packets);
} 