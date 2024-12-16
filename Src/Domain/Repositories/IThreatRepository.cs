using Src.Domain.Entities;

namespace Src.Domain.Repositories;

public interface IThreatRepository
{
    void Save(Threat threat);
    Threat? GetThreatById(Guid id);
}