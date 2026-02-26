using FinanceAI.Application.Interfaces;
using FinanceAI.Application.UseCases;
using FinanceAI.Domain.Repositories;
using Moq;
using Xunit;

public class AssetServiceTests
{
    private readonly Mock<IAssetRepository> _repoMock = new();

    [Fact]
    public async Task GetAll_Returns_Assets()
    {
        _repoMock.Setup(r => r.ListAllAsync(default))
                 .ReturnsAsync(new List<Domain.Entities.Asset>());

        var service = new AssetService(_repoMock.Object);

        var result = await service.GetAllAsync();

        Assert.NotNull(result);
    }
}