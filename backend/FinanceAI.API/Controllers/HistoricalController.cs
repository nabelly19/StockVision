using FinanceAI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAI.API.Controllers;

[ApiController]
[Route("api/v1/stocks/{symbol}/historical")]
public class HistoricalController : ControllerBase
{
    private readonly IMarketDataService _marketData;

    public HistoricalController(IMarketDataService marketData) => _marketData = marketData;

    [HttpGet]
    public async Task<IActionResult> GetHistory(string symbol)
    {
        var history = await _marketData.GetHistoricalAsync(symbol);
        return Ok(history);
    }
}