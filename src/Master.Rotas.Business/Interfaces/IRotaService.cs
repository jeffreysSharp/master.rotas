using Master.Rotas.Business.Models;

namespace Master.Rotas.Business.Interfaces
{
    public interface IRotaService : IDisposable
    {
        Task<bool> Adicionar(Rota rota);
        Task<bool> Atualizar(Rota rota);
        Task<bool> Remover(Guid id);
    }
}
