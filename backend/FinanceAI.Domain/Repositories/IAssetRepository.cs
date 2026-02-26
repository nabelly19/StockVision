using FinanceAI.Domain.ValueObjects;
using FinanceAI.Domain.Entities;          

namespace FinanceAI.Domain.Repositories;

public interface IAssetRepository
{
    Task<Asset?> GetBySymbolAsync(Symbol symbol, CancellationToken cancellationToken = default);
    Task<IEnumerable<Asset>> ListAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(Asset asset, CancellationToken cancellationToken = default);
}