using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Core.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> _carRepository;
        public CarService(IDataService dataService)
        {
            _carRepository = dataService.Cars;
        }
        public Task AddCar(Car car)
        {
            return _carRepository.AddAsync(car);
        }

        public Task DeleteCar(string id)
        {
            return _carRepository.DeleteAsync(x => x.Id == id);
        }

        public Task EditCar(Car car)
        {
            return _carRepository.UpdateAsync(car);
        }

        public Task<Car> GetCar(string id)
        {
            return _carRepository.GetSingleAsync(x => x.Id == id);
        }

        public IEnumerable<Car> GetCars()
        {
            return _carRepository.GetAll();
        }
    }
}
