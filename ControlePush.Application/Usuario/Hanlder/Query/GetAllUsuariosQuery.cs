using MediatR;
using static ControlePush.Application.Usuario.Dto.UsuarioDto;

namespace ControlePush.Application.Usuario.Handler.Query
{
    public class GetAllUsuariosQuery : IRequest<GetAllUsuariosQueryResponse>
    {
    }

    public class GetAllUsuariosQueryResponse
    {
        public IList<UsuarioOutputDto> Usuarios { get; set; }

        public GetAllUsuariosQueryResponse(IList<UsuarioOutputDto> usuarios)
        {
            Usuarios = usuarios;
        }
    }
}
