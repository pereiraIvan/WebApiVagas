using FluentValidation;
using WebApiVagas.Models.Entities;

namespace WebApiVagas.Models.Validation
{
    public class RequisitoValidator : AbstractValidator<Requisito>
    {
        public RequisitoValidator()
        {
            RuleFor(r => r.Descricao)
                .NotEmpty().WithMessage("A descrição do requisito deve ser informada.")
                .Length(10, 100).WithMessage("A descrição do requisito deve ter entre {MinLength} e {MaxLength} caracteres.");
        }
    }
}