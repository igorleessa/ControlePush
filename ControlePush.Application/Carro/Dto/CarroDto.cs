using System.ComponentModel.DataAnnotations;

namespace ControlePush.Application.Carro.Dto
{
    public class CarroDto
    {
        public record CarroInputDto([Required(ErrorMessage = "Marca é obrigatório")] string Marca,
            [Required(ErrorMessage = "Modelo é obrigatório")] string Modelo,
            [Required(ErrorMessage = "Placa é obrigatório")] string Placa,
            [Required(ErrorMessage = "Cor é obrigatório")] string Cor);

        public record CarroEditDto(Guid id, string Marca, string Modelo, string Placa, string Cor);

        public record CarroOutputDto(Guid Id, string Marca, string Modelo, string Placa, string Cor);

        public record CarroListOutputDto(List<CarroOutputDto> carros);

        public record CarroUpdateDto(
            Guid Id,
            [Required(ErrorMessage = "Marca é obrigatório")] string Marca,
            [Required(ErrorMessage = "Modelo é obrigatório")] string Modelo,
            [Required(ErrorMessage = "Placa é obrigatório")] string Placa,
            [Required(ErrorMessage = "Cor é obrigatório")] string Cor);
    }
}
