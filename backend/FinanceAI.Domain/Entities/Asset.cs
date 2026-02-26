namespace FinanceAI.Domain.Entities;

using FinanceAI.Domain.ValueObjects;

/// <summary>
/// Representa um ativo financeiro do sistema.
/// </summary>
public sealed class Asset 
{
    public Guid Id { get; private set; }
    public Symbol Value { get; private set; }
    public string Name { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Asset() { }

    public Asset(Symbol symbol, string name)
    {
        Id = Guid.NewGuid();
        Value = symbol ?? throw new ArgumentNullException(nameof(symbol));
        Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException("Nome é obrigatório.", nameof(name));
        CreatedAt = DateTime.UtcNow;
    }
}