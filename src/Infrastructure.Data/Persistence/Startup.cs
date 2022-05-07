using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Common;
using Infrastructure.Data.Persistence.ConnectDatabase;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCleanArchitecture.Domain.IRepositories;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Persistence
{
    public static class Startup
    {
        internal static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
        {
            var databaseSettings = config.GetSection(nameof(DatabaseSettings)).Get<DatabaseSettings>();
            string? coreConnectionString = databaseSettings.ConnectionString;
            string? dbProvider = databaseSettings.DBProvider;
            Console.WriteLine($"coreConnectionString: {coreConnectionString}");
            // const string coreConnectionString = "server=localhost;userid=root;password=haidang124;database=Ecommerce";
            // string? coreConnectionString = "server=localhost;userid=root;password=haidang124;database=Ecommerce";
            if (string.IsNullOrEmpty(coreConnectionString))
            {
                throw new InvalidOperationException("DB ConnectionString is not configured.");
            }
            if (string.IsNullOrEmpty(dbProvider))
            {
                throw new InvalidOperationException("DB Provider is not configured.");
            }
            return services
                    .Configure<DatabaseSettings>(config.GetSection(nameof(DatabaseSettings)))
                    .AddDbContext<EcommerceDbContext>(options => options.UseDatabase(dbProvider, coreConnectionString))
                    .AddRepository();
        }
        internal static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
        internal static DbContextOptionsBuilder UseDatabase(this DbContextOptionsBuilder builder, string dbProvider, string coreConnectionString)
        {
            switch (dbProvider.ToLowerInvariant())
            {
                case DbProviderKeys.Npgsql:
                // AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                // return builder.UseNpgsql(coreConnectionString, e =>
                //      e.MigrationsAssembly("Migrators.PostgreSQL"));

                case DbProviderKeys.SqlServer:
                    // return builder.UseSqlServer(coreConnectionString, e =>
                    //      e.MigrationsAssembly("Migrators.MSSQL"));
                    return builder.UseSqlServer(coreConnectionString);

                case DbProviderKeys.MySql:
                    return builder.UseMySql(
                    coreConnectionString,
                    ServerVersion.AutoDetect(coreConnectionString));

                case DbProviderKeys.Oracle:
                // return builder.UseOracle(coreConnectionString, e =>
                //      e.MigrationsAssembly("Migrators.Oracle"));

                default:
                    throw new InvalidOperationException($"DB Provider {dbProvider} is not supported.");
            }
        }
    }
}
