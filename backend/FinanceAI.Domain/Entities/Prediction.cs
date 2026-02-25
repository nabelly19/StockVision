namespace FinanceAI.Domain.Entities;

public sealed class Prediction
{
    public Guid Id { get; private set; }
    public Guid AssetId { get; private set; }
    public decimal ForecastPrice { get; private set; }
    public double Confidence { get; private set; }
    public DateTime GeneratedAt { get; private set; }

    private Prediction() { }

    public Prediction(Guid assetId, decimal forecastPrice, double confidence)
    {
        Id = Guid.NewGuid();
        AssetId = assetId;
        ForecastPrice = forecastPrice;
        Confidence = Math.Clamp(confidence, 0, 1); // 0.0 to 1.0
        GeneratedAt = DateTime.UtcNow;
    }
}