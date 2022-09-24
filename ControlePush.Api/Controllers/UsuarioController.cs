using ControlePush.Application.Usuario.Handler.Query;
using ControlePush.Application.Usuario.Hanlder.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static ControlePush.Application.Usuario.Dto.UsuarioDto;

namespace ControlePush.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator mediator;

        public UsuarioController(IMediator mediator)
        {
            this.mediator = mediator; 
        }
        [HttpPost("Criar")]
        public async Task<IActionResult> Criar(UsuarioInputDto dto)
        {
            var result = await this.mediator.Send(new CreateUsuarioCommand(dto));
            return Created($"{result.Usuario.Id}", result.Usuario);
        }

        [HttpPost("ObterTodos")]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.mediator.Send(new GetAllUsuariosQuery()));
        }
    }
}