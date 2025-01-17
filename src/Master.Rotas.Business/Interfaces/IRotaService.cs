using Master.Rotas.Business.Models;

namespace Master.Rotas.Business.Interfaces
{
    public interface IRotaService : IDisposable
    {
        Task Adicionar(Rota rota);
        Task Atualizar(Rota rota);
        Task Remover(Guid id);
    }
}
