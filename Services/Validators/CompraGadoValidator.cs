using Domain.Models;
using FluentValidation;

namespace Services.Validators;

public class CompraGadoValidator : AbstractValidator<CompraGado>
{
    public CompraGadoValidator()
    {
        RuleFor(c => c.IdPecuarista)
            .NotEmpty().WithMessage("Pecuarista é obrigatório.")
            .NotNull().WithMessage("Pecuarista é obrigatório.");

        RuleFor(c => c.DataEntrega)
            .NotEmpty().WithMessage("Data entrega é obrigatório.")
            .NotNull().WithMessage("Data entrega é obrigatório.");
    }
}