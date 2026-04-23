using FinanceAI.Application.DTOs;
using FinanceAI.Application.Interfaces;

namespace FinanceAI.Application.UseCases;

public class MarketDataService : IMarketDataService
{
    private readonly IExternalMarketDataProvider _provider;

    public MarketDataService(IExternalMarketDataProvider provider)
    {
        _provider = provider;
    }

    public async Task<IEnumerable<PriceHistoryDto>> GetHistoricalAsync(string symbol, CancellationToken cancellationToken = default)
    {
        var data = await _provider.GetHistoricalAsync(symbol, cancellationToken);

        return data.Select(p => new PriceHistoryDto
        {
            Date = p.Date, // .ToString("yyyy-MM-dd")
            Open = p.Open,
            High = p.High,
            Low = p.Low,
            Close = p.Close,
            Volume = p.Volume
        });
    }
}