using AutoMapper;
using Master.Rotas.API.ViewModels;
using Master.Rotas.Business.Models;

namespace Master.Rotas.API.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Rota, RotaViewModel>().ReverseMap();
        }
    }
}
