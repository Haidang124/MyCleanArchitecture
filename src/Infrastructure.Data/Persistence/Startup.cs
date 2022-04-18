using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Persistence
{
    public static class Startup
    {
        internal static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
        {
            const string coreConnectionString = "server=localhost;userid=root;password=haidang124;database=Ecommerce";
            // return services.AddDbContext<EcommerceDbContext>(options => options.UseSqlServer(coreConnectionString));
            return services.AddDbContext<EcommerceDbContext>(options =>
                options.UseMySql(
                    coreConnectionString,
                    ServerVersion.AutoDetect(coreConnectionString)
                )
            );
        }
    }
}
