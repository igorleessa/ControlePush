using FluentValidation;

namespace ControlePush.Domain.Carro.Rules
{
    public class CarroValidator : AbstractValidator<Carro>
    {
        public CarroValidator()
        {
            RuleFor(x => x.Modelo).NotEmpty();
            RuleFor(x => x.Marca).NotEmpty();
            RuleFor(x => x.Placa).SetValidator(new PlacaValidator());
        }
    }
}
