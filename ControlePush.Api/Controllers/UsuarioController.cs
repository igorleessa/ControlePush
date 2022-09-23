using ControlePush.Application.Usuario.Dto;
using ControlePush.Application.Usuario.Handler.Query;
using ControlePush.Application.Usuario.Hanlder.Command;
using ControlePush.Application.Usuario.Service;
using ControlePush.Domain.Account;
using ControlePush.Domain.Mensagem;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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
        [HttpPost]
        public async Task<IActionResult> Criar(UsuarioInputDto dto)
        {
            var result = await this.mediator.Send(new CreateUsuarioCommand(dto));
            return Created($"{result.Usuario.Id}", result.Usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Obter()
        {
            return Ok(await this.mediator.Send(new GetAllUsuariosQuery()));
        }
    }
}