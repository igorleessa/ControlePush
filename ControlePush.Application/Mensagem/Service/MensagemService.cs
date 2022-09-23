using System.Text;
using MensagemObj = ControlePush.Domain.Mensagem.Mensagem;

namespace ControlePush.Application.Mensagem.Service
{
    public class MensagemService : IMensagemService
    {
        private const string key = "K1YB3LX5RMSGF0G463VM801M0GVO4XJPP4RKBAPS0R8YVQ0C0AHYTQ4KIUZ8IHUHRK1QB6W7U4L3R1Y1RDMYNOA7YQSTRK9RBAP6XXJVF32KS3L97M6655PQATJ3R6Y6";
        private static readonly HttpClient client = new HttpClient();

        public string EnviarSms(MensagemObj request)
        {
            var erros = ValidaRequest(request);
            
            if (!string.IsNullOrWhiteSpace(erros))
            {
                return erros;
            }
            var values = new Dictionary<string, string> {
                { "key", key},
                { "type", "9" },
                { "number", request.number.ToString() },
                { "msg", request.msg }
            };

            var content = new FormUrlEncodedContent(values);
            var response = client.PostAsync("https://api.smsdev.com.br/v1/send?",content);
            
            return "OK";
        }

        public string ValidaRequest(MensagemObj request)
        {
            var erros = new StringBuilder();

            if (string.IsNullOrEmpty(request.msg))
                erros.Append("msg obrigatório.");

            if (request.number.ToString().Length < 11)
                erros.Append("number obrigatório.");

            return erros.ToString();
        }
    }
}
