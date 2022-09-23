using MediatR;
using static ControlePush.Application.Usuario.Dto.UsuarioDto;

namespace ControlePush.Application.Usuario.Hanlder.Command
{
    public class CreateUsuarioCommand : IRequest<CreateUsuarioCommandResponse>
    {
        public UsuarioInputDto Usuario { get; set; }

        public Guid IdUsuario { get; set; }

        public CreateUsuarioCommand(UsuarioInputDto usuario)
        {
            Usuario = usuario;
        }
    }

    public class CreateUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public CreateUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
