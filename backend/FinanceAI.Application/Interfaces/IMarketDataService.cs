using FinanceAI.Application.DTOs;

namespace FinanceAI.Application.Interfaces;

public interface IMarketDataService
{
    Task<IEnumerable<PriceHistoryDto>> GetHistoricalAsync(string symbol, CancellationToken cancellationToken = default);
}