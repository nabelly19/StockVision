namespace FinanceAI.Infrastructure.Repositories;

public class SentimentRepository : ISentimentRepository
{
    private readonly AppDbContext _db;

    public SentimentRepository(AppDbContext db) => _db = db;

    public async Task AddAsync(Domain.Entities.Sentiment sentiment, CancellationToken cancellationToken = default)
    {
        await _db.Sentiments.AddAsync(sentiment, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Domain.Entities.Sentiment>> GetByAssetAsync(Guid assetId, CancellationToken cancellationToken = default)
        => await _db.Sentiments.Where(s => s.AssetId == assetId).ToListAsync(cancellationToken);
}