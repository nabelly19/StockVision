namespace FinanceAI.Domain.Entities;

public sealed class Sentiment
{
    public Guid Id { get; private set; }
    public Guid AssetId { get; private set; }
    public double Score { get; private set; }  // Score normalized [-1..1]
    public DateTime Date { get; private set; }
    public string Source { get; private set; }

    private Sentiment() { }

    public Sentiment(Guid assetId, double score, string source)
    {
        Id = Guid.NewGuid();
        AssetId = assetId;
        Score = Math.Clamp(score, -1.0, 1.0);
        Date = DateTime.UtcNow;
        Source = string.IsNullOrWhiteSpace(source) ? throw new ArgumentException("Source inválida", nameof(source)) : source;
    }
}