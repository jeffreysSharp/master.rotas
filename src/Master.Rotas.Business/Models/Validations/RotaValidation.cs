using FluentValidation;

namespace Master.Rotas.Business.Models.Validations
{
    public class RotaValidation : AbstractValidator<Rota>
    {
        public RotaValidation()
        {
            RuleFor(r => r.Origem)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(3, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(r => r.Destino)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(3, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(r => r.Valor)
                .NotEqual(0);
        }
    }
}
