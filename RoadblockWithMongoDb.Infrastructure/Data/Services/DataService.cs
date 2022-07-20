using RoadblockWithMongoDb.Contracts.Constants;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Services;
using RoadblockWithMongoDb.Infrastructure.Data.Repositories;

namespace RoadblockWithMongoDb.Infrastructure.Data.Services
{
    public class DataService : IDataService
    {
        private readonly MongoContext _dbContext;

        public DataService(MongoContext context)
        {
            _dbContext = context;
        }

        public IRepository<Car> Cars => new BaseRepository<Car>(_dbContext.Database, MongoCollectionNames.Cars);

        public IRepository<Truck> Trucks => new BaseRepository<Truck>(_dbContext.Database, MongoCollectionNames.Trucks);
    }
}
