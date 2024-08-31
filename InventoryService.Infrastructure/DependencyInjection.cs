namespace InventoryService.Infrastructure;

using Microsoft.Extensions.DependencyInjection;
using InventoryService.Application.Interfaces.IPersistence;
using InventoryService.Infrastructure.Persistence;
using CommonService.Helpers;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserContext, UserContext>();
        services.AddScoped<IUnitRepository, UnitRepository>();
        return services;
    }
}
