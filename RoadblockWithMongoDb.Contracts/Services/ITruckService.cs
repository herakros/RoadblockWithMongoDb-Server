using RoadblockWithMongoDb.Contracts.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Contracts.Services
{
    public interface ITruckService
    {
        IEnumerable<Truck> GetTrucks();

        Task<Truck> GetTruck(string id);

        Task EditTruck(Truck truck);

        Task DeleteTruck(string id);

        Task AddTruck(Truck truck);
    }
}
