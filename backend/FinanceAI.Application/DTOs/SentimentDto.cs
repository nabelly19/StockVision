namespace FinanceAI.Application.DTOs;

public class SentimentDto
{
    public string Source { get; set; } = default!;
    public double Score { get; set; }
}