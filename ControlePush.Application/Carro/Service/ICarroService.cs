using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Carro.Service
{
    public interface ICarroService
    {
        Task<CarroOutputDto> Criar(CarroInputDto dto);
        Task<CarroOutputDto> ObterCarro(Guid Id);
        Task<List<CarroOutputDto>> ObterTodos();
        void Editar(CarroInputDto dto);
    }
}
