using Master.Rotas.Business.Intefaces;
using Master.Rotas.Business.Interfaces;
using Master.Rotas.Business.Models;
using Master.Rotas.Business.Models.Validations;

namespace Master.Rotas.Business.Services
{
    public class RotaService : BaseService, IRotaService
    {
        private readonly IRotaRepository _rotaRepository;

        public RotaService(IRotaRepository rotaRepository,
                           INotificador notificador) : base(notificador)
        {
            _rotaRepository = rotaRepository;
        }

        public async Task<bool> Adicionar(Rota rota)
        {
            if (!ExecutarValidacao(new RotaValidation(), rota)) return false;

            if (_rotaRepository.Buscar(r => r.Origem == rota.Origem).Result.Any())
            {
                Notificar("Já existe uma Origem com estes nomes infomados.");
                return false;
            }

            if (_rotaRepository.Buscar(r => r.Destino == rota.Destino).Result.Any())
            {
                Notificar("Já existe um Destino com estes nomes infomados.");
                return false;
            }

            await _rotaRepository.Adicionar(rota);
            return true;
        }

        public async Task<bool> Atualizar(Rota rota)
        {
            if (!ExecutarValidacao(new RotaValidation(), rota)) return false;

            if (_rotaRepository.Buscar(r => r.Origem == rota.Origem).Result.Any())
            {
                Notificar("Já existe uma Origem com estes nomes infomados.");
                return false;
            }

            if (_rotaRepository.Buscar(r => r.Destino == rota.Destino).Result.Any())
            {
                Notificar("Já existe um Destino com estes nomes infomados.");
                return false;
            }

            await _rotaRepository.Atualizar(rota);
            return true;
        }

        public async Task<bool> Remover(Guid id)
        {
            if (_rotaRepository.ObterPorId(id) == null)
            {
                Notificar("Rota não encontrada");
                return false;
            }

            await _rotaRepository.Remover(id);
            return true;
        }

        public void Dispose()
        {
            _rotaRepository?.Dispose();
        }
    }
}
