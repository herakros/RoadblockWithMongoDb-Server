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

        public ICarRepository Cars => new CarRepository(_dbContext.Database);

        public IPersonRepository Persons => new PersonRepository(_dbContext.Database);
    }
}
