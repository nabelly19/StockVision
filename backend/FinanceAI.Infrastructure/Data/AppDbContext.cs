using Microsoft.EntityFrameworkCore;
using FinanceAI.Domain.Entities;

namespace FinanceAI.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Asset> Assets { get; set; }
    public DbSet<PriceHistory> Prices { get; set; }
    public DbSet<Prediction> Predictions { get; set; }
    public DbSet<Sentiment> Sentiments { get; set; }
}