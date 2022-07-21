using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Contracts.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();

        Task<Car> GetCar(string id);

        Task EditCar(Car car);

        Task DeleteCar(string id);

        Task AddCar(CreateCarDTO car);
    }
}
