using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Installers
{
    public interface IInstaller
    {
        void InstallSerServices(IServiceCollection services, IConfiguration Configuration);
    }
}
