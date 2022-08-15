using ControlePush.CrossCutting.Entity;

namespace ControlePush.Domain.Account
{
    public class Perfil : Entity<Guid>
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public string Permissao { get; set; }
        
    }
}
