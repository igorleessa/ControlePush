using MediatR;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Handler.Command
{
    public class UpdateCarroCommand : IRequest<UpdateCarroCommandResponse>
    {
        public CarroEditDto Carro { get; set; }

        public Guid IdCarro { get; set; }

        public UpdateCarroCommand(CarroEditDto carro)
        {
            Carro = carro;
        }
    }

    public class UpdateCarroCommandResponse
    {
        public CarroOutputDto Carro { get; set; }

        public UpdateCarroCommandResponse(CarroOutputDto carro)
        {
            Carro = carro;
        }
    }
}
