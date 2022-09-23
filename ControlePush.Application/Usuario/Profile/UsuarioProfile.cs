using static ControlePush.Application.Usuario.Dto.UsuarioDto;
using UsuarioObj = ControlePush.Domain.Account.Usuario;

namespace ControlePush.Application.Usuario.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioInputDto, UsuarioObj>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));

            CreateMap<UsuarioObj, UsuarioOutputDto>();

            CreateMap<UsuarioInputDto, UsuarioObj>();

        }
    }
}
