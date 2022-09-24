using MediatR;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Handler.Query
{
    public class GetCarroQuery : IRequest<GetCarroQueryResponse>
    {
        public Guid IdCarro { get; set; }

        public GetCarroQuery(Guid Id)
        {
            IdCarro = Id;
        }
    }

    public class GetCarroQueryResponse
    {
        public CarroOutputDto Carro { get; set; }

        public GetCarroQueryResponse(CarroOutputDto carro)
        {
            Carro = carro;
        }
    }
}
