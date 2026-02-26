using FinanceAI.Domain.Entities;

namespace FinanceAI.Domain.Repositories;

public interface IPredictionRepository
{
    Task AddAsync(Prediction prediction, CancellationToken cancellationToken = default);
    Task<IEnumerable<Prediction>> GetByAssetAsync(Guid assetId, CancellationToken cancellationToken = default);
}