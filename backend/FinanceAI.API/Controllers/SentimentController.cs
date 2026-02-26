[ApiController]
[Route("api/v1/stocks/{symbol}/sentiment")]
public class SentimentController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSentiment(string symbol)
        => Ok(new { Symbol = symbol, Sentiment = Array.Empty<object>() });
}