using MediatR;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Handler.Query
{
    public class GetCarroPorPlacaQuery : IRequest<GetCarroPorPlacaQueryResponse>
    {
    }

    public class GetCarroPorPlacaQueryResponse
    {
        public CarroOutPutDto Carro { get; set; }

        public GetCarroPorPlacaQueryResponse(CarroOutPutDto carro)
        {
            Carro = carro;
        }
    }
}
