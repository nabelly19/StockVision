namespace FinanceAI.Domain.ValueObjects;

public sealed class Symbol
{
    public string Code { get; }

    public Symbol(string code)
    {
        if (string.IsNullOrWhiteSpace(code) || code.Length < 1 || code.Length > 10)
        throw new ArgumentNullException("Símbolo inválido.", nameof(code));

        Code = code.ToUpperInvariant();
    }

    public override string ToString() => Code;
}
