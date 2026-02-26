namespace FinanceAI.Application.DTOs;

public class PriceHistoryDto
{
    public string Date { get; set; } = default!;
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
    public long Volume { get; set; }
}