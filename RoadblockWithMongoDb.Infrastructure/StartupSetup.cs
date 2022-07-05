using Microsoft.Extensions.DependencyInjection;
using RoadblockWithMongoDb.Contracts.Services;
using RoadblockWithMongoDb.Infrastructure.Data;
using RoadblockWithMongoDb.Infrastructure.Data.Services;

namespace RoadblockWithMongoDb.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDataService(this IServiceCollection services)
        {
            services.AddScoped<IDataService, DataService>(); 
        }

        public static void AddMongoContext(this IServiceCollection services)
        {
            services.AddSingleton<MongoContext>();
        }
    }
}
