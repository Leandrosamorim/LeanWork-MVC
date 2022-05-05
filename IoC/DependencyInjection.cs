using Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Domain.Interfaces.Repositorios;
using Data.Repositories;
using Domain.Interfaces;
using Domain.Services;
using Domain.Interfaces.Services;

namespace IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDBContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICandidatoRepositorio, CandidatoRepositorio>();
            services.AddScoped<IVagaRepositorio, VagaRepositorio>();
            services.AddScoped<ICandidatoService, CandidatoService>();
            services.AddScoped<IVagaService, VagaService>();

            return services;
        }
    }
}
