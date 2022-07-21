using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.DTO.TruckDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Contracts.Services
{
    public interface ITruckService
    {
        IEnumerable<Truck> GetTrucks();

        Task<Truck> GetTruck(string id);

        Task EditTruck(EditTruckDTO truckDTO, string id);

        Task DeleteTruck(string id);

        Task AddTruck(CreateTruckDTO truckDTO);
    }
}
