using AutoMapper;
using Master.Rotas.API.ViewModels;
using Master.Rotas.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace Master.Rotas.API.Controllers
{
    [Route("api/[controller]")]
    public class RotasController : MainController
    {
        private readonly IRotaRepository _rotaRepository;
        private readonly IMapper _mapper;

        public RotasController(IRotaRepository rotaRepository,
                               IMapper mapper)
        {
            _rotaRepository = rotaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RotaViewModel>> ObterTodos()
        {
            var rota = _mapper.Map<IEnumerable<RotaViewModel>>(await _rotaRepository.ObterTodos());

            return rota;
        }
    }
}
