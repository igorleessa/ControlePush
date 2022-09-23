using ControlePush.Domain.Carro;
using ControlePush.Domain.Carro.Repository;
using ControlePush.Repository.Context;
using ControlePush.Repository.DataBase;
using Microsoft.EntityFrameworkCore;

namespace ControlePush.Repository.Repository
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        public CarroRepository(ControlePushContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<Carro>> ObterTodosCarros()
        {
            return await this.Query.Include(x => x).ToListAsync();
        }
    }
}
