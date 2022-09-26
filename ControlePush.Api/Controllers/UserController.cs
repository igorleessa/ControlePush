using ControlePush.Application.Usuario.Handler.Query;
using ControlePush.Application.Usuario.Hanlder.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static ControlePush.Application.Usuario.Dto.UsuarioDto;

namespace ControlePush.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator; 
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.mediator.Send(new GetAllUsuariosQuery()));
        }


        [Microsoft.AspNetCore.Mvc.HttpPost("Criar")]
        public async Task<IActionResult> Criar(UsuarioInputDto dto)
        {
            var result = await this.mediator.Send(new CreateUsuarioCommand(dto));
            return Created($"{result.Usuario.Id}", result.Usuario);
        }
        
    }
}