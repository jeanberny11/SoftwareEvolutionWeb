using AutoMapper;
using EvolutionLogic.Profiles;
using EvolutionLogic.Services.impl;
using EvolutionLogic.Services.interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace EvolutionLogic.Config
{
    public static class EvolutionLoginServicesBuilder
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            return services.AddAllServices().AddAutoMapperProfileServices();
        }

        public static IServiceCollection AddAllServices(this IServiceCollection services)
        {
            return services.AddScoped<IUsuarioServices,UsuarioServices>();
        }

        public static IServiceCollection AddAutoMapperProfileServices(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile<UsuarioProfile>();
            });
            IMapper mapper = mapperConfig.CreateMapper();
            return services.AddSingleton(mapper);
        }
    }
}
