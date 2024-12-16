using Domain.Entities;

namespace Src.Domain.Repositories;

public interface ITrafficPacketRepository
{
    void Save(TrafficPacket packet);
    IEnumerable<TrafficPacket> GetPackets(DateTime from, DateTime to);
}