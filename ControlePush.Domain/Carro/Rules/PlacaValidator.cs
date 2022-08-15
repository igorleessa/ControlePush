using ControlePush.Domain.Carro.ValueObject;
using FluentValidation;
using System.Text.RegularExpressions;

namespace ControlePush.Domain.Carro.Rules
{
    public class PlacaValidator : AbstractValidator<Placa>
    {
        private const string Pattern = @"[A-Z]{3}[0-9][0-9A-Z][0-9]{2}";

        public PlacaValidator()
        {
            RuleFor(x => x.Valor)
                .NotEmpty()
                .Must(BeValidPlaca).WithMessage("A informada é inválida.");
        }

        private bool BeValidPlaca(string valor) => Regex.IsMatch(valor, Pattern);
    }
}
