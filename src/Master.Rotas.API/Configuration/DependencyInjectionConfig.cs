using Master.Rotas.Business.Intefaces;
using Master.Rotas.Data.Context;
using Master.Rotas.Data.Repository;

namespace Master.Rotas.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<RotaDbContext>();
            services.AddScoped<IRotaRepository, RotaRepository>();           

            return services;
        }
    }
}