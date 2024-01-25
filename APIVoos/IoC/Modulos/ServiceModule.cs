using Voos.Services.AppServices;
using Voos.Services.Interfaces;

namespace APIVoos.IoC.Modulos
{
    public class ServiceModule
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddTransient<IVoosServices, VoosServices>();
        }
    }
}
