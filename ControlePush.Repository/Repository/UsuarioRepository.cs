using ControlePush.Domain.Account;
using ControlePush.Domain.Account.Repository;
using ControlePush.Repository.Context;
using ControlePush.Repository.DataBase;

namespace ControlePush.Repository.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ControlePushContext context) : base(context)
        {
        }
    }
}
