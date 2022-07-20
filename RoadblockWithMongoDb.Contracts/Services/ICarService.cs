using RoadblockWithMongoDb.Contracts.Data.Entities;
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

        Task AddCar(Car car);
    }
}
