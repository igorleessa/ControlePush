using ControlePush.Application.Mensagem.Service;
using ControlePush.Domain.Mensagem;
using Microsoft.AspNetCore.Mvc;

namespace ControlePush.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMensagemService mensagemService;

        public UsuarioController(IMensagemService mensagemService)
        {
            this.mensagemService = mensagemService; 
        }

        public string Post(Mensagem request)
        {
            return mensagemService.EnviarSms(request);
        }
    }
}