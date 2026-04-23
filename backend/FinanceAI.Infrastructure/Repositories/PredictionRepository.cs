using FinanceAI.Domain.Repositories;
using FinanceAI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace FinanceAI.Infrastructure.Repositories;

public class PredictionRepository : IPredictionRepository
{
    private readonly AppDbContext _db;

    public PredictionRepository(AppDbContext db) => _db = db;

    public async Task AddAsync(Domain.Entities.Prediction prediction, CancellationToken cancellationToken = default)
    {
        await _db.Predictions.AddAsync(prediction, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Domain.Entities.Prediction>> GetByAssetAsync(Guid assetId, CancellationToken cancellationToken = default)
        => await _db.Predictions.Where(p => p.AssetId == assetId).ToListAsync(cancellationToken);
}