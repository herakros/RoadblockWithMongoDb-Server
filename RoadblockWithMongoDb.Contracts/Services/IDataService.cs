using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;

namespace RoadblockWithMongoDb.Contracts.Services
{
    public interface IDataService
    {
        public IRepository<Car> Cars { get; }
    }
}
