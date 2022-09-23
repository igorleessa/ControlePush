using ControlePush.Application.Mensagem.Service;
using ControlePush.Domain.Mensagem;
using Microsoft.AspNetCore.Mvc;

namespace ControlePush.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnviarSmsController : ControllerBase
    {
        private readonly IMensagemService mensagemService;

        public EnviarSmsController(IMensagemService mensagemService)
        {
            this.mensagemService = mensagemService; 
        }

        public string Post(Mensagem request)
        {
            return mensagemService.EnviarSms(request);
        }
    }
}