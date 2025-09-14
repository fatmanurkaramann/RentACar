using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACarServer.Infastructure.Context;
using Microsoft.EntityFrameworkCore;
using Scrutor;

namespace RentACarServer.Infastructure;

public static class ServiceRegistrar
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opt =>
        {
            string connectionString = configuration.GetConnectionString("SqlServer")!;
            opt.UseSqlServer(connectionString);
        });
        services.Scan(action => action.FromAssemblies(typeof(ServiceRegistrar).Assembly)
            .AddClasses(publicOnly: false).UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        return services;
    }
}