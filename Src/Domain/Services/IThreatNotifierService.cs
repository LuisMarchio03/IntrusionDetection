using Src.Domain.Entities;

namespace Src.Domain.Services;

public interface IThreatNotifierService
{
    void Notify(Alert alert);
}