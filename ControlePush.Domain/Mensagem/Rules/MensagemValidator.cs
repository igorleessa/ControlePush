using FluentValidation;

namespace ControlePush.Domain.Mensagem.Rules
{
    public class MensagemValidator : AbstractValidator<Mensagem>
    {
        public MensagemValidator()
        {
            RuleFor(x => x.key).NotEmpty();
            RuleFor(x => x.msg).NotEmpty();
            RuleFor(x => x.number).NotEmpty();
            RuleFor(x => x.type).NotEmpty();
        }
    }
}
