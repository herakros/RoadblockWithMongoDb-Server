using Microsoft.Extensions.DependencyInjection;
using RoadblockWithMongoDb.Contracts.Services;
using RoadblockWithMongoDb.Core.Services;

namespace RoadblockWithMongoDb.Core
{
    public static class StartupSetup
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<ITruckService, TruckService>();
        }
    }
}
