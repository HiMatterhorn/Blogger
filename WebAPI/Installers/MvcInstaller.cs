using Application;
using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallSerServices(IServiceCollection services, IConfiguration Configuration)
        {

            services.AddApplication();
            services.AddInfrastructure();
            services.AddControllers();
        }
    }
}
