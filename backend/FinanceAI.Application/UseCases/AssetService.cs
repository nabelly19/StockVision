using FinanceAI.Application.DTOs;
using FinanceAI.Application.Interfaces;
using FinanceAI.Domain.Repositories;
using FinanceAI.Domain.ValueObjects;

namespace FinanceAI.Application.UseCases;

public class AssetService : IAssetService
{
    private readonly IAssetRepository _assetRepository;

    public AssetService(IAssetRepository assetRepository)
    {
        _assetRepository = assetRepository;
    }

    public async Task<AssetDto> CreateAsync(AssetDto assetDto, CancellationToken cancellationToken = default)
    {
        var symbol = new Symbol(assetDto.Symbol);
        var asset = new Domain.Entities.Asset(symbol, assetDto.Name);

        await _assetRepository.AddAsync(asset, cancellationToken);

        return new AssetDto { Symbol = asset.Value.ToString(), Name = asset.Name };
    }

    public async Task<IEnumerable<AssetDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var assets = await _assetRepository.ListAllAsync(cancellationToken);

        return assets.Select(a => new AssetDto
        {
            Symbol = a.Value.ToString(),
            Name = a.Name
        });
    }
}