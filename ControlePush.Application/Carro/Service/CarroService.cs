using AutoMapper;
using ControlePush.Domain.Carro.Repository;
using static ControlePush.Application.Carro.Dto.CarroDto;
using CarroObj = ControlePush.Domain.Carro.Carro;

namespace ControlePush.Application.Carro.Service
{
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository carroRepository;
        private readonly IMapper mapper;

        public CarroService(ICarroRepository carroRepository, IMapper mapper)
        {
            this.carroRepository = carroRepository;
            this.mapper = mapper;  
        }

        public async Task<CarroOutputDto> Criar(CarroInputDto dto)
        {
            var carro = mapper.Map<CarroObj>(dto);

            await this.carroRepository.Save(carro);

            return this.mapper.Map<CarroOutputDto>(carro);
        }

        public async Task<CarroOutputDto> ObterCarro(Guid Id) 
        {
            var result = await this.carroRepository.Get(Id);

            return this.mapper.Map<CarroOutputDto>(result);
        }

        public async Task<List<CarroOutputDto>> ObterTodos() 
        {
            var result = await this.carroRepository.GetAll();

            return this.mapper.Map<List<CarroOutputDto>>(result);
        }

        //public async void Editar(CarroEditDto dto) 
        //{
        //    var carro = mapper.Map<CarroObj>(dto);
        //    await this.carroRepository.Update(carro);
        //}
    }
}
