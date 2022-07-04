using Microsoft.Extensions.DependencyInjection;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Services;
using RoadblockWithMongoDb.Infrastructure.Data.Repositories;
using RoadblockWithMongoDb.Infrastructure.Data.Services;

namespace RoadblockWithMongoDb.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }

        public static void AddDataService(this IServiceCollection services)
        {
            services.AddScoped<IDataService, DataService>(); ;
        }
    }
}
