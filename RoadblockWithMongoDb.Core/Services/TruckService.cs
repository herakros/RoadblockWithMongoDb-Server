using AutoMapper;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.DTO.TruckDTO;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Core.Services
{
    public class TruckService : ITruckService
    {
        private readonly IRepository<Truck> _truckRepository;
        private readonly IMapper _mapper;

        public TruckService(IDataService dataService, IMapper mapper)
        {
            _truckRepository = dataService.Trucks;
            _mapper = mapper;
        }

        public async Task AddTruck(CreateTruckDTO truckDTO)
        {
            var truck = new Truck();
            _mapper.Map(truckDTO, truck);

            await _truckRepository.AddAsync(truck);
        }

        public async Task DeleteTruck(string id)
        {
            await _truckRepository.DeleteAsync(x => x.Id == id);
        }

        public async Task EditTruck(EditTruckDTO truckDTO, string id)
        {
            var truck = await _truckRepository.GetSingleAsync(x => x.Id == id);
            _mapper.Map(truckDTO, truck);

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
