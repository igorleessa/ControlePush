using MediatR;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Handler.Command
{
    public class CreateCarroCommand : IRequest<CreateCarroCommandResponse>
    {
        public CarroInputDto Carro { get; set; }

        public Guid IdCarro { get; set; }

        public CreateCarroCommand(CarroInputDto carro)
        {
            Carro = carro;
        }
    }

    public class CreateCarroCommandResponse
    {
        public CarroOutputDto Carro { get; set; }

        public CreateCarroCommandResponse(CarroOutputDto carro)
        {
            Carro = carro;
        }
    }
}
