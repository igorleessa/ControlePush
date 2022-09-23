using MediatR;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Handler.Query
{
    public class GetAllCarrosQuery : IRequest<GetAllCarrosQueryResponse>
    {
    }

    public class GetAllCarrosQueryResponse
    {
        public IList<CarroOutPutDto> Carros { get; set; }

        public GetAllCarrosQueryResponse(IList<CarroOutPutDto> carros)
        {
            Carros = carros;
        }
    }
}
