using Infrastructure.CrossCutting.Auth.Jwt;
using Infrastructure.CrossCutting.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CrossCutting
{
    public static class Startup
    {
        public static IServiceCollection AddCrossCutting(this IServiceCollection services, IConfiguration config)
        {
            return services.AddScoped<Authenticator>().Configure<AppSettings>(config.GetSection(nameof(AppSettings)));
        }
    }
}