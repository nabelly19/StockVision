using FinanceAI.Domain.Repositories;
using FinanceAI.Domain.ValueObjects;
using FinanceAI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanceAI.Infrastructure.Repositories;

public class AssetRepository : IAssetRepository
{
    private readonly AppDbContext _db;

    public AssetRepository(AppDbContext db)
        => _db = db;

    public async Task AddAsync(Domain.Entities.Asset asset, CancellationToken cancellationToken = default)
    {
        await _db.Assets.AddAsync(asset, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task<Asset?> GetBySymbolAsync(Symbol symbol, CancellationToken cancellationToken = default)
        => await _db.Assets.FirstOrDefaultAsync(a => a.Value.ToString() == symbol.Code, cancellationToken);

    public async Task<IEnumerable<Asset>> ListAllAsync(CancellationToken cancellationToken = default)
        => await _db.Assets.ToListAsync(cancellationToken);
}