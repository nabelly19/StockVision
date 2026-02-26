using FinanceAI.Application.DTOs;

namespace FinanceAI.Application.Interfaces;

public interface IAssetService
{
    Task<AssetDto> CreateAsync(AssetDto assetDto, CancellationToken cancellationToken = default);
    Task<IEnumerable<AssetDto>> GetAllAsync(CancellationToken cancellationToken = default);
}