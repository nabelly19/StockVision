using FinanceAI.Application.Interfaces;
using FinanceAI.Application.DTOs;

public class AlphaVantageService : IExternalMarketDataProvider
{
    public async Task<IEnumerable<PriceHistoryDto>> GetHistoricalAsync(string symbol, CancellationToken cancellationToken = default)
    {
        // chamada real da API aqui
        return new List<PriceHistoryDto>(); // mock inicial
    }
}