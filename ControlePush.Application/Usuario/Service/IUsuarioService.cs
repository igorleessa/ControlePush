using static ControlePush.Application.Usuario.Dto.UsuarioDto;

namespace ControlePush.Application.Usuario.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioOutputDto> Criar(UsuarioInputDto dto);
        Task<UsuarioOutputDto> ObterUsuario(Guid Id);
        Task<List<UsuarioOutputDto>> ObterTodos();
        void Editar(UsuarioInputDto dto);
    }
}
