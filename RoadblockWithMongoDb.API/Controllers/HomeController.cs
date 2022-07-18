using Microsoft.AspNetCore.Mvc;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController
    {
        private readonly IRepository<Car> _carRepository;
        public HomeController(IDataService ds)
        {
            _carRepository = ds.Cars;
        }

        [HttpPost]
        [Route("cars")]
        public async Task AddCar([FromBody] Car car)
        {
            await _carRepository.AddAsync(car);
        }

        [HttpGet]
        [Route("cars/{id}")]
        public async Task<Car> GetAsync([FromRoute] string id)
        {
            return await _carRepository.GetSingleAsync(x => x.Id == id);
        }

        [HttpDelete]
        [Route("cars/{id}")]
        public async Task DeleteAsync([FromRoute]  string id)
        {
            await _carRepository.DeleteAsync(x => x.Id == id);
        }

        [HttpPut]
        [Route("cars/{id}")]
        public async Task PutAsync([FromRoute] string id, [FromBody] Car model)
        {
            model.SetId(id);
            await _carRepository.UpdateAsync(model);
        }

        [HttpGet]
        [Route("cars")]
        public IEnumerable<Car> GetCars()
        {
            return _carRepository.GetAll();
        }
    }
}
