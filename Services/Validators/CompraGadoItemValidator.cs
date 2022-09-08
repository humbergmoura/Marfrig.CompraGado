using Domain.Models;
using FluentValidation;

namespace Services.Validators;

public class CompraGadoItemValidator : AbstractValidator<CompraGadoItem>
{
    public CompraGadoItemValidator()
    {
        RuleFor(c => c.IdAnimal)
            .NotEmpty().WithMessage("Animal é obrigatório.")
            .NotNull().WithMessage("Animal é obrigatório.");

        RuleFor(c => c.Quantidade)
            .NotEmpty().WithMessage("Quantidade é obrigatório.")
            .NotNull().WithMessage("Quantidade é obrigatório.");
    }
}
