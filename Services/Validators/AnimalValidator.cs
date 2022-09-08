using Domain.Models;
using FluentValidation;
using Services.Dtos;

namespace Services.Validators;

public class AnimalValidator : AbstractValidator<Animal>
{
    public AnimalValidator()
    {
        RuleFor(c => c.Descricao)
            .NotEmpty().WithMessage("Descrição é obrigatório.")
            .NotNull().WithMessage("Descrição é obrigatório.");

        RuleFor(c => c.Preco)
            .NotEmpty().WithMessage("Preço é obrigatório.")
            .NotNull().WithMessage("Preço é obrigatório.");

        RuleFor(c => c.Quantidade)
            .NotEmpty().WithMessage("Quantidade é obrigatório.")
            .NotNull().WithMessage("Quantidade é obrigatório.");

        RuleFor(c => c.IdPecuarista)
            .NotEmpty().WithMessage("Pecuarista é obrigatório.")
            .NotNull().WithMessage("Pecuarista é obrigatório.");
    }
}
