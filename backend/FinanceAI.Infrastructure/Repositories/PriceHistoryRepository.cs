using FinanceAI.Domain.Repositories;
using FinanceAI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace FinanceAI.Infrastructure.Repositories;

public class PriceHistoryRepository : IPriceHistoryRepository
{
    private readonly AppDbContext _db;

    public PriceHistoryRepository(AppDbContext db) => _db = db;

    public async Task AddRangeAsync(IEnumerable<Domain.Entities.PriceHistory> prices, CancellationToken cancellationToken = default)
    {
        _db.Prices.AddRange(prices);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Domain.Entities.PriceHistory>> GetByAssetAsync(Guid assetId, CancellationToken cancellationToken = default)
        => await _db.Prices.Where(x => x.AssetId == assetId).ToListAsync(cancellationToken);
}