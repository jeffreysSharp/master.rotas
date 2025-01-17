using AutoMapper;
using Master.Rotas.API.ViewModels;
using Master.Rotas.Business.Intefaces;
using Master.Rotas.Business.Interfaces;
using Master.Rotas.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Master.Rotas.API.Controllers
{
    [Route("api/[controller]")]
    public class RotasController : MainController
    {
        private readonly IRotaRepository _rotaRepository;
        private readonly IRotaService _rotaService;
        private readonly IMapper _mapper;

        public RotasController(IRotaRepository rotaRepository,
                               IRotaService rotaService,
                               IMapper mapper,
                               INotificador notificador) : base(notificador) 
        {
            _rotaRepository = rotaRepository;
            _rotaService = rotaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<RotaViewModel>> ObterTodos()
        {
            var rota = _mapper.Map<IEnumerable<RotaViewModel>>(await _rotaRepository.ObterTodos());

            return rota;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<RotaViewModel>> ObterPorId(Guid id)
        {
            var rota = _mapper.Map<RotaViewModel>(await _rotaRepository.ObterPorId(id));

            if (rota == null) return NotFound();

            return rota;
        }

        [HttpPost]
        public async Task<ActionResult<RotaViewModel>> Adicionar(RotaViewModel rotaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _rotaService.Adicionar(_mapper.Map<Rota>(rotaViewModel));

            return CustomResponse(rotaViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<RotaViewModel>> Atualizar(Guid id, RotaViewModel rotaViewModel)
        {
            if (id != rotaViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(rotaViewModel);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _rotaService.Atualizar(_mapper.Map<Rota>(rotaViewModel));

            return CustomResponse(rotaViewModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<RotaViewModel>> Excluir(Guid id)
        {
            var rotaViewModel = await _rotaRepository.ObterPorId(id);

            if (rotaViewModel == null) return NotFound();

            await _rotaService.Remover(id);

            return CustomResponse(rotaViewModel);
        }
    }
}
