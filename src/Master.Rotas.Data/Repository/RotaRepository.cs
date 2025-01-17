using Master.Rotas.Business.Intefaces;
using Master.Rotas.Business.Models;
using Master.Rotas.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Master.Rotas.Data.Repository
{
    public class RotaRepository : Repository<Rota>, IRotaRepository
    {
        public RotaRepository(RotaDbContext context) : base(context)
        {
        }

        public async Task<Rota> ObterRotaPorId(Guid id)
        {
            return await Db.Rotas.AsNoTracking()    
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
