using Src.Domain.Entities;

namespace Src.Domain.Repositories;

public interface IAlertRepository
{
    void Save(Alert alert);
    IEnumerable<Alert> GetAlerts();
}