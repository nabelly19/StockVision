using FinanceAI.Domain.Entities;
using FinanceAI.Domain.ValueObjects;
using FluentAssertions;
using Xunit;

public class AssetDomainTests
{
    [Fact]
    public void Create_Asset_WithValidValues_ShouldSucceed()
    {
        var symbol = new Symbol("AAPL");
        var asset = new Asset(symbol, "Apple Inc");

        asset.Value.Code.Should().Be("AAPL");
        asset.Name.Should().Be("Apple Inc");
    }

    [Fact]
    public void Create_Asset_WithInvalidSymbol_ShouldThrow()
    {
        Action act = () => new Asset(new Symbol(""), "Name");
        act.Should().Throw<ArgumentException>();
    }
}