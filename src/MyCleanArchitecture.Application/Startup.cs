using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyCleanArchitecture.Application.Common.AutoMapper;

namespace MyCleanArchitecture.Application
{
    public static class Startup
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return services
            .AddValidatorsFromAssembly(assembly)
            .AddMediatR(assembly)
            .AddAutoMapper(c => c.AddProfile<MappingProfile>());
        }
    }
}
