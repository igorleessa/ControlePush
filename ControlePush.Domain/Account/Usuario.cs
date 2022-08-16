using ControlePush.CrossCutting.Entity;
using ControlePush.CrossCutting.Utils;
using ControlePush.Domain.Account.Rules;
using ControlePush.Domain.Account.ValueObject;
using FluentValidation;

namespace ControlePush.Domain.Account
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public bool Ativo { get; set; }
        public virtual IList<ControlePush.Domain.Carro.Carro> Carros { get; set; }

        public void SetPassword()
        {
            this.Password.Valor = SecurityUtils.HashSHA1(this.Password.Valor);
        }

        public void Validate() =>
           new UsuarioValidator().ValidateAndThrow(this);
    }
}
