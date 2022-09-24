using System.ComponentModel.DataAnnotations;
using static ControlePush.Application.Carro.Dto.CarroDto;

namespace ControlePush.Application.Usuario.Dto
{
    public class UsuarioDto
    {
        public record UsuarioInputDto(
                    [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                    [Required(ErrorMessage = "Cpf é obrigatório")] string Cpf,
                    [Required(ErrorMessage = "Telefone é obrigatório")] string Telefone,
                    [Required(ErrorMessage = "Data de Nascimento é obrigatório")] DateTime DataNascimento,
                    [Required(ErrorMessage = "Telefone é obrigatório")] string Email,
                    [Required(ErrorMessage = "Flag ativo é obrigatório")] bool Ativo,
                    List<CarroInputDto> Carros);

        public record UsuarioOutputDto(Guid Id, string Nome, string Cpf, string Telefone, DateTime DataNascimento, string Email, bool Ativo, List<CarroOutputDto> Carros);

        //public record CarrosInputDto(string Marca, string Modelo, string Placa, string Cor);

        //public record CarrosOutputDto(Guid Id, string Marca, string Modelo, string Placa, string Cor);
    }
}
