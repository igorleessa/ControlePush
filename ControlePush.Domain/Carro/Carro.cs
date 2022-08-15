using ControlePush.Domain.Carro.Rules;
using ControlePush.Domain.Carro.ValueObject;
using FluentValidation;

namespace ControlePush.Domain.Carro
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Placa Placa { get; set; }
        public string Cor { get; set; }

        public void Validate() =>
            new CarroValidator().ValidateAndThrow(this);
    }
}
