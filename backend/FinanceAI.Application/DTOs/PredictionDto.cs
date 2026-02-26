namespace FinanceAI.Application.DTOs;

public class PredictionDto
{
    public string Date { get; set; } = default!;
    public decimal PredictedPrice { get; set; }
    public decimal LowerBound { get; set; }
    public decimal UpperBound { get; set; }
}