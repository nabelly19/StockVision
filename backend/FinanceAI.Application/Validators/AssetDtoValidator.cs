using FluentValidation;
using FinanceAI.Application.DTOs;

namespace FinanceAI.Application.Validators;

public class AssetDtoValidator : AbstractValidator<AssetDto>
{
    public AssetDtoValidator()
    {
        RuleFor(x => x.Symbol)
            .NotEmpty().WithMessage("O símbolo é obrigatório.")
            .Length(1, 10).WithMessage("O símbolo deve ter entre 1 e 10 caracteres.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("O nome é obrigatório.");
    }
}