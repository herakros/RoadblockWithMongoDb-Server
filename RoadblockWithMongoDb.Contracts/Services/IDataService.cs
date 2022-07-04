using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Entities;

namespace RoadblockWithMongoDb.Contracts.Services
{
    public interface IDataService
    {
        public IRepository<Car> Cars { get; }
        
        public IRepository<Person> Persons { get; }
    }
}
