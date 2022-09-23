using ControlePush.Domain.Mensagem;
using MensagemObj = ControlePush.Domain.Mensagem.Mensagem;


namespace ControlePush.Application.Mensagem.Service
{
    public interface IMensagemService
    {
        string EnviarSms(MensagemObj request);
    }
}
