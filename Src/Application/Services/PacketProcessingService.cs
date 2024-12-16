using Domain.Entities;
using Src.Domain.Repositories;
using Src.Domain.Services;

namespace Src.Application.Services;

public class PacketProcessingService
{
 
    private readonly ITrafficPacketRepository _packetRepository;
    private readonly IPacketAnalyzerService _analyzerService;
    private readonly IThreatRepository _threatRepository;

    public PacketProcessingService(
        ITrafficPacketRepository packetRepository,
        IPacketAnalyzerService analyzerService,
        IThreatRepository threatRepository)
    {
        _packetRepository = packetRepository;
        _analyzerService = analyzerService;
        _threatRepository = threatRepository;
    }

    public void ProcessPackets(IEnumerable<TrafficPacket> packets)
    {
        foreach (var packet in packets)
        {
            _packetRepository.Save(packet);
        }

        var threat = _analyzerService.AnalyzeTraffic(packets);

        // TODO: ARRUMAR WARNING
        if (threat != null) 
        {
            _threatRepository.Save(threat);
            // TODO: Notificar a camada de interface sobre a ameaça 
        }
        
    }
}