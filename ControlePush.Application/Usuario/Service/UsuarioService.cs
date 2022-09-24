using AutoMapper;
using ControlePush.Domain.Account.Repository;
using static ControlePush.Application.Usuario.Dto.UsuarioDto;
using UsuarioObj = ControlePush.Domain.Account.Usuario;
using CarroObj = ControlePush.Domain.Carro.Carro;

namespace ControlePush.Application.Usuario.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        public async Task<UsuarioOutputDto> Criar(UsuarioInputDto dto)
        {
            var usuario = mapper.Map<UsuarioObj>(dto);
            await this.usuarioRepository.Save(usuario);

            return this.mapper.Map<UsuarioOutputDto>(usuario);
        }

        public async Task<UsuarioOutputDto> ObterUsuario(Guid Id)
        {
            var result = await this.usuarioRepository.Get(Id);

            return this.mapper.Map<UsuarioOutputDto>(result);
        }

        public async Task<List<UsuarioOutputDto>> ObterTodos()
        {
            var result = await this.usuarioRepository.GetAll();

            return this.mapper.Map<List<UsuarioOutputDto>>(result);
        }

        public async void Editar(UsuarioInputDto dto)
        {
            var usuario = mapper.Map<UsuarioObj>(dto);
            await this.usuarioRepository.Update(usuario);
        }
    }
}
