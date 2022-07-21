using AutoMapper;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Core.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IMapper _mapper;
        public CarService(IDataService dataService, IMapper mapper)
        {
            _carRepository = dataService.Cars;
            _mapper = mapper;
        }
        public async Task AddCar(CreateCarDTO carDTO)
        {
            var car = new Car();
            _mapper.Map(carDTO, car);

            await _carRepository.AddAsync(car);
        }

        public async Task DeleteCar(string id)
        {
            await _carRepository.DeleteAsync(x => x.Id == id);
        }

        public async Task EditCar(Car car)
        {
            await _carRepository.UpdateAsync(car);
        }

        public async Task<Car> GetCar(string id)
        {
            return await _carRepository.GetSingleAsync(x => x.Id == id);
        }

        public IEnumerable<Car> GetCars()
        {
            return _carRepository.GetAll();
        }
    }
}
