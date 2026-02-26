using FinanceAI.Domain.Entities;

namespace FinanceAI.Domain.Repositories;


public interface IPriceHistoryRepository
{
    Task AddRangeAsync(IEnumerable<PriceHistory> prices, CancellationToken cancellationToken = default);
    Task<IEnumerable<PriceHistory>> GetByAssetAsync(Guid assetId, CancellationToken cancellationToken = default);
}