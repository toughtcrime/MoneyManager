using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureService
{
    public static void AddInfrastructureServices(this IServiceCollection services,string connection)
    {
        services.AddDbContext<MainContext>(options => options.UseNpgsql(connection));
    }
}