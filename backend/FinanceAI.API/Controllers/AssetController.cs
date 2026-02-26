    using FinanceAI.Application.DTOs;
using FinanceAI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAI.API.Controllers;

[ApiController]
[Route("api/v1/assets")]
public class AssetController : ControllerBase
{
    private readonly IAssetService _assetService;

    public AssetController(IAssetService assetService) => _assetService = assetService;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AssetDto asset)
    {
        var result = await _assetService.CreateAsync(asset);
        return CreatedAtAction(nameof(GetAll), new { symbol = result.Symbol }, result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var assets = await _assetService.GetAllAsync();
        return Ok(assets);
    }
}