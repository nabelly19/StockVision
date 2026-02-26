using FinanceAI.Domain.Entities;

namespace FinanceAI.Domain.Repositories;

public interface ISentimentRepository
{
    Task AddAsync(Sentiment sentiment, CancellationToken cancellationToken = default);
    Task<IEnumerable<Sentiment>> GetByAssetAsync(Guid assetId, CancellationToken cancellationToken = default);
}