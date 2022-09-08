using Domain.Models;
using FluentValidation;

namespace Services.Validators;

public class PecuaristaVallidator : AbstractValidator<Pecuarista>
{
    public PecuaristaVallidator()
    {
        RuleFor(c => c.Nome)
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .NotNull().WithMessage("Nome é obrigatório.");
    }
}
