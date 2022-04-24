using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.ConnectDatabase;
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
            var databaseSettings = config.GetSection(nameof(DatabaseSettings)).Get<DatabaseSettings>();
            // string? coreConnectionString = databaseSettings.ConnectionString;
            const string coreConnectionString = "server=localhost;userid=root;password=haidang124;database=Ecommerce";
            // string? coreConnectionString = "server=localhost;userid=root;password=haidang124;database=Ecommerce";
            // if (string.IsNullOrEmpty(coreConnectionString))
            // {
            //     throw new InvalidOperationException("DB ConnectionString is not configured.");
            // }
            // return services.AddDbContext<EcommerceDbContext>(options => options.UseSqlServer(coreConnectionString));
            return services
            .Configure<DatabaseSettings>(config.GetSection(nameof(DatabaseSettings)))
            .AddDbContext<EcommerceDbContext>(options =>
                options.UseMySql(
                    coreConnectionString,
                    ServerVersion.AutoDetect(coreConnectionString)
                )
            );
        }
    }
}
