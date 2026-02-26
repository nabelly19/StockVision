// Application Services
builder.Services.AddScoped<IAssetService, AssetService>();
builder.Services.AddScoped<IMarketDataService, MarketDataService>();

// Repositories
builder.Services.AddScoped<IAssetRepository, AssetRepository>();
builder.Services.AddScoped<IPriceHistoryRepository, PriceHistoryRepository>();
builder.Services.AddScoped<IPredictionRepository, PredictionRepository>();
builder.Services.AddScoped<ISentimentRepository, SentimentRepository>();

// FluentValidation
builder.Services.AddValidatorsFromAssembly(typeof(AssetDtoValidator).Assembly);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.MapControllers();
app.Run();