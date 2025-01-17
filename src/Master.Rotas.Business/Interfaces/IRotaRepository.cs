
using Master.Rotas.Business.Interfaces;
using Master.Rotas.Business.Models;

namespace Master.Rotas.Business.Intefaces
{
    public interface IRotaRepository : IRepository<Rota>
    {
        Task<Rota> ObterRotaPorId(Guid id);
    }
}