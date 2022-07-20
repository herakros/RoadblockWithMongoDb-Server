using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Core.Services
{
    public class TruckService : ITruckService
    {
        private readonly IRepository<Truck> _truckRepository;
        public TruckService(IDataService dataService)
        {
            _truckRepository = dataService.Trucks;
        }
        public async Task AddTruck(Truck truck)
        {
            await _truckRepository.AddAsync(truck);
        }

        public async Task DeleteTruck(string id)
        {
            await _truckRepository.DeleteAsync(x => x.Id == id);
        }

        public async Task EditTruck(Truck truck)
        {
            await  _truckRepository.UpdateAsync(truck);
        }

        public async Task<Truck> GetTruck(string id)
        {
            return await _truckRepository.GetSingleAsync(x => x.Id == id);
        }

        public IEnumerable<Truck> GetTrucks()
        {
            return _truckRepository.GetAll();
        }
    }
}
