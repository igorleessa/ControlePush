using MediatR;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Handler.Query
{
    public class GetAllCarrosQuery : IRequest<GetAllCarrosQueryResponse>
    {
    }

    public class GetAllCarrosQueryResponse
    {
        public IList<CarroOutputDto> Carros { get; set; }

        public GetAllCarrosQueryResponse(IList<CarroOutputDto> carros)
        {
            Carros = carros;
        }
    }
}
