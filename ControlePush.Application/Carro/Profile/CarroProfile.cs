using static ControlePush.Application.Carro.Dto.CarroDto;
using CarroObj = ControlePush.Domain.Carro.Carro;

namespace ControlePush.Application.Carro.Profile
{
    public class CarroProfile : AutoMapper.Profile
    {
        public CarroProfile()
        {
            CreateMap<CarroInputDto, CarroObj>()
                .ForPath(x => x.Placa.Valor, f => f.MapFrom(m => m.Placa));

            CreateMap<CarroObj, CarroOutputDto>();

            CreateMap<CarroInputDto, CarroObj>();

            CreateMap<CarroObj, CarroOutputDto>();

        }
    }
}
