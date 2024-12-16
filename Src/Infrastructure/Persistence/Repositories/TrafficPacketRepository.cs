using Domain.Entities;
using Src.Domain.Repositories;
using Src.Infrastructure.Persistence;

namespace Src.Infrastructure.Persistence.Repositories;

public class TrafficPacketRepository(AppDbContext dbContext) : ITrafficPacketRepository
{
    public void Save(TrafficPacket packet)
    {
        dbContext.TrafficPackets.Add(packet);
        dbContext.SaveChanges();
    }

    public IEnumerable<TrafficPacket> GetPackets(DateTime from, DateTime to)
    {
        return dbContext.TrafficPackets
            .Where(p => p.Timestamp >= from && p.Timestamp <= to)
            .OrderBy(p => p.Timestamp)
            .ToList();
    }
}