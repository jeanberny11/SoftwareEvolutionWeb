using EvolutionData.Repositories.impl;
using EvolutionData.Repositories.interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace EvolutionData.Config
{
    public static class EvolutionDataServicesBuilder
    {
        public static IServiceCollection AddEvolutionData(this IServiceCollection services)
        {
            return services.AddRepositoryServices();
        }

        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            return services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
