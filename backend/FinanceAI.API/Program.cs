using FinanceAI.Application.Interfaces;
using FinanceAI.Application.UseCases;
using FinanceAI.Application.Validators;
using FinanceAI.Domain.Repositories;
using FinanceAI.Infrastructure.Data;
using FinanceAI.Infrastructure.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();

// Swagger (opcional mas recomendado)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Application Services
builder.Services.AddScoped<IAssetService, AssetService>();
builder.Services.AddScoped<IMarketDataService, MarketDataService>();
builder.Services.AddScoped<IExternalMarketDataProvider, AlphaVantageService>();

// Repositories
builder.Services.AddScoped<IAssetRepository, AssetRepository>();
builder.Services.AddScoped<IPriceHistoryRepository, PriceHistoryRepository>();
builder.Services.AddScoped<IPredictionRepository, PredictionRepository>();
builder.Services.AddScoped<ISentimentRepository, SentimentRepository>();

// Validators
builder.Services.AddValidatorsFromAssemblyContaining<AssetDtoValidator>();

var app = builder.Build();

// 🔹 Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();