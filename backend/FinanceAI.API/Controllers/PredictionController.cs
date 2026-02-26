[ApiController]
[Route("api/v1/stocks/{symbol}/forecast")]
public class PredictionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetForecast(string symbol, int days = 7)
        => Ok(new { Symbol = symbol, Forecast = Array.Empty<object>() });
}