using Infrastructure.CrossCutting;
using Infrastructure.Data;
using Infrastructure.Data.Persistence.Models.Agents;
using Microsoft.AspNetCore.Identity;
using MyCleanArchitecture.API.Configurations;
using MyCleanArchitecture.Application;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Host.AddConfigurations();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration).AddCrossCutting(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddIdentity<User, IdentityRole<Guid>>(options =>
{
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireDigit = true;
})
.AddEntityFrameworkStores<EcommerceDbContext>()
.AddDefaultTokenProviders();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
