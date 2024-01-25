using APIVoos.IoC.Modulos;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Runtime.CompilerServices;

namespace APIVoos.IoC
{
    public static class Bootstrapper
    {
        public static IServiceCollection StartRegisterServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            ServiceModule.InjectDependencies(services);
            return services;
        }
    }
}
