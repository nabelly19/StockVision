namespace FinanceAI.Domain.Entities;

public sealed class PriceHistory
{
    public Guid Id { get; private set; }
    public Guid AssetId { get; private set; }
    public DateTime Date { get; private set; }
    public decimal Open { get; private set; }
    public decimal Close { get; private set; }
    public decimal High { get; private set; }
    public decimal Low { get; private set; }
    public long Volume { get; private set; }

    private PriceHistory() { }

    public PriceHistory(Guid assetId, DateTime date, decimal open, decimal close, decimal high, decimal low, long volume)
    {
        Id = Guid.NewGuid();
        AssetId = assetId;
        Date = date;

        Open = open >= 0 ? open : throw new ArgumentNullException(nameof(open));
        High = high >= 0 ? high : throw new ArgumentOutOfRangeException(nameof(high));
        Low = low >= 0 ? low : throw new ArgumentOutOfRangeException(nameof(low));
        Close = close >= 0 ? close : throw new ArgumentOutOfRangeException(nameof(close));
        Volume = volume >= 0 ? volume : throw new ArgumentOutOfRangeException(nameof(volume));
    }

    public decimal Change => Close - Open;
    public decimal PercentageChange => Open == 0 ? 0 : (Close - Open) / Open * 100;
}