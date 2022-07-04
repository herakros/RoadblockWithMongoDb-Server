using RoadblockWithMongoDb.Contracts.Data.Repositories;

namespace RoadblockWithMongoDb.Contracts.Services
{
    public interface IDataService
    {
        public ICarRepository Cars { get; }
        
        public IPersonRepository Persons { get; }
    }
}
