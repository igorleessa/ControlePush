using ControlePush.Domain.Mensagem.Rules;
using FluentValidation;

namespace ControlePush.Domain.Mensagem
{
    public class Mensagem 
    {
        //public Guid Id { get; set; }
        public string key { get; set; }
        public string msg { get; set; }
        public string number { get; set; }
        public int type { get; set; }
        
        public void Validate() =>
            new MensagemValidator().ValidateAndThrow(this);
    }
}
