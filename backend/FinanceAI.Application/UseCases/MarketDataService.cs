using FinanceAI.Application.DTOs;
using FinanceAI.Application.Interfaces;

namespace FinanceAI.Application.UseCases;

public class MarketDataService : IMarketDataService
{
    private readonly IMarketDataService _marketData;

    public MarketDataService(IMarketDataService marketData)
    {
        _marketData = marketData;
    }

    public async Task<IEnumerable<PriceHistoryDto>> GetHistoricalAsync(string symbol, CancellationToken cancellationToken = default)
    {
        var prices = await _marketData.GetHistoricalAsync(symbol, cancellationToken);

        return prices.Select(p => new PriceHistoryDto
        {
            Date = p.Date.ToString("yyyy-MM-dd"),
            Open = p.Open,
            High = p.High,
            Low = p.Low,
            Close = p.Close,
            Volume = p.Volume
        });
    }
}